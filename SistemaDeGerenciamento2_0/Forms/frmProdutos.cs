using System;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmProdutos : DevExpress.XtraEditors.XtraForm
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtBuscarProduto.Text = string.Empty;
        }
    }
}