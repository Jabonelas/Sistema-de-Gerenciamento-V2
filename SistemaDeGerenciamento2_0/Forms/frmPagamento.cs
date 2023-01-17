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
    public partial class frmPagamento : DevExpress.XtraEditors.XtraForm
    {
        public frmPagamento()
        {
            InitializeComponent();
        }

        public frmPagamento(string valor)
        {
            InitializeComponent();
            lblValorTotal.Text = valor;
            lblSubTotal.Text = valor;
        }

        private void frmPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            pnlTipoPagamento.Controls.Clear();
            frmFormaPagamentoDinheiro frmFormaPagamentoDinheiro = new frmFormaPagamentoDinheiro(lblValorTotal.Text);
            frmFormaPagamentoDinheiro.TopLevel = false;
            pnlTipoPagamento.Controls.Add(frmFormaPagamentoDinheiro);
            pnlTipoPagamento.Tag = frmFormaPagamentoDinheiro;
            frmFormaPagamentoDinheiro.Show();
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
        }
    }
}