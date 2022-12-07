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
    public partial class frmNovoUsuario : DevExpress.XtraEditors.XtraForm
    {
        //public ListaEstados lista = new ListaEstados();

        public frmNovoUsuario()
        {
            InitializeComponent();

            PreenchimentoComboBoxEstado();
        }

        private void PreenchimentoComboBoxEstado()
        {
            ListaEstados.PreechendoListaEstado();

            cmbEstado.Properties.DataSource = ListaEstados.listaEstados;
            cmbEstado.Properties.DisplayMember = "Sigla";
            cmbEstado.Properties.ValueMember = "NomeEstado";
        }

        private void txtBairro_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoCNPJ(e, txtCNPJ);
        }

        private void txtInscricaoEstadual_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasNumero(e, txtInscricaoEstadual);
        }

        private void txtInscricaoMunicipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasNumero(e, txtInscricaoMunicipal);
        }

        private void txtNomeFantasia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtNomeFantasia);
        }

        private void txtRazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtRazaoSocial);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoEmail(e, txtEmail);
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (Validacoes.IsCampoPreenchido(txtCNPJ) == true)
            {
                if (Validacoes.IsCnpjValido(txtCNPJ.Text) == true)
                {
                    txtCNPJ.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
                else
                {
                    MensagemAtencao.MensagemCampoDigitadoInvalido("CNPJ");

                    txtCNPJ.BackColor = Color.LightGray;

                    txtCNPJ.Focus();
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty)
            {
                if (Validacoes.IsEmailValido(txtEmail.Text) == false)
                {
                    txtEmail.BackColor = Color.LightGray;

                    MensagemAtencao.MensagemCampoDigitadoInvalido("Email");

                    txtEmail.Focus();
                }
                else
                {
                    txtEmail.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text != string.Empty)
            {
                if (Validacoes.IsCampoPreenchido(txtCelular) == false)
                {
                    txtCelular.BackColor = Color.LightGray;

                    MensagemAtencao.MensagemCampoDigitadoInvalido("Celular");

                    txtCelular.Focus();
                }
                else
                {
                    txtCelular.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
        }

        private void txtTelefoneResidencial_Leave(object sender, EventArgs e)
        {
            if (txtTelefoneResidencial.Text != string.Empty)
            {
                if (Validacoes.IsCampoPreenchido(txtTelefoneResidencial) == false)
                {
                    txtTelefoneResidencial.BackColor = Color.LightGray;

                    MensagemAtencao.MensagemCampoDigitadoInvalido("Telefone");

                    txtTelefoneResidencial.Focus();
                }
                else
                {
                    txtTelefoneResidencial.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtNumero);
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtBairro);
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, txtCidade);
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoCEP(txtCEP);
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            Validacoes.IsCampoPreenchido(txtCEP);
        }

        private void btnBuscarPorCEP_Click(object sender, EventArgs e)
        {
        }
    }
}