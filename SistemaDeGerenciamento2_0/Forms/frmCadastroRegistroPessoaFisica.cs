using DevExpress.XtraEditors;
using SistemaDeGerenciamento2_0.Class;
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
    public partial class frmCadastroRegistroPessoaFisica : DevExpress.XtraEditors.XtraForm
    {
        public frmCadastroRegistroPessoaFisica()
        {
            InitializeComponent();

            txtDataCadastro.Text = DateTime.Now.ToString();
        }

        private void frmCadastroRegistroPessoaFisica_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoData(txtDataNascimento);
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoCPF(e, txtCPF);
        }

        private void txtCPF_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoRG(e, txtRG);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, txtNome);
        }

        private void cmbSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, cmbSexo);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoEmail(e);
        }

        private void txtDataNascimento_Leave(object sender, EventArgs e)
        {
            if (Validacoes.IsPreencimentoCompleto(txtDataNascimento) == true)
            {
                if (Validacoes.IsDataValida(txtDataNascimento) == false)
                {
                    return;
                }

                return;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoCelular(e, txtCelular);
        }

        private void txtResidencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoTelefone(e, txtResidencial);
        }

        private void cmbTipoEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, cmbTipoEndereco);
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (Validacoes.IsPreencimentoCompleto(txtCPF) == true)
            {
                if (Validacoes.IsCpfValido(txtCPF.Text) == false)
                {
                    MensagemAtencao.MensagemCPFDigitadoInvalido();

                    txtCPF.BackColor = Color.LightGray;

                    txtCPF.Focus();
                }
                else
                {
                    txtCPF.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
        }
    }
}