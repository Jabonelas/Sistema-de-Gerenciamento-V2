using DevExpress.XtraEditors;
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
    public partial class frmFormaPagamentoDinheiro : DevExpress.XtraEditors.XtraForm
    {
        public decimal valorPagoNoProduto = 0;
        public decimal valorJuros = 0;
        public decimal valorFinalPago = 0;

        private string numeroNF;

        private frmPDV frmPDV;

        private frmPagamento frmPagamento;

        private frmClienteCPF frmClienteCPF;

        private frmTelaPrincipal frmTelaPrincipal;

        private PermissoesUsuario permissoesUsuario = new PermissoesUsuario();

        public frmFormaPagamentoDinheiro(string _valorFinalPago, string _numeroNF, decimal _valorPagoNoProduto,
            decimal _valorJuros, frmTelaPrincipal _frmTelaPrincipal, frmPagamento _frmPagamento)
        {
            InitializeComponent();

            lblValorTotal.Text = _valorFinalPago;

            numeroNF = _numeroNF;

            valorPagoNoProduto = _valorPagoNoProduto;

            valorJuros = _valorJuros;

            frmTelaPrincipal = _frmTelaPrincipal;

            frmPagamento = _frmPagamento;

            valorFinalPago = Convert.ToDecimal(_valorFinalPago.Replace("R$", ""));

            lblNomeUsuario.Text = frmLogin.UsuarioLogado.ToUpper();
        }

        private void txtValorEntregue_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtValorEntregue.Text != string.Empty)
            {
                lblTroco.Text = (Convert.ToDecimal(txtValorEntregue.Text.Replace("R$", "")) - Convert.ToDecimal(lblValorTotal.Text.Replace("R$", ""))).ToString("C2");
            }
        }

        private void btn1FinalizarVenda_Click(object sender, EventArgs e)
        {
            NFSaida.NotaFiscalSaida(numeroNF, valorPagoNoProduto, valorJuros, valorFinalPago, "Dinheiro");

            AlterarEstoque.AlterandoEstoque();

            btn1CancelarVenda.Enabled = false;
            btn1FinalizarVenda.Enabled = false;
            txtValorEntregue.Enabled = false;
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
                    frmPagamento.Close();
                }
            }
        }
    }
}