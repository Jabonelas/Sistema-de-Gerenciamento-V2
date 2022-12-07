using DevExpress.XtraEditors;
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
    public partial class frmCadastroRegistros : DevExpress.XtraEditors.XtraForm
    {
        private string tipoCadastro = "Cliente";

        public frmCadastroRegistros(string _tipoCadastro)
        {
            InitializeComponent();

            cmbTipoPessoa.Text = "Pessoa Fisica";

            tipoCadastro = _tipoCadastro;

            TipoCadastro(tipoCadastro);
        }

        private void TipoCadastro(string _tipoCadastro)
        {
            if (_tipoCadastro == "Cliente")
            {
                btnCliente.Appearance.BackColor = Color.LightGray;
            }
            else if (_tipoCadastro == "Funcionario")
            {
                btnFuncionario.Appearance.BackColor = Color.LightGray;
            }
            else if (_tipoCadastro == "Fornecedor")
            {
                btnFornecedor.Appearance.BackColor = Color.LightGray;
            }
        }

        private void cmbTipoPessoa_SelectedValueChanged(object sender, EventArgs e)
        {
            TipoPessoa();
        }

        private void TipoPessoa()
        {
            if (cmbTipoPessoa.Text == "Pessoa Fisica")
            {
                TelaAcessoCadastroPessoaFisica();
            }
            else
            {
                TelaAcessoCadastroPessoaJuridica();
            }
        }

        private void TelaAcessoCadastroPessoaFisica()
        {
            pnlCadastroRegistro.Controls.Clear();
            frmCadastroRegistroPessoaFisica frm = new frmCadastroRegistroPessoaFisica(tipoCadastro, this);
            frm.TopLevel = false;
            pnlCadastroRegistro.Controls.Add(frm);
            pnlCadastroRegistro.Tag = frm;
            frm.Show();
        }

        private void TelaAcessoCadastroPessoaJuridica()
        {
            pnlCadastroRegistro.Controls.Clear();
            frmCadastroRegistroPessoaJuridica frm = new frmCadastroRegistroPessoaJuridica(tipoCadastro, this);
            frm.TopLevel = false;
            pnlCadastroRegistro.Controls.Add(frm);
            pnlCadastroRegistro.Tag = frm;
            frm.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroRegistros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            btnCliente.Appearance.BackColor = Color.LightGray;
            btnFuncionario.Appearance.BackColor = Color.Transparent;
            btnFornecedor.Appearance.BackColor = Color.Transparent;

            tipoCadastro = "Cliente";

            TipoPessoa();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            btnCliente.Appearance.BackColor = Color.Transparent;
            btnFuncionario.Appearance.BackColor = Color.Transparent;
            btnFornecedor.Appearance.BackColor = Color.LightGray;

            tipoCadastro = "Fornecedor";

            TipoPessoa();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            btnCliente.Appearance.BackColor = Color.Transparent;
            btnFuncionario.Appearance.BackColor = Color.LightGray;
            btnFornecedor.Appearance.BackColor = Color.Transparent;

            tipoCadastro = "Funcionario";

            TipoPessoa();
        }
    }
}