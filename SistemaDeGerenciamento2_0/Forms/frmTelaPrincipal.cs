using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.LookAndFeel;
using DevExpress.Office.Model;
using DevExpress.Utils.Extensions;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraVerticalGrid.Painters;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Win32;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Forms;
using SistemaDeGerenciamento2_0.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0
{
    public partial class frmTelaPrincipal : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private PermissoesUsuario permissoesCadastro = new PermissoesUsuario();

        private List<tb_permissoes> listaPermissoes = new List<tb_permissoes>();

        private PermissoesUsuario permissoesUsuario = new PermissoesUsuario();

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
            //ReloadData("Acesso Financeiro");

            //frmFinanceiro frmFinanceiro = new frmFinanceiro(this);
            //frmFinanceiro.ShowDialog();
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

        private void AcessandoTelas(string _btnSolitador)
        {
            if (_btnSolitador == "Novo Produto")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoCadastroProduto();
            }
            else if (_btnSolitador == "Cliente")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoCadastro("Cliente");
            }
            else if (_btnSolitador == "Fornecedor")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoCadastro("Fornecedor");
            }
            else if (_btnSolitador == "Funcionario")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoCadastro("Funcionario");
            }
            else if (_btnSolitador == "ConfigUsuario")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoConfigUsuario("ConfigUsuario");
            }
            else if (_btnSolitador == "ConfigEmpresa")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoConfigEmpresa("ConfigEmpresa");
            }
            else if (_btnSolitador == "ConfigFinanceiro")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoConfigFinanceira("ConfigFinanceiro");
            }
            else if (_btnSolitador == "Ir para produtos")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoTodosProdutos();
            }
            else if (_btnSolitador == "Todos Os Cadastros")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoTodosCadastros("Todos Os Cadastros");
            }
            else if (_btnSolitador == "ConfigPerfil")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoConfigPerfil("ConfigPerfil");
            }
            else if (_btnSolitador == "ConfigDespesa")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoConfigDespesa("ConfigDespesa");
            }
            else if (_btnSolitador == "Todos Os Produtos")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoTodosProdutos();
            }
            else if (_btnSolitador == "Acesso PDV")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoPDV("Acesso PDV");
            }
            else if (_btnSolitador == "Acesso Importar XML")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoFinanceiroImportarXML("Acesso Importar XML");
            }
            else if (_btnSolitador == "Acesso Despesa")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoFinanceiroDespesa("Acesso Despesa");
            }
            else if (_btnSolitador == "Acesso Categoria")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoFinanceiroCategoria("Acesso Categoria");
            }
            else if (_btnSolitador == "Faturamento Por Dia")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoRelatorioFaturamento("Faturamento Por Dia", this);
            }
            else if (_btnSolitador == "Faturamento Por Vendedor")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoRelatorioFaturamento("Faturamento Por Vendedor", this);
            }
            else if (_btnSolitador == "Indicadores de Venda")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoIndicadoresDeVenda("Indicadores de Venda", this);
            }
            else if (_btnSolitador == "Historico de Venda")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoHistoricoDeVenda("Historico de Venda", this);
            }
        }

        private void btnConfigUsuario_Click(object sender, EventArgs e)
        {
            AcessandoTelas("ConfigUsuario");
        }

        private void btnConfigEmpresa_Click(object sender, EventArgs e)
        {
            AcessandoTelas("ConfigEmpresa");
        }

        private void btnConfigPerfil_Click(object sender, EventArgs e)
        {
            AcessandoTelas("ConfigPerfil");
        }

        private void btnConfigFinanceiro_Click(object sender, EventArgs e)
        {
            AcessandoTelas("ConfigFinanceiro");
        }

        private void btnConfigDesepsa_Click(object sender, EventArgs e)
        {
            AcessandoTelas("ConfigDespesa");
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Novo Produto");
        }

        private void btnTodosOsProdutos_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Todos Os Produtos");
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Cliente");
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Fornecedor");
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Funcionario");
        }

        private void btnTodosOsCadastro_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Todos Os Cadastros");
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
        }

        private void Produtos_Click(object sender, EventArgs e)
        {
        }

        private void pnlTelaPrincipal_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnConsultarEstoque_Click(object sender, EventArgs e)
        {
            frmConsultarEstoque frmConsultarEstoque = new frmConsultarEstoque();
            frmConsultarEstoque.ShowDialog();
        }

        private void PDV_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Acesso PDV");
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Acesso Importar XML");
        }

        private void btnDespesaContas_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Acesso Despesa");
        }

        private void btnCategoriaDespesa_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Acesso Categoria");
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn == true)
            {
                UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Office2019White);
            }
            else
            {
                UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);
            }
        }

        private void Relatorios_Click(object sender, EventArgs e)
        {
            //TelaRelatorios();
        }

        private void TelaRelatorios()
        {
            pnlTelaPrincipal.Controls.Clear();
            frmRelatorios frmRelatorios = new frmRelatorios(this);
            frmRelatorios.TopLevel = false;
            pnlTelaPrincipal.Controls.Add(frmRelatorios);
            pnlTelaPrincipal.Tag = frmRelatorios;
            frmRelatorios.Show();
        }

        private void btnFaturamentoPorDia_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Faturamento Por Dia");
        }

        private void btnFaturamentoPorVendedor_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Faturamento Por Vendedor");
        }

        private void btnIndicadoresVendas_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Indicadores de Venda");
        }

        private void btnHistorioDeVenda_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Historico de Venda");

            //frmHistoricoVenda frmHistoricoVenda = new frmHistoricoVenda();
            //frmHistoricoVenda.ShowDialog();
        }

        private void VisaoGeral_Click(object sender, EventArgs e)
        {
            frmteste frmteste = new frmteste();
            frmteste.ShowDialog();
        }
    }
}