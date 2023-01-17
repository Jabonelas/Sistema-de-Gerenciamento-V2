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
    public partial class frmFormaPagamentoDinheiro : DevExpress.XtraEditors.XtraForm
    {
        public frmFormaPagamentoDinheiro(string _valorTotal)
        {
            InitializeComponent();
            lblValorTotal.Text = _valorTotal;
        }

        private void frmFormaPagamentoDinheiro_Load(object sender, EventArgs e)
        {
        }

        private void txtValorEntregue_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtValorEntregue.Text != string.Empty)
            {
                lblTroco.Text = (Convert.ToDecimal(txtValorEntregue.Text.Replace("R$", "")) - Convert.ToDecimal(lblValorTotal.Text.Replace("R$", ""))).ToString("C2");
            }
        }
    }
}