using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmCadastroGrupoAgrupador : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private frmCadastroProduto frmCadastroProduto;

        public frmCadastroGrupoAgrupador(frmCadastroProduto _frmCadastroProduto)
        {
            InitializeComponent();

            frmCadastroProduto = _frmCadastroProduto;

            ReloadData();

            //sqlDataSource1.FillAsync();
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmCadastroProduto))
            {
                sqlDataSource1.FillAsync();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarGrupo_Click(object sender, EventArgs e)
        {
            frmCadastroGrupo frmAdicionarGrupo = new frmCadastroGrupo();
            frmAdicionarGrupo.ShowDialog();
        }

        private void btnAdicionarSubGrupo_Click(object sender, EventArgs e)
        {
            frmCadastroAgrupador frmAdicionarSubGrupo = new frmCadastroAgrupador();
            frmAdicionarSubGrupo.ShowDialog();
        }

        private void frmCadastroGrupoSubGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmCadastroGrupoSubGrupo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmCadastroGrupoSubGrupo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}