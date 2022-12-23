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
    public partial class frmDespesas : DevExpress.XtraEditors.XtraForm
    {
        private frmTelaPrincipal frmTelaPrincipal;

        public frmDespesas(frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;

            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            sqlDataSource1.Fill();
        }

        private void btnNovaDespesa_Click(object sender, EventArgs e)
        {
            frmCadastroCategoriaDespesa frmCadastroCategoriaDespesa = new frmCadastroCategoriaDespesa();
            frmCadastroCategoriaDespesa.ShowDialog();
        }

        private void frmDespesas_Load(object sender, EventArgs e)
        {
        }
    }
}