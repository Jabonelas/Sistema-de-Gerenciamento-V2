using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmPemissaoCadastro : Form
    {
        public frmPemissaoCadastro()
        {
            InitializeComponent();

            this.Size = new Size(973, 447);
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmCadastroProduto = new frmCadastroProduto();
            frmCadastroProduto.ShowDialog();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Cliente");
            frmCadastroRegistros.ShowDialog();
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Fornecedor");
            frmCadastroRegistros.ShowDialog();
        }

        private void btnNovoTransporte_Click(object sender, EventArgs e)
        {
            frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros("Funcionario");
            frmCadastroRegistros.ShowDialog();
        }
    }
}