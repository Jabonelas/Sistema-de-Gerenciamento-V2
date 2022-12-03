using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
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
        private ApiCorreios Api = new ApiCorreios();

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

        private void txtRG_Leave(object sender, EventArgs e)
        {
            if (Validacoes.IsPreencimentoCompleto(txtRG) == true)
            {
                if (Validacoes.IsRGValido(txtRG.Text) == false)
                {
                    MensagemAtencao.MensagemRGDigitadoInvalido();

                    txtRG.BackColor = Color.LightGray;

                    txtRG.Focus();
                }
                else
                {
                    txtRG.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Validacoes.IsEmailValido(txtEmail.Text) == false)
            {
                MensagemAtencao.MensagemEmailDigitadoInvalido();

                txtEmail.BackColor = Color.LightGray;

                txtEmail.Focus();
            }
            else
            {
                txtEmail.BackColor = Color.FromArgb(0, 255, 255, 255);
            }
        }

        private void btnBuscarPorCEP_Click(object sender, EventArgs e)
        {
            PreenchimentoPorCEP(txtCEP);
        }

        private int qntCEPexecutado = 0;

        private void PreenchimentoPorCEP(DevExpress.XtraEditors.TextEdit _txtCEP)
        {
            if (qntCEPexecutado == 0)
            {
                qntCEPexecutado++;

                if (txtCEP.Text != string.Empty)
                {
                    bool IsPreenchimentoCorreto;

                    IsPreenchimentoCorreto = Validacoes.IsPreencimentoCompleto(txtCEP);

                    if (IsPreenchimentoCorreto == true)
                    {
                        var tareefa = Api.APICorreios((_txtCEP.Text).Replace("-", ""));
                        var esperador = tareefa.GetAwaiter();

                        esperador.OnCompleted(() =>
                        {
                            var item = Api.RetornoApi();

                            if (item.uf != null)
                            {
                                PreenchendoCamposCEP(item);

                                //_txtCEP.BorderColorActive = Color.DodgerBlue;
                            }
                            else
                            {
                                _txtCEP.Focus();

                                MessageBox.Show("CEP Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        });
                    }
                }
                else
                {
                    //ZerandoCamposPreenchidosCEP();
                }
            }
            else
            {
                qntCEPexecutado = 0;
            }
        }

        private void PreenchendoCamposCEP(DadosCEP _item)
        {
            txtLogradouro.Text = _item.logradouro;
            txtComplemento.Text = _item.complemento;
            txtBairro.Text = _item.bairro;
            txtCidade.Text = _item.localidade;
            cmbEstado.Text = _item.uf;
        }
    }
}