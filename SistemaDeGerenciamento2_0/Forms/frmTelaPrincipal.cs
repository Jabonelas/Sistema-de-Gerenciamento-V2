using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Extensions;
using DevExpress.XtraSplashScreen;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Win32;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Forms;
using SistemaDeGerenciamento2_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0
{
    public partial class frmTelaPrincipal : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private PermissoesUsuario permissoesCadastro = new PermissoesUsuario();

        private List<tb_permissoes> listaPermissoes = new List<tb_permissoes>();

        //private frmLogin frmLogin = new frmLogin();

        public frmTelaPrincipal()
        {
            InitializeComponent();

            TelaAcessoRapido();

            lblUsuarioLogado.Text = frmLogin.UsuarioLogado;
        }

        private void TelaAcessoRapido()
        {
            pnlTelaPrincipal.Controls.Clear();
            frmAcessoRapido frmAcessoRapido = new frmAcessoRapido(this);
            frmAcessoRapido.TopLevel = false;
            pnlTelaPrincipal.Controls.Add(frmAcessoRapido);
            pnlTelaPrincipal.Tag = frmAcessoRapido;
            frmAcessoRapido.Show();
        }

        private void frmTelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MensagemAtencao.MensagemCancelar(this);
            }
        }

        private void Financeiro_Click(object sender, EventArgs e)
        {
            frmFinanceiro frmFinanceiro = new frmFinanceiro();
            frmFinanceiro.ShowDialog();
        }

        private void btnAcessoRapido_Click_1(object sender, EventArgs e)
        {
            TelaAcessoRapido();
        }

        public void TelaConfiguracoes(string _tela)
        {
            pnlTelaPrincipal.Controls.Clear();
            frmConfiguracoes frmConfiguracoes = new frmConfiguracoes(this, _tela);
            frmConfiguracoes.TopLevel = false;
            pnlTelaPrincipal.Controls.Add(frmConfiguracoes);
            pnlTelaPrincipal.Tag = frmConfiguracoes;
            frmConfiguracoes.Show();
        }

        public void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(this))
            {
                BuscarPermissoesUsuario();
            }
        }

        private void btnConfigUsuario_Click(object sender, EventArgs e)
        {
            ReloadData();

            VerificarAcessoConfigUsuario();
        }

        private void VerificarAcessoConfigUsuario()
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoes.ForEach(x => IsUsuarioPossuiAcesso = x.pm_criar_editar_usuario);

            if (IsUsuarioPossuiAcesso == true)
            {
                TelaConfiguracoes("ConfigUsuario");
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(this, "ConfigUsuario");
                frmConfirmarAcesso.ShowDialog();
            }
        }

        private void BuscarPermissoesUsuario()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var acessosUsuario = db.tb_permissoes.Join(db.tb_registro, permissao => permissao.id_permissoes, registro => registro.fk_permissoes, (permissao, registro) => new
                    {
                        Permissao = permissao,
                        Registro = registro,
                    }).Where(x => x.Permissao.id_permissoes == x.Registro.fk_permissoes && x.Registro.rg_login == frmLogin.UsuarioLogado);

                    foreach (var item in acessosUsuario)
                    {
                        listaPermissoes.Add(item.Permissao);
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Permissões Usuários | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarPermissoes(x);
            }
        }

        private void btnConfigEmpresa_Click(object sender, EventArgs e)
        {
            TelaConfiguracoes("ConfigEmpresa");
        }

        private void btnConfigPerfil_Click(object sender, EventArgs e)
        {
            TelaConfiguracoes("ConfigPerfil");
        }

        private void btnConfigFinanceiro_Click(object sender, EventArgs e)
        {
            TelaConfiguracoes("ConfigFinanceiro");
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            permissoesCadastro.ReloadData(this);
            permissoesCadastro.VerificarAcessoCadastroProduto();
        }

        private void btnTodosOsProdutos_Click(object sender, EventArgs e)
        {
            permissoesCadastro.ReloadData(this);
            permissoesCadastro.VerificarAcessoTodosProdutos();

            //frmProdutos frmProdutos = new frmProdutos();
            //frmProdutos.ShowDialog();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            permissoesCadastro.ReloadData(this);
            permissoesCadastro.VerificarAcessoCadastro("Cliente");
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            permissoesCadastro.ReloadData(this);
            permissoesCadastro.VerificarAcessoCadastro("Fornecedor");
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            permissoesCadastro.ReloadData(this);
            permissoesCadastro.VerificarAcessoCadastro("Funcionario");
        }

        private void btnTodosOsCadastro_Click(object sender, EventArgs e)
        {
            permissoesCadastro.ReloadData(this);
            permissoesCadastro.VerificarAcessoTodosCadastros("Todos Os Cadastros");
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
        }

        private void Produtos_Click(object sender, EventArgs e)
        {
        }

        private void btnConfigDesepsa_Click(object sender, EventArgs e)
        {
            Despesas();
        }

        private void Despesas()
        {
            pnlTelaPrincipal.Controls.Clear();
            frmDespesas frmDespesas = new frmDespesas(this);
            frmDespesas.TopLevel = false;
            pnlTelaPrincipal.Controls.Add(frmDespesas);
            pnlTelaPrincipal.Tag = frmDespesas;
            frmDespesas.Show();
        }

        private void pnlTelaPrincipal_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnConsultarEstoque_Click(object sender, EventArgs e)
        {
            frmConsultarEstoque frmConsultarEstoque = new frmConsultarEstoque();
            frmConsultarEstoque.ShowDialog();
        }
    }
}