using System;
using System.Drawing;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmConfiguracoes : DevExpress.XtraEditors.XtraForm
    {
        private frmTelaPrincipal principal;

        public frmConfiguracoes(frmTelaPrincipal _principal)
        {
            InitializeComponent();

            principal = _principal;
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            TelaNovoUsuario();
        }

        private void TelaNovoUsuario()
        {
            pnlConfiguracoes.Controls.Clear();
            frmNovoUsuario frmCadastroUsuario = new frmNovoUsuario();
            frmCadastroUsuario.TopLevel = false;
            pnlConfiguracoes.Controls.Add(frmCadastroUsuario);
            pnlConfiguracoes.Tag = frmCadastroUsuario;
            frmCadastroUsuario.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            this.Size = new Size(953, 622);
            pnlConfiguracoes.Size = new Size(944, 542);

            TelaCadastrarEmpresa();
        }

        private void TelaCadastrarEmpresa()
        {
            pnlConfiguracoes.Controls.Clear();
            frmDadosEmpresa frmNovoUsuario = new frmDadosEmpresa(principal);
            frmNovoUsuario.TopLevel = false;
            pnlConfiguracoes.Controls.Add(frmNovoUsuario);
            pnlConfiguracoes.Tag = frmNovoUsuario;
            frmNovoUsuario.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Size = new Size(953, 432);
            pnlConfiguracoes.Size = new Size(923, 341);

            TelaPerfilUsuario();
        }

        private void TelaPerfilUsuario()
        {
            pnlConfiguracoes.Controls.Clear();
            frmPerfilUsuario frmPerfilUsuario = new frmPerfilUsuario(principal);
            frmPerfilUsuario.TopLevel = false;
            pnlConfiguracoes.Controls.Add(frmPerfilUsuario);
            pnlConfiguracoes.Tag = frmPerfilUsuario;
            frmPerfilUsuario.Show();
        }
    }
}