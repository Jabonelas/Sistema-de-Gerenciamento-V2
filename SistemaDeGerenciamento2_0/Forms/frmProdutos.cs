using System;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraRichEdit.Import.Html;
using DevExpress.XtraSplashScreen;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmProdutos : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private frmTelaPrincipal frmTelaPrincipal;

        public frmProdutos()
        {
            InitializeComponent();

            sqlDataSource1.FillAsync();
        }

        public frmProdutos(frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;

            sqlDataSource1.FillAsync();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarGrupo_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmCadastroProduto = new frmCadastroProduto();
            frmCadastroProduto.ShowDialog();
        }

        private void frmProdutos_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmProdutos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmProdutos_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}