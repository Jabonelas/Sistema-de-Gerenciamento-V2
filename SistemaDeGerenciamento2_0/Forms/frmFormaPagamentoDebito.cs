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
    public partial class frmFormaPagamentoDebito : DevExpress.XtraEditors.XtraForm
    {
        private decimal valorPagoNoProduto = 0;
        private decimal valorJuros = 0;
        private decimal valorFinalPago = 0;

        private string numeroNF;

        private frmTelaPrincipal frmTelaPrincipal;

        private frmPagamento frmPagamento;

        private PermissoesUsuario permissoesUsuario = new PermissoesUsuario();

        public frmFormaPagamentoDebito(string _valorFinalPago, string _numeroNF, decimal _valorPagoNoProduto,
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

            lblValorTotal.Text = _valorFinalPago;

            lblNomeUsuario.Text = frmLogin.UsuarioLogado.ToUpper();
        }

        private void btn1FinalizarVenda_Click(object sender, EventArgs e)
        {
            NFSaida.NotaFiscalSaida(numeroNF, valorPagoNoProduto, valorJuros, valorFinalPago, "Debito");

            AlterarEstoque.AlterandoEstoque();

            btn1CancelarVenda.Enabled = false;
            btn1FinalizarVenda.Enabled = false;
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