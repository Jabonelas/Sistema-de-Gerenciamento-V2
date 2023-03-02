using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmAcessoRapido : Form
    {
        private PermissoesUsuario permissoesUsuario = new PermissoesUsuario();

        private frmTelaPrincipal frmTelaPrincipal;

        private List<tb_permissoes> listaPermissoes = new List<tb_permissoes>();

        public frmAcessoRapido(frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            this.Size = new Size(973, 447);

            frmTelaPrincipal = _frmTelaPrincipal;
        }

        public void ReloadData(string _btnSolitador)
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                if (_btnSolitador == "Novo Produto")
                {
                    permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
                    permissoesUsuario.VerificarAcessoCadastroProduto();
                }
                else if (_btnSolitador == "Cliente")
                {
                    permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
                    permissoesUsuario.VerificarAcessoCadastro("Cliente");
                }
                else if (_btnSolitador == "Fornecedor")
                {
                    permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
                    permissoesUsuario.VerificarAcessoCadastro("Fornecedor");
                }
                else if (_btnSolitador == "Funcionario")
                {
                    permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
                    permissoesUsuario.VerificarAcessoCadastro("Funcionario");
                }
                else if (_btnSolitador == "ConfigUsuario")
                {
                    permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
                    permissoesUsuario.VerificarAcessoConfigUsuario("ConfigUsuario");
                }
                else if (_btnSolitador == "Config Empresa Acesso Rapido")
                {
                    permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
                    permissoesUsuario.VerificarAcessoConfigEmpresaTelaAcessoRapido("Config Empresa Acesso Rapido");
                }
                else if (_btnSolitador == "Config Financeiro Acesso Rapido")
                {
                    permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
                    permissoesUsuario.VerificarAcessoConfigFinanceiraTelaAcessoRapido("Config Financeiro Acesso Rapido");
                }
                else if (_btnSolitador == "Ir para produtos")
                {
                    permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
                    permissoesUsuario.VerificarAcessoTodosProdutos();
                }
                else if (_btnSolitador == "Todos Os Cadastros")
                {
                    permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
                    permissoesUsuario.VerificarAcessoTodosCadastros("Todos Os Cadastros");
                }
                else if (_btnSolitador == "Acesso Importar XML")
                {
                    permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
                    permissoesUsuario.VerificarAcessoFinanceiroImportarXML("Acesso Importar XML");
                }
                else if (_btnSolitador == "Acesso Despesa")
                {
                    permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
                    permissoesUsuario.VerificarAcessoFinanceiroDespesa("Acesso Despesa");
                }
                else if (_btnSolitador == "Acesso Categoria")
                {
                    permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
                    permissoesUsuario.VerificarAcessoFinanceiroCategoria("Acesso Categoria");
                }
            }
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            ReloadData("Novo Produto");
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            ReloadData("Cliente");
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            ReloadData("Fornecedor");
        }

        private void btnNovoTransporte_Click(object sender, EventArgs e)
        {
            ReloadData("Funcionario");
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            ReloadData("ConfigUsuario");
        }

        private void btnDadosEmpresa_Click(object sender, EventArgs e)
        {
            ReloadData("Config Empresa Acesso Rapido");
        }

        private void btnIrParaConfiguracoes_Click(object sender, EventArgs e)
        {
            ReloadData("Config Financeiro Acesso Rapido");
        }

        private void btnIrParaProdutos_Click(object sender, EventArgs e)
        {
            ReloadData("Ir para produtos");
        }

        private void btnIrParaCadastro_Click(object sender, EventArgs e)
        {
            ReloadData("Todos Os Cadastros");
        }

        private void btnEstoqueProduto_Click(object sender, EventArgs e)
        {
            frmConsultarEstoque frmConsultarEstoque = new frmConsultarEstoque();
            frmConsultarEstoque.ShowDialog();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ReloadData("Acesso Importar XML");
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            ReloadData("Acesso Despesa");
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            ReloadData("Acesso Categoria");
        }
    }
}