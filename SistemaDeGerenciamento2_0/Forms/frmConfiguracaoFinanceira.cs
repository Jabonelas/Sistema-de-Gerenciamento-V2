using DevExpress.Data.Linq.Helpers;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmConfiguracaoFinanceira : DevExpress.XtraEditors.XtraForm
    {
        //private frmTelaPrincipal frmTelaPrincipal;
        private Form frmTelaPrincipal;

        private frmConfiguracoes frmConfiguracoes;

        //public frmConfiguracaoFinanceira(frmTelaPrincipal _frmTelaPrincipal)
        public frmConfiguracaoFinanceira(Form _frmTelaPrincipal)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;

            sqlDataSource1.FillAsync();

            sqlDataSource2.FillAsync();

            ReloadData();

            //VerificarExistencia();
        }

        public frmConfiguracaoFinanceira(frmConfiguracoes _frmConfiguracoes)
        {
            InitializeComponent();

            frmConfiguracoes = _frmConfiguracoes;

            sqlDataSource1.FillAsync();

            sqlDataSource2.FillAsync();

            ReloadData();

            //VerificarExistencia();
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                VerificarExistencia();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsExiteDados == false)
            {
                SalvarValores();
            }
            else if (IsExiteDados == true)
            {
                AtualizarValores();
            }

            SalvarDescontoPorGrupo();
        }

        private bool IsExiteDados = false;

        private void VerificarExistencia()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities7 db = new SistemaDeGerenciamento2_0Entities7())
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
                MessageBox.Show(x.ToString());
            }
        }

        private void BuscarDados()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities7 db = new SistemaDeGerenciamento2_0Entities7())
                {
                    var IsExitecadastro = db.tb_configuracao_financeira.Select(x => x.id_configuracao_financeira).Any();

                    var dadosFinanceiros = db.tb_configuracao_financeira
                          .Select(x => new
                          {
                              x.cf_desconto_pagamento,
                              x.cf_juros_dia,
                              x.cf_parcela_juros,
                              x.id_configuracao_financeira,
                          })
                          .Where(x => x.id_configuracao_financeira == 1).ToList();

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
                MessageBox.Show(x.ToString());
            }
        }

        private void AtualizarValores()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities7 db = new SistemaDeGerenciamento2_0Entities7())
                {
                    var dadosFinaneiros = db.tb_configuracao_financeira.Where(x => x.id_configuracao_financeira.Equals(1)).ToList();

                    foreach (var item in dadosFinaneiros)
                    {
                        item.cf_desconto_pagamento = Convert.ToDecimal(txtPorcentagemDesconto.Text.Replace("%", ""));
                        item.cf_juros_dia = Convert.ToDecimal(txtPorcentagemJuros.Text.Replace("%", ""));
                        item.cf_parcela_juros = Convert.ToDecimal(cmbQtdParcelas.Text.Replace("x", ""));
                    }

                    db.SaveChanges();

                    ChamandoAlertaSucessoNoCantoInferiorDireito();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void SalvarValores()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities7 db = new SistemaDeGerenciamento2_0Entities7())
                {
                    var dadosFinaneiros = new tb_configuracao_financeira
                    {
                        cf_desconto_pagamento = Convert.ToDecimal(txtPorcentagemDescontoGrupo.Text.Replace("%", "")),
                        cf_juros_dia = Convert.ToDecimal(txtPorcentagemDescontoGrupo.Text.Replace("%", "")),
                        cf_parcela_juros = Convert.ToDecimal(cmbQtdParcelas.Text.Replace("x", "")),
                    };

                    db.tb_configuracao_financeira.Add(dadosFinaneiros);
                    db.SaveChanges();

                    ChamandoAlertaSucessoNoCantoInferiorDireito();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void SalvarDescontoPorGrupo()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities7 db = new SistemaDeGerenciamento2_0Entities7())
                {
                    int fk_grupo = Convert.ToInt32(cmbGrupoAgrupador.Properties.GetKeyValueByDisplayValue(cmbGrupoAgrupador.Text));

                    var dadosFinaneiros = new tb_configuracao_financeira
                    {
                        cf_desconto_grupo_produto = Convert.ToDecimal(txtPorcentagemDescontoGrupo.Text.Replace("%", "")),
                        fk_grupo = fk_grupo
                    };

                    db.tb_configuracao_financeira.Add(dadosFinaneiros);
                    db.SaveChanges();

                    ChamandoAlertaSucessoNoCantoInferiorDireito();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void ChamandoAlertaSucessoNoCantoInferiorDireito()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n   Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $"{msg.titulo}", msg.texto, string.Empty, msg.image, msg);
        }
    }
}