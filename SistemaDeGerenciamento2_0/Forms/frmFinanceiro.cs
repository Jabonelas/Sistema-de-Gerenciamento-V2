using System;
using System.Windows.Forms;

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

        private void frmFinanceiro_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmContasComRepeticao frmContasComRepeticao = new frmContasComRepeticao();
            frmContasComRepeticao.ShowDialog();
        }

        private void frmFinanceiro_Load(object sender, EventArgs e)
        {

        }
    }
}