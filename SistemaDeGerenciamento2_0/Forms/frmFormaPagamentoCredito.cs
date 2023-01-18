using DevExpress.XtraEditors;
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
        public frmFormaPagamentoCredito()
        {
            InitializeComponent();
        }

        public frmFormaPagamentoCredito(string _valorTotal)
        {
            InitializeComponent();

            lblValorTotal.Text = _valorTotal;
            lblNomeUsuario.Text = frmLogin.UsuarioLogado;
            cmbQdtParcelas.SelectedIndex = 0;
        }

        private void frmFormaPagamentoCredito_Load(object sender, EventArgs e)
        {
        }

        private void cmbQdtParcelas_TextChanged(object sender, EventArgs e)
        {
            lblValorParcela.Text = (Convert.ToDecimal(lblValorTotal.Text.Replace("R$", "")) / Convert.ToInt32(cmbQdtParcelas.Text.Replace("x", ""))).ToString("C2");
        }
    }
}