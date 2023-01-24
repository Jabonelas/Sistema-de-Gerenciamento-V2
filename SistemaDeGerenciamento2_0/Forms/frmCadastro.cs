using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmCadastro : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private string tipoPessoa = string.Empty;

        private string tipoCadastro = string.Empty;

        public static string CNPJouCPF = string.Empty;

        private frmTelaPrincipal frmTelaPrincipal;

        private PermissoesUsuario permissoesUsuario = new PermissoesUsuario();

        public frmCadastro()
        {
            InitializeComponent();
        }

        public frmCadastro(frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;

            sqlDataSource1.FillAsync();
        }

        private void btnAdicionarCadastro_Click(object sender, EventArgs e)
        {
            ReloadDataConfigUsuario();

            tipoPessoa = "Cliente";

            VerificarAcessoCadastro();

            sqlDataSource1.FillAsync();
        }

        private void ReloadDataConfigUsuario()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                permissoesUsuario.BuscarPermissoesUsuario(frmLogin.UsuarioLogado);
            }
        }

        private void VerificarAcessoCadastro()
        {
            permissoesUsuario.BuscarPermissoesUsuario(frmLogin.UsuarioLogado);

            bool IsUsuarioPossuiAcesso = false;

            permissoesUsuario.listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_efetuar_cadastro);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros(tipoPessoa, frmTelaPrincipal);
                frmCadastroRegistros.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, tipoPessoa);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        private void VerificarAcessoAlterarCadastro(string _CPFouCNPJCadastrado)
        {
            bool IsUsuarioPossuiAcesso = false;

            permissoesUsuario.listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_editar_cadastro);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros(tipoCadastro, frmTelaPrincipal, _CPFouCNPJCadastrado, tipoPessoa);
                frmCadastroRegistros.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(tipoCadastro, frmTelaPrincipal, _CPFouCNPJCadastrado, tipoPessoa);
                frmConfirmarAcesso.ShowDialog();
            }

            sqlDataSource1.FillAsync();
        }

        private void VerificarAcessoDeletarCadastro(string _CPFouCNPJCadastrado)
        {
            bool IsUsuarioPossuiAcesso = false;

            permissoesUsuario.listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_remover_cadastro);

            if (IsUsuarioPossuiAcesso == true)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Realmente Deletar Cadastro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    DeletarDados.DeletarCadastro(CNPJouCPF);
                }
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, "Apagar Cadastro");
                frmConfirmarAcesso.ShowDialog();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmCadastro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmCadastro_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int rowHandle = 0;

        private GridColumn column;

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRowCell)
            {
                view.FocusedRowHandle = rowHandle = hitInfo.RowHandle;
                column = hitInfo.Column;
                popupMenu1.ShowPopup(barManager1, view.GridControl.PointToScreen(e.Point));
            }
        }

        private void PegandoDadosDaLinha()
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();

            tipoCadastro = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns[1]).ToString();

            tipoPessoa = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns[0]).ToString();

            if (tipoCadastro == "Pessoa Fisica")
            {
                CNPJouCPF = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns[4]).ToString();
            }
            else
            {
                CNPJouCPF = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns[6]).ToString();
            }
        }

        private void Alterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReloadDataAlterar();
        }

        private void ReloadDataAlterar()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(this))
            {
                permissoesUsuario.BuscarPermissoesUsuario(frmLogin.UsuarioLogado);

                PegandoDadosDaLinha();

                VerificarAcessoAlterarCadastro(CNPJouCPF);
            }
        }

        private void ReloadDataDeletar()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(this))
            {
                permissoesUsuario.BuscarPermissoesUsuario(frmLogin.UsuarioLogado);

                PegandoDadosDaLinha();

                VerificarAcessoDeletarCadastro(CNPJouCPF);
            }
        }

        private void Deletar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReloadDataDeletar();
        }

        //public void DeletarCadastro()
        //{
        //    try
        //    {
        //        using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
        //        {
        //            var dadosDeletarCadastro = (from registro in db.tb_registro
        //                                        join endereco in db.tb_enderecos
        //                                        on registro.fk_endereco equals endereco.id_endereco
        //                                        join informacoes in db.tb_informacoes_comerciais
        //                                        on registro.fk_informacao_comercial equals informacoes.id_informacao_comercial
        //                                        where registro.rg_cnpj == CNPJouCPF || registro.rg_cpf == CNPJouCPF
        //                                        select new
        //                                        {
        //                                            Registro = registro,
        //                                            Endereco = endereco,
        //                                            Informacoes = informacoes
        //                                        }).ToList();

        //            db.tb_registro.Remove(dadosDeletarCadastro[0].Registro);
        //            db.tb_enderecos.Remove(dadosDeletarCadastro[0].Endereco);
        //            db.tb_informacoes_comerciais.Remove(dadosDeletarCadastro[0].Informacoes);
        //            db.SaveChanges();

        //            sqlDataSource1.FillAsync();

        //            AlertaConfirmacao.ChamandoAlertaSucessoNoCantoInferiorDireito(AlertaSalvar, this);
        //        }
        //    }
        //    catch (Exception x)
        //    {
        //        LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Apagar Cadastro | {x.Message} | {x.StackTrace}");

        //        MensagemErros.ErroAoDeletarCadastro(x);
        //    }
        //}
    }
}