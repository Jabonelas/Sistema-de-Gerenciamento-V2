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
    public partial class frmCadastroGrupoSubGrupo : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        public frmCadastroGrupoSubGrupo()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroGrupoSubGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnAdicionarGrupo_Click(object sender, EventArgs e)
        {
            frmAdicionarGrupo frmAdicionarGrupo = new frmAdicionarGrupo();
            frmAdicionarGrupo.ShowDialog();
        }

        private void btnAdicionarSubGrupo_Click(object sender, EventArgs e)
        {
            frmAdicionarAgrupador frmAdicionarSubGrupo = new frmAdicionarAgrupador();
            frmAdicionarSubGrupo.ShowDialog();
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