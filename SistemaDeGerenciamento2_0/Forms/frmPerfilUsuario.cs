using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
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
        private frmLogin frmLogin = new frmLogin();

        private string login = frmLogin.UsuarioLogado;

        public frmPerfilUsuario()
        {
            InitializeComponent();

            BuscarDadosUsuarios();
        }

        private void BuscarDadosUsuarios()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadosUsuario = db.tb_registro.Select(x => new { x.rg_email, x.rg_nome, x.rg_login }).Where(x => x.rg_login.Equals(login)).ToList();

                    foreach (var item in dadosUsuario)
                    {
                        txtEmail.Text = item.rg_email;
                        txtNome.Text = item.rg_nome;
                        txtUsuario.Text = item.rg_login;
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Dados Usuário | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarDadosUsuario(x);
            }
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
            IsSenhaInformadaIgual();
        }

        private bool IsSenhaInformadaIgual()
        {
            if (txtConfirmarSenha.Text != string.Empty)
            {
                if (txtNovaSenha.Text != txtConfirmarSenha.Text)
                {
                    MensagemAtencao.MensagemSenhasDivergentes();

                    txtConfirmarSenha.BackColor = Color.LightGray;

                    return false;
                }
                else
                {
                    txtConfirmarSenha.BackColor = Color.FromArgb(0, 255, 255, 255);

                    return true;
                }
            }

            return false;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsSenhaInformadaIgual() == true)
            {
                AtualizarSenha();
            }
        }

        private void AtualizarSenha()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    tb_registro senhaUsuario = db.tb_registro.Where(x => x.rg_login.Equals(login)).FirstOrDefault();

                    senhaUsuario.rg_senha = txtConfirmarSenha.Text;

                    db.SaveChanges();

                    AlertaConfirmacao.ChamandoAlertaSucessoNoCantoInferiorDireito(AlertaSalvar, this);
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Atualizar Senha Usuário | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoAtualizarSenhaUsuario(x);
            }
        }
    }
}