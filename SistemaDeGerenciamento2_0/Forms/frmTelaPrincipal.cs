using DevExpress.LookAndFeel;
using SistemaDeGerenciamento2_0.Forms;
using System;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0
{
    public partial class frmTelaPrincipal : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();

            TelaAcessoRapido();

            //UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Xmas2008Blue);
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

        private void TelaConfiguracoes(string _tela)
        {
            pnlTelaPrincipal.Controls.Clear();
            frmConfiguracoes frmConfiguracoes = new frmConfiguracoes(this, _tela);
            frmConfiguracoes.TopLevel = false;
            pnlTelaPrincipal.Controls.Add(frmConfiguracoes);
            pnlTelaPrincipal.Tag = frmConfiguracoes;
            frmConfiguracoes.Show();
        }

        private void btnConfigUsuario_Click(object sender, EventArgs e)
        {
            TelaConfiguracoes("ConfigUsuario");
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
            frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Cliente", this);
            frmCadastroRegistros.ShowDialog();
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Fornecedor", this);
            frmCadastroRegistros.ShowDialog();
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Funcionario", this);
            frmCadastroRegistros.ShowDialog();
        }

        private void btnTodosOsCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro(this);
            frmCadastro.ShowDialog();
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