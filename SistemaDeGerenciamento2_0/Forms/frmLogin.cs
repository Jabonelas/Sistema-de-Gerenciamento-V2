using DevExpress.LookAndFeel;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        public static string UsuarioLogado = string.Empty;

        private frmTelaPrincipal frmTelaPrincipal;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(this);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtUsuario);
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaSenha(e);
        }

        private void pcbExibirSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.Properties.UseSystemPasswordChar = true;
            pcbExibirSenha.Image = Resources.olho_20;
        }

        private void pcbExibirSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.Properties.UseSystemPasswordChar = false;
            pcbExibirSenha.Image = Resources.olho_aberto_20;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F10)
            {
                ReloadData();
            }
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(this))
            {
                VerificarUsuario();
            }
        }

        private bool IsLoginExiste()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var login = db.tb_registro.Where(x => x.rg_login == txtUsuario.Text && x.rg_senha == txtSenha.Text).Select(x => x.rg_login).Any();

                    return login;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Verificar Login - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarUsuarioSenha(x);

                return false;
            }
        }

        private void VerificarUsuario()
        {
            if (IsLoginExiste() == true)
            {
                UsuarioLogado = txtUsuario.Text;

                this.Hide();
                frmTelaPrincipal frmTelaPrincipal = new frmTelaPrincipal();
                frmTelaPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MensagemAtencao.MensagemUsuarioSenhasNaoEncontrados();

                txtUsuario.Focus();
            }
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}