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
        }

        private void TelaAcessoRapido()
        {
            pnlTelaPrincipal.Controls.Clear();
            frmPemissaoCadastro frmAcessoRapido = new frmPemissaoCadastro(this);
            frmAcessoRapido.TopLevel = false;
            pnlTelaPrincipal.Controls.Add(frmAcessoRapido);
            pnlTelaPrincipal.Tag = frmAcessoRapido;
            frmAcessoRapido.Show();
        }

        private void frmTelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Produtos_Click(object sender, EventArgs e)
        {
            frmProdutos frmProdutos = new frmProdutos(this);
            frmProdutos.ShowDialog();
        }

        private void Financeiro_Click(object sender, EventArgs e)
        {
            frmFinanceiro frmFinanceiro = new frmFinanceiro();
            frmFinanceiro.ShowDialog();
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Cliente", this);
            frmCadastroRegistros.ShowDialog();
        }

        private void btnAcessoRapido_Click_1(object sender, EventArgs e)
        {
            TelaAcessoRapido();
        }

        private void Configuracao_Click(object sender, EventArgs e)
        {
            TelaConfiguracoes();
        }

        private void TelaConfiguracoes()
        {
            pnlTelaPrincipal.Controls.Clear();
            frmConfiguracoes frmConfiguracoes = new frmConfiguracoes(this);
            frmConfiguracoes.TopLevel = false;
            pnlTelaPrincipal.Controls.Add(frmConfiguracoes);
            pnlTelaPrincipal.Tag = frmConfiguracoes;
            frmConfiguracoes.Show();
        }
    }
}