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
    public partial class frmPerfilUsuario : DevExpress.XtraEditors.XtraForm
    {
        private frmTelaPrincipal telaPrincipal;

        public frmPerfilUsuario(frmTelaPrincipal _telaPrincipal)
        {
            InitializeComponent();

            telaPrincipal = _telaPrincipal;
        }

        private void textEdit4_Properties_Leave(object sender, EventArgs e)
        {
        }

        private void txtConfirmarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaSenha(e);
        }

        private void txtNovaSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaSenha(e);
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text == txtConfirmarSenha.Text)
            {
            }
        }
    }
}