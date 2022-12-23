using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmAcessoRapido : Form
    {
        private frmTelaPrincipal frmTelaPrincipal;

        public frmAcessoRapido(frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            this.Size = new Size(973, 447);

            frmTelaPrincipal = _frmTelaPrincipal;
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmCadastroProduto = new frmCadastroProduto();
            frmCadastroProduto.ShowDialog();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Cliente", frmTelaPrincipal);
            frmCadastroRegistros.ShowDialog();
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Fornecedor", frmTelaPrincipal);
            frmCadastroRegistros.ShowDialog();
        }

        private void btnNovoTransporte_Click(object sender, EventArgs e)
        {
            frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Funcionario", frmTelaPrincipal);
            frmCadastroRegistros.ShowDialog();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario();
            frmCadastroUsuario.ShowDialog();
        }

        private void btnDadosEmpresa_Click(object sender, EventArgs e)
        {
            frmDadosEmpresa frmDadosEmpresa = new frmDadosEmpresa(frmTelaPrincipal);
            frmDadosEmpresa.btnFechar.Visible = true;
            frmDadosEmpresa.btnSalvar.TabIndex = 0;
            frmDadosEmpresa.ShowDialog();
        }

        private void btnIrParaConfiguracoes_Click(object sender, EventArgs e)
        {
            frmConfiguracaoFinanceira frmConfiguracaoFinanceira = new frmConfiguracaoFinanceira(this);
            frmConfiguracaoFinanceira.AutoScroll = false;
            frmConfiguracaoFinanceira.btnCancelar.Visible = true;
            frmConfiguracaoFinanceira.KeyPreview = true;
            frmConfiguracaoFinanceira.btnFechar.Visible = true;
            frmConfiguracaoFinanceira.ShowDialog();
        }

        private void btnIrParaProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos frmProdutos = new frmProdutos();
            frmProdutos.ShowDialog();
        }

        private void btnIrParaCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro(frmTelaPrincipal);
            frmCadastro.ShowDialog();
        }
    }
}