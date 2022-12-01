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
        public frmCadastroRegistros()
        {
            InitializeComponent();

            cmbTipoPessoa.Text = "Pessoa Fisica";
        }

        private void cmbTipoPessoa_SelectedValueChanged(object sender, EventArgs e)
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
            frmCadastroRegistroPessoaFisica frm = new frmCadastroRegistroPessoaFisica();
            frm.TopLevel = false;
            pnlCadastroRegistro.Controls.Add(frm);
            pnlCadastroRegistro.Tag = frm;
            frm.Show();
        }

        private void TelaAcessoCadastroPessoaJuridica()
        {
            pnlCadastroRegistro.Controls.Clear();
            frmCadastroRegistroPessoaJuridica frm = new frmCadastroRegistroPessoaJuridica();
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
    }
}