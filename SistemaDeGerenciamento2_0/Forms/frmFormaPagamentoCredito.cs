using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
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
    public partial class frmFormaPagamentoCredito : DevExpress.XtraEditors.XtraForm
    {
        private decimal valorPagoNoProduto = 0;
        private decimal valorJuros = 0;
        private decimal valorFinalPago = 0;

        private string numeroNF;

        private frmPDV frmPDV;

        private frmPagamento frmPagamento;

        private frmTelaPrincipal frmTelaPrincipal;

        private PermissoesUsuario permissoesUsuario = new PermissoesUsuario();

        public static List<tb_configuracao_financeira> listaConfiguracoesFinanceiras = new List<tb_configuracao_financeira>();

        public frmFormaPagamentoCredito(string _valorFinalPago, string _numeroNF, decimal _valorPagoNoProduto,
            decimal _valorJuros, frmTelaPrincipal _frmTelaPrincipal, frmPagamento _frmPagamento, frmPDV _frmPDV)
        {
            InitializeComponent();

            BuscarConfiguracoesFinanceiras();

            lblNomeUsuario.Text = frmLogin.UsuarioLogado.ToUpper();

            lblValorTotal.Text = _valorFinalPago;

            numeroNF = _numeroNF;

            valorPagoNoProduto = _valorPagoNoProduto;

            valorJuros = _valorJuros;

            frmPDV = _frmPDV;

            frmPagamento = _frmPagamento;

            frmTelaPrincipal = _frmTelaPrincipal;

            valorFinalPago = Convert.ToDecimal(_valorFinalPago.Replace("R$", ""));

            lblNomeUsuario.Text = frmLogin.UsuarioLogado.ToUpper();

            cmbQdtParcelas.SelectedIndex = 0;
        }

        private void cmbQdtParcelas_TextChanged(object sender, EventArgs e)
        {
            int quantidadeParcelas = Convert.ToInt32(cmbQdtParcelas.Text.Replace("x", ""));

            foreach (var item in listaConfiguracoesFinanceiras)
            {
                if (item.cf_parcela_juros <= quantidadeParcelas)
                {
                    decimal valorComJuro = Convert.ToDecimal(((item.cf_juros_dia * valorFinalPago) / 100) + valorFinalPago);
                    decimal valorComJuros = Convert.ToDecimal(valorComJuro.ToString("N2"));

                    lblValorTotal.Text = valorComJuros.ToString("C2");
                    lblValorParcela.Text = (valorComJuros / quantidadeParcelas).ToString("C2");

                    frmPagamento.lblAcrescimo.Text = (valorComJuros - valorFinalPago).ToString("C2");
                    frmPagamento.lblValorTotal.Text = valorComJuros.ToString("C2");
                }
                else
                {
                    lblValorTotal.Text = valorFinalPago.ToString("C2");
                    lblValorParcela.Text = (valorFinalPago / quantidadeParcelas).ToString("C2");

                    frmPagamento.lblAcrescimo.Text = "R$ 0,00";
                    frmPagamento.lblValorTotal.Text = valorFinalPago.ToString("C2");
                }
            }
        }

        private void BuscarConfiguracoesFinanceiras()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var configuracoesFinanceiras = db.tb_configuracao_financeira.Where(x => x.id_configuracao_financeira == 1);

                    foreach (var item in configuracoesFinanceiras)
                    {
                        listaConfiguracoesFinanceiras.Add(new tb_configuracao_financeira() { cf_juros_dia = item.cf_juros_dia, cf_parcela_juros = item.cf_parcela_juros });
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Dados Configurações Financeiras na Tela de Pagamento Credito - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarDadosConfiguracoesFinanceirasTelaPagamentoCredito(x);
            }
        }

        private void btn1FinalizarVenda_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }

        private void FinalizarVenda()
        {
            valorJuros = Convert.ToDecimal(frmPagamento.lblAcrescimo.Text.Replace("R$", ""));

            valorFinalPago = Convert.ToDecimal(lblValorTotal.Text.Replace("R$", ""));

            NFSaida.NotaFiscalSaidaCredito(numeroNF, valorPagoNoProduto, valorJuros, valorFinalPago, "Credito");

            AlterarEstoque.AlterandoEstoque();

            btn1CancelarVenda.Enabled = false;
            btn1FinalizarVenda.Enabled = false;

            ImprimirCupomFiscal(numeroNF);

            frmPDV.ZerandoTodosCampos();

            frmPagamento.Close();

            this.Close();
        }

        private void ImprimirCupomFiscal(string _numeroNF)
        {
            frmCupomFiscal frmCupomFiscal = new frmCupomFiscal();
            frmCupomFiscal.Parameters["parameter1"].Value = _numeroNF;
            frmCupomFiscal.ShowPreviewDialog();
        }

        private void btn1CancelarVenda_Click(object sender, EventArgs e)
        {
            CancelarVenda();
        }

        private void CancelarVenda()
        {
            permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
            permissoesUsuario.VerificarCancelarVendaTelaPDV("Cancelar Venda Tela PDV");

            if (frmPDV.permissaoCancelarVenda == true)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Realmente Cancela a Venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    frmPDV.permissaoCancelarVenda = false;

                    frmPDV.ZerandoTodosCampos();

                    frmPagamento.Close();

                    this.Close();
                }
            }
        }

        private void frmFormaPagamentoCredito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FinalizarVenda();
            }
            else if (e.KeyCode == Keys.F9)
            {
                CancelarVenda();
            }
        }
    }
}