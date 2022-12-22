using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Properties;
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
        public frmPerfilUsuario()
        {
            InitializeComponent();

            txtNovaSenha.Properties.UseSystemPasswordChar = true;
            txtConfirmarSenha.Properties.UseSystemPasswordChar = true;
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
            if (txtConfirmarSenha.Text != string.Empty)
            {
                if (txtNovaSenha.Text != txtConfirmarSenha.Text)
                {
                    MensagemAtencao.MensagemSenhasDivergentes();

                    txtConfirmarSenha.BackColor = Color.LightGray;
                }
                else
                {
                    txtConfirmarSenha.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
        }

        private void pcbExibirSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtNovaSenha.Properties.UseSystemPasswordChar = false;
            txtConfirmarSenha.Properties.UseSystemPasswordChar = false;

            pcbExibirSenha.Image = Resources.olho_aberto_20;
        }

        private void pcbExibirSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtNovaSenha.Properties.UseSystemPasswordChar = true;

            txtConfirmarSenha.Properties.UseSystemPasswordChar = true;

            pcbExibirSenha.Image = Resources.olho_20;
        }
    }
}