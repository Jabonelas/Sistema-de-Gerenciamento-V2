using DevExpress.XtraBars;
using SistemaDeGerenciamento2_0.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0
{
    public partial class frmTelaPrincipal : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();

            TelaAcessoRapido();
        }

        private void TelaAcessoRapido()
        {
            pnlTelaPrincipal.Controls.Clear();
            frmAcessoRapido frmAcessoRapido = new frmAcessoRapido();
            frmAcessoRapido.TopLevel = false;
            pnlTelaPrincipal.Controls.Add(frmAcessoRapido);
            pnlTelaPrincipal.Tag = frmAcessoRapido;
            frmAcessoRapido.Show();
        }

        private void frmTelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnAcessoRapido_Click(object sender, EventArgs e)
        {
            TelaAcessoRapido();
        }

        private void Produtos_Click(object sender, EventArgs e)
        {
            frmProdutos frmProdutos = new frmProdutos();
            frmProdutos.ShowDialog();
        }

        private void Financeiro_Click(object sender, EventArgs e)
        {
            frmFinanceiro frmFinanceiro = new frmFinanceiro();
            frmFinanceiro.ShowDialog();
        }
    }
}