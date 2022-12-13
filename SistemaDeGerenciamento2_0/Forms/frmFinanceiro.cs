using System;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmFinanceiro : DevExpress.XtraEditors.XtraForm
    {
        public frmFinanceiro()
        {
            InitializeComponent();
        }

        private void btnAdicionarXML_Click(object sender, EventArgs e)
        {
            frmEntradaNF frm = new frmEntradaNF();
            frm.ShowDialog();
        }
    }
}