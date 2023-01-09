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
        private PermissoesCadastro permissoesCadastro = new PermissoesCadastro();

        private frmTelaPrincipal frmTelaPrincipal;

        private List<tb_permissoes> listaPermissoes = new List<tb_permissoes>();

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
            permissoesCadastro.ReloadData(frmTelaPrincipal);
            permissoesCadastro.VerificarAcessoCadastro("Cliente");
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            permissoesCadastro.ReloadData(frmTelaPrincipal);
            permissoesCadastro.VerificarAcessoCadastro("Fornecedor");
        }

        private void btnNovoTransporte_Click(object sender, EventArgs e)
        {
            permissoesCadastro.ReloadData(frmTelaPrincipal);
            permissoesCadastro.VerificarAcessoCadastro("Funcionario");
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
            permissoesCadastro.ReloadData(frmTelaPrincipal);
            permissoesCadastro.VerificarAcessoTodosCadastro("Todos Os Cadastros");
        }
    }
}