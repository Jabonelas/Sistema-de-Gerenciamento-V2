using DevExpress.Utils.Extensions;
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
    public partial class frmConfirmarAcesso : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private string tela;

        private frmTelaPrincipal frmTelaPrincipal = new frmTelaPrincipal();

        private List<tb_permissoes> listaPermissoes = new List<tb_permissoes>();

        public frmConfirmarAcesso(frmTelaPrincipal _frmTelaPrincipal, string _tela)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;

            tela = _tela;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            RealizarLogin();
        }

        private bool IsUsuarioPossuiAcesso = false;

        private void RealizarLogin()
        {
            if (IsLoginExiste() == true)
            {
                AcessosUsuarios();

                if (tela == "ConfigUsuario")
                {
                    VerificarAcessoConfigUsuario();
                }
                else if (tela == "Cliente" || tela == "Funcionario" || tela == "Fornecedor")
                {
                    VerificarAcessoNovoCadastro(tela);
                }
                else if (tela == "Todos Os Cadastros")
                {
                    VerificarAcessoTodosCadastros();
                }
            }
            else
            {
                MensagemAtencao.MensagemUsuarioSenhasNaoEncontrados();

                txtUsuario.Focus();
            }
        }

        private void VerificarAcessoTodosCadastros()
        {
            listaPermissoes.ForEach(x => IsUsuarioPossuiAcesso = x.pm_editar_cadastro);

            if (IsUsuarioPossuiAcesso == true)
            {
                this.Hide();
                frmCadastro frmCadastro = new frmCadastro(frmTelaPrincipal);
                frmCadastro.ShowDialog();

                this.Close();
            }
            else
            {
                MenssagemUsuarioSemPermissao();
            }
        }

        private void VerificarAcessoConfigUsuario()
        {
            listaPermissoes.ForEach(x => IsUsuarioPossuiAcesso = x.pm_criar_editar_usuario);

            if (IsUsuarioPossuiAcesso == true)
            {
                ReloadDataConfigUsuario();
            }
            else
            {
                MenssagemUsuarioSemPermissao();
            }
        }

        private void VerificarAcessoNovoCadastro(string _Cadastro)
        {
            listaPermissoes.ForEach(x => IsUsuarioPossuiAcesso = x.pm_editar_cadastro);

            if (IsUsuarioPossuiAcesso == true)
            {
                this.Hide();
                frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros(_Cadastro, frmTelaPrincipal);
                frmCadastroRegistros.ShowDialog();

                this.Close();
            }
            else
            {
                MenssagemUsuarioSemPermissao();
            }
        }

        private void MenssagemUsuarioSemPermissao()
        {
            MensagemAtencao.MensagemUsuarioSemPermissao();
            txtUsuario.Focus();
        }

        private void ReloadDataConfigUsuario()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                frmTelaPrincipal.TelaConfiguracoes(tela);

                this.Close();
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
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Verificar Login Para Acesso Restrito - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarUsuarioSenhaAcessoRestrito(x);

                return false;
            }
        }

        private void AcessosUsuarios()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var acessosUsuario = db.tb_permissoes.Join(db.tb_registro, permissao => permissao.id_permissoes, registro => registro.fk_permissoes, (permissao, registro) => new
                    {
                        Permissao = permissao,
                        Registro = registro,
                    }).Where(x => x.Permissao.id_permissoes == x.Registro.fk_permissoes && x.Registro.rg_login == txtUsuario.Text);

                    acessosUsuario.ForEach(x => listaPermissoes.Add(x.Permissao));
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Permissões Usuários Para Acesso Restrito | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarPermissoesAcessoRestrito(x);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtUsuario);
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtSenha);
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

        private void frmConfirmarAcesso_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmConfirmarAcesso_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(this);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConfirmarAcesso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MensagemAtencao.MensagemCancelar(this);
            }
            else if (e.KeyCode == Keys.F10)
            {
                RealizarLogin();
            }
        }
    }
}