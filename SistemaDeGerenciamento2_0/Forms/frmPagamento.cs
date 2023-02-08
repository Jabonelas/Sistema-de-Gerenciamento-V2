using DevExpress.XtraEditors;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
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
    public partial class frmPagamento : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private decimal? valorDesconto = 0;
        private decimal? jurosDia = 0;
        private decimal? parcelasJuros = 0;

        private string numeroNF;
        private string valorTotal;

        private frmTelaPrincipal frmTelaPrincipal;

        private frmPDV frmPDV;

        private PermissoesUsuario permissoesUsuario = new PermissoesUsuario();

        public frmPagamento(string _valorTotal, string _valorDesconto, string _numeroNF, frmTelaPrincipal _frmTelaPrincipal, frmPDV _frmPDV)
        {
            InitializeComponent();

            lblValorTotal.Text = _valorTotal;

            lblSubTotal.Text = _valorTotal;

            lblDescontoItens.Text = _valorDesconto;

            valorTotal = _valorTotal;

            numeroNF = _numeroNF;

            frmTelaPrincipal = _frmTelaPrincipal;

            frmPDV = _frmPDV;

            lblValorTotal.Font = new Font(lblValorTotal.Font.FontFamily, 55, FontStyle.Bold);

            ValoresConfiguracoesFinanceiras();

            PagamentoDinheiro();
        }

        private void frmPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CancelarVenda();
            }
        }

        private void ValoresConfiguracoesFinanceiras()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadosFinanceiros = db.tb_configuracao_financeira.Where(x => x.id_configuracao_financeira == 1);

                    foreach (var item in dadosFinanceiros)
                    {
                        valorDesconto = item.cf_desconto_pagamento;
                        jurosDia = item.cf_juros_dia;
                        parcelasJuros = item.cf_parcela_juros;
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Dados Configurações Financeiras na Tela de Pagamento - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarDadosConfiguracoesFinanceirasTelaPagamento(x);
            }
        }

        private void DescontoAvista()
        {
            decimal valorParcial = Convert.ToDecimal(valorTotal.Replace("R$", ""));

            decimal valorTotalDesconto = Convert.ToDecimal(valorParcial * valorDesconto / 100);

            lblDescontoGeral.Text = valorTotalDesconto.ToString("C2");

            lblAcrescimo.Text = "R$ 0,00";

            lblValorTotal.Text = (valorParcial - valorTotalDesconto).ToString("C2");
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            DescontoAvista();

            decimal valorPagoNoProduto = Convert.ToDecimal(lblDescontoGeral.Text.Replace("R$", ""));
            decimal valorJuros = Convert.ToDecimal(lblAcrescimo.Text.Replace("R$", ""));

            pnlTipoPagamento.Controls.Clear();
            frmFormaPagamentoDebito frmFormaPagamentoDebito = new frmFormaPagamentoDebito(lblValorTotal.Text, numeroNF, valorPagoNoProduto, valorJuros, frmTelaPrincipal, this, frmPDV);
            frmFormaPagamentoDebito.TopLevel = false;
            pnlTipoPagamento.Controls.Add(frmFormaPagamentoDebito);
            pnlTipoPagamento.Tag = frmFormaPagamentoDebito;
            frmFormaPagamentoDebito.Show();
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            PagamentoDinheiro();
        }

        private void PagamentoDinheiro()
        {
            DescontoAvista();

            decimal valorPagoNoProduto = Convert.ToDecimal(lblDescontoGeral.Text.Replace("R$", ""));
            decimal valorJuros = Convert.ToDecimal(lblAcrescimo.Text.Replace("R$", ""));

            pnlTipoPagamento.Controls.Clear();
            frmFormaPagamentoDinheiro frmFormaPagamentoDinheiro = new frmFormaPagamentoDinheiro(lblValorTotal.Text, numeroNF, valorPagoNoProduto, valorJuros, frmTelaPrincipal, this, frmPDV);

            frmFormaPagamentoDinheiro.TopLevel = false;
            pnlTipoPagamento.Controls.Add(frmFormaPagamentoDinheiro);
            pnlTipoPagamento.Tag = frmFormaPagamentoDinheiro;
            frmFormaPagamentoDinheiro.Show();
        }

        private void frmPagamento_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmPagamento_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void btnPix_Click(object sender, EventArgs e)
        {
            DescontoAvista();

            decimal valorPagoNoProduto = Convert.ToDecimal(lblDescontoGeral.Text.Replace("R$", ""));
            decimal valorJuros = Convert.ToDecimal(lblAcrescimo.Text.Replace("R$", ""));

            pnlTipoPagamento.Controls.Clear();
            frmFormaPagamentoPix frmFormaPagamentoPix = new frmFormaPagamentoPix(lblValorTotal.Text, numeroNF, valorPagoNoProduto, valorJuros,
            frmTelaPrincipal, this, frmPDV);
            frmFormaPagamentoPix.TopLevel = false;
            pnlTipoPagamento.Controls.Add(frmFormaPagamentoPix);
            pnlTipoPagamento.Tag = frmFormaPagamentoPix;
            frmFormaPagamentoPix.Show();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            JurosCredito();

            decimal valorPagoNoProduto = Convert.ToDecimal(lblDescontoGeral.Text.Replace("R$", ""));
            decimal valorJuros = Convert.ToDecimal(lblAcrescimo.Text.Replace("R$", ""));

            pnlTipoPagamento.Controls.Clear();
            frmFormaPagamentoCredito frmFormaPagamentoCredito = new frmFormaPagamentoCredito(lblValorTotal.Text, numeroNF, valorPagoNoProduto, valorJuros, frmTelaPrincipal, this, frmPDV);
            frmFormaPagamentoCredito.TopLevel = false;
            pnlTipoPagamento.Controls.Add(frmFormaPagamentoCredito);
            pnlTipoPagamento.Tag = frmFormaPagamentoCredito;
            frmFormaPagamentoCredito.Show();
        }

        private void JurosCredito()
        {
            decimal valorParcial = Convert.ToDecimal(valorTotal.Replace("R$", ""));

            lblDescontoGeral.Text = "R$ 0,00";

            lblValorTotal.Text = valorTotal;
        }

        private void btnFechar_Click(object sender, EventArgs e)
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
                    this.Close();
                }
            }
        }
    }
}