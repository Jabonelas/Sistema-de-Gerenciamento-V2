using System;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmNovoUsuario : DevExpress.XtraEditors.XtraForm
    {
        public frmNovoUsuario()
        {
            InitializeComponent();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario();
            frmCadastroUsuario.ShowDialog();
        }
    }
}