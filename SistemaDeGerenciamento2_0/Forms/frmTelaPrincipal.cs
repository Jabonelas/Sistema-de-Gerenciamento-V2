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
        private List<tb_permissoes> listaPermissoes = new List<tb_permissoes>();

        private frmLogin frmLogin = new frmLogin();

        public frmTelaPrincipal()
        {
            InitializeComponent();

            TelaAcessoRapido();
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

        private void ReloadData()
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

                    //acessosUsuario.ForEach(x => listaPermissoes.Add(x.Permissao));

                    foreach (var item in acessosUsuario)
                    {
                        listaPermissoes.Add(item.Permissao);
                    }

                    int s = 0;
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
            frmCadastroProduto frmCadastroProduto = new frmCadastroProduto();
            frmCadastroProduto.ShowDialog();
        }

        private void btnTodosOsProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos frmProdutos = new frmProdutos();
            frmProdutos.ShowDialog();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            ReloadData();

            VerificarAcessoCadastro("Cliente");

            //frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Cliente", this);
            //frmCadastroRegistros.ShowDialog();
        }

        private void VerificarAcessoCadastro(string _Cadastro)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoes.ForEach(x => IsUsuarioPossuiAcesso = x.pm_efetuar_cadastro);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmCadastro frmCadastro = new frmCadastro(this);
                frmCadastro.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(this, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            ReloadData();

            VerificarAcessoCadastro("Fornecedor");

            //frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Fornecedor", this);
            //frmCadastroRegistros.ShowDialog();
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            ReloadData();

            VerificarAcessoCadastro("Funcionario");

            //frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Funcionario", this);
            //frmCadastroRegistros.ShowDialog();
        }

        private void btnTodosOsCadastro_Click(object sender, EventArgs e)
        {
            ReloadData();

            VerificarAcessoCadastro("Todos Os Cadastros");

            //frmCadastro frmCadastro = new frmCadastro(this);
            //frmCadastro.ShowDialog();
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
    }
}