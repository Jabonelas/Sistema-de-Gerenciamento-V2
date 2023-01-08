using DevExpress.Data.Linq.Helpers;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.ImageList;
using System.Data.Entity;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
using DevExpress.XtraScheduler.iCalendar.Components;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmConfiguracaoFinanceira : DevExpress.XtraEditors.XtraForm
    {
        private Form frmTelaPrincipal;

        private bool IsExiteDados = false;

        public frmConfiguracaoFinanceira(Form _frmTelaPrincipal)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;

            sqlDataSource1.FillAsync();

            sqlDataSource2.FillAsync();

            ReloadData();
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                VerificarExistencia();
            }
        }

        private void BuscarDadosUsuario()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    //var dadosUsuariop = db.tb_registro.
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvandoDados();
        }

        private void SalvandoDados()
        {
            if (IsExiteDados == false)
            {
                SalvarValores();
            }
            else if (IsExiteDados == true)
            {
                AtualizarValores();
            }

            if (cmbGrupoAgrupador.Text != string.Empty && txtPorcentagemDescontoGrupo.Text != string.Empty)
            {
                SalvarDescontoPorGrupo();

                sqlDataSource2.FillAsync();
            }
        }

        private void VerificarExistencia()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    IsExiteDados = db.tb_configuracao_financeira.Select(x => x.id_configuracao_financeira).Any();

                    if (IsExiteDados == true)
                    {
                        BuscarDados();
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Verificar Existencia de Configurações Financeiras - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarExistenciaConfiguracaoFinanceiras(x);
            }
        }

        private void BuscarDados()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadosFinanceiros = db.tb_configuracao_financeira
                          .Select(x => new
                          {
                              x.cf_desconto_pagamento,
                              x.cf_juros_dia,
                              x.cf_parcela_juros,
                              x.id_configuracao_financeira,
                          }).Where(x => x.id_configuracao_financeira == 1).ToList();

                    if (dadosFinanceiros.Count() > 0)
                    {
                        foreach (var item in dadosFinanceiros)
                        {
                            txtPorcentagemDesconto.Text = $"{item.cf_desconto_pagamento} %";
                            txtPorcentagemJuros.Text = $"{item.cf_juros_dia} %";
                            cmbQtdParcelas.Text = $"{Convert.ToInt32(item.cf_parcela_juros)}x";
                        }
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar dados da Configurações Financeiras - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarDadosConfiguracaoFinanceiras(x);
            }
        }

        private void AtualizarValores()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadosFinaneiros = db.tb_configuracao_financeira.Where(x => x.id_configuracao_financeira.Equals(1)).ToList();

                    foreach (var item in dadosFinaneiros)
                    {
                        item.cf_desconto_pagamento = Convert.ToDecimal(txtPorcentagemDesconto.Text.Replace("%", string.Empty));
                        item.cf_juros_dia = Convert.ToDecimal(txtPorcentagemJuros.Text.Replace("%", string.Empty));
                        item.cf_parcela_juros = Convert.ToDecimal(cmbQtdParcelas.Text.Replace("x", string.Empty));
                    }

                    db.SaveChanges();

                    ChamandoAlertaSucessoNoCantoInferiorDireito();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Atualizar Configurações Financeiras - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoAtualizarDadosFinanceiros(x);
            }
        }

        private void SalvarValores()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadosFinaneiros = new tb_configuracao_financeira
                    {
                        cf_desconto_pagamento = Convert.ToDecimal(txtPorcentagemDescontoGrupo.Text.Replace("%", string.Empty)),
                        cf_juros_dia = Convert.ToDecimal(txtPorcentagemDescontoGrupo.Text.Replace("%", string.Empty)),
                        cf_parcela_juros = Convert.ToDecimal(cmbQtdParcelas.Text.Replace("x", string.Empty)),
                    };

                    db.tb_configuracao_financeira.Add(dadosFinaneiros);
                    db.SaveChanges();

                    ChamandoAlertaSucessoNoCantoInferiorDireito();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Configurações Financeiras - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroFinanceiro(x);
            }
        }

        private void SalvarDescontoPorGrupo()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    int fk_grupo = Convert.ToInt32(cmbGrupoAgrupador.Properties.GetKeyValueByDisplayValue(cmbGrupoAgrupador.Text));

                    var dadosFinaneiros = new tb_configuracao_financeira
                    {
                        cf_desconto_grupo_produto = Convert.ToDecimal(txtPorcentagemDescontoGrupo.Text.Replace("%", string.Empty)),
                        fk_grupo = fk_grupo
                    };

                    db.tb_configuracao_financeira.Add(dadosFinaneiros);
                    db.SaveChanges();

                    ChamandoAlertaSucessoNoCantoInferiorDireito();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Configurações Financeiras Desconto Por Grupo - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroFinanceiroDescontoPorGrupo(x);
            }
        }

        private void ChamandoAlertaSucessoNoCantoInferiorDireito()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n   Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $"{msg.titulo}", msg.texto, string.Empty, msg.image, msg);
        }

        private void ApagarGrupoComDesconto()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    int idConfiguracaoFinanceira = PegandoDadosDaLinha();

                    var dadosConfiguracaoFinanceira = db.tb_configuracao_financeira.Where(x => x.id_configuracao_financeira == idConfiguracaoFinanceira).First();

                    db.Entry(dadosConfiguracaoFinanceira).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

                    db.tb_configuracao_financeira.Remove(dadosConfiguracaoFinanceira);
                    db.SaveChanges();

                    sqlDataSource2.FillAsync();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Deletar Configurações Financeiras Desconto Por Grupo - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoDeletarGrupoComDesconto(x);
            }
        }

        private int PegandoDadosDaLinha()
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();

            int idConfiguracaoFinanceira = Convert.ToInt32(gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns[0]));

            return idConfiguracaoFinanceira;
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.MenuType == GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                // Delete existing menu items, if any.
                e.Menu.Items.Clear();
                // Add the Rows submenu with the 'Delete Row' command
                e.Menu.Items.Add(CreateSubMenuRows(view, rowHandle));
                // Add the 'Cell Merging' check menu item.
                DXMenuItem item = CreateMenuItemCellMerging(view, rowHandle);
                item.BeginGroup = true;
                e.Menu.Items.Add(item);
            }
        }

        private DXMenuItem CreateSubMenuRows(GridView view, int rowHandle)
        {
            DXSubMenuItem subMenu = new DXSubMenuItem("Propriedade");
            string deleteRowsCommandCaption;
            if (view.IsGroupRow(rowHandle))
            {
                deleteRowsCommandCaption = "&Delete rows in this group";
            }
            else
                deleteRowsCommandCaption = "&Deletar Linha";
            DXMenuItem menuItemDeleteRow = new DXMenuItem(deleteRowsCommandCaption, new EventHandler(OnDeleteRowClick), Resources.deletar_20);
            menuItemDeleteRow.Tag = new RowInfo(view, rowHandle);
            menuItemDeleteRow.Enabled = view.IsDataRow(rowHandle) || view.IsGroupRow(rowHandle);
            subMenu.Items.Add(menuItemDeleteRow);
            return subMenu;
        }

        private DXMenuCheckItem CreateMenuItemCellMerging(GridView view, int rowHandle)
        {
            DXMenuCheckItem checkItem = new DXMenuCheckItem("Juntar &Celulas",
              view.OptionsView.AllowCellMerge, null, new EventHandler(OnCellMergingClick));
            checkItem.Tag = new RowInfo(view, rowHandle);
            checkItem.ImageOptions.Image = Resources.agrupar_20;
            return checkItem;
        }

        private void OnDeleteRowClick(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            RowInfo ri = menuItem.Tag as RowInfo;
            if (ri != null)
            {
                string message = menuItem.Caption.Replace("&", string.Empty);
                if (XtraMessageBox.Show("Deseja Deletar Esta Linha?", "Deletar Dados", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ApagarGrupoComDesconto();
                }
                else
                {
                    return;
                }
                ri.View.DeleteRow(ri.RowHandle);
            }
        }

        private void OnCellMergingClick(object sender, EventArgs e)
        {
            DXMenuCheckItem item = sender as DXMenuCheckItem;
            RowInfo info = item.Tag as RowInfo;
            info.View.OptionsView.AllowCellMerge = item.Checked;
        }

        private class RowInfo
        {
            public RowInfo(GridView view, int rowHandle)
            {
                this.RowHandle = rowHandle;
                this.View = view;
            }

            public GridView View;
            public int RowHandle;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)

                {
                    GridView view = sender as GridView;
                    view.DeleteRow(view.FocusedRowHandle);
                    gdvGruposAgrupadores.RefreshDataSource();
                    gridView1.RefreshData();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(this);
        }

        private void frmConfiguracaoFinanceira_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MensagemAtencao.MensagemCancelar(this);
            }
            else if (e.KeyCode == Keys.F10)
            {
                SalvandoDados();
            }
        }
    }
}