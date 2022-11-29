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