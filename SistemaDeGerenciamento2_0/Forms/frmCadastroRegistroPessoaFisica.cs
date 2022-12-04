using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraVerticalGrid.ViewInfo;
using SistemaDeGerenciamento2_0.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static DevExpress.XtraPrinting.Export.Pdf.PdfImageCache;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmCadastroRegistroPessoaFisica : DevExpress.XtraEditors.XtraForm
    {
        private ApiCorreios Api = new ApiCorreios();

        public frmCadastroRegistroPessoaFisica()
        {
            InitializeComponent();

            txtDataCadastro.Text = DateTime.Now.ToString();

            PreechendoListaEstado();

            PreenchimentoComboBoxGrupo();
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
            if (txtDataNascimento.Text != string.Empty)
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
            if (txtCPF.Text != string.Empty)
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

        private void txtRG_Leave(object sender, EventArgs e)
        {
            if (txtRG.Text != string.Empty)
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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty)
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
        }

        private void btnBuscarPorCEP_Click(object sender, EventArgs e)
        {
            //PreenchimentoPorCEP(txtCEP);
        }

        private class EstadoClass
        {
            public string NomeEstado { get; set; }
            public string Sigla { get; set; }
        }

        private List<EstadoClass> ListaEstados = new List<EstadoClass>();

        private void PreechendoListaEstado()
        {
            ListaEstados.Add(new EstadoClass { NomeEstado = "Acre", Sigla = "AC" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Alagoas", Sigla = "AL" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Amapá", Sigla = "AP" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Amazonas", Sigla = "AM" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Bahia", Sigla = "BA" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Ceará", Sigla = "CE" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Distrito Federal", Sigla = "DF" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Espírito Santo", Sigla = "ES" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Goiás", Sigla = "GO" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Maranhão", Sigla = "MA" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Mato Grosso", Sigla = "MT" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Mato Grosso do Sul", Sigla = "MS" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Minas Gerais", Sigla = "MG" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Pará", Sigla = "PA" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Paraíba", Sigla = "PB" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Paraná", Sigla = "PR" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Pernambuco", Sigla = "PE" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Piauí", Sigla = "PI" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Rio de Janeiro", Sigla = "RJ" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Rio Grande do Norte", Sigla = "RN" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Rio Grande do Sul", Sigla = "RS" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Rondônia", Sigla = "RO" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Roraima", Sigla = "RR" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Santa Catarina", Sigla = "SC" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "São Paulo", Sigla = "SP" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Sergipe", Sigla = "SE" });
            ListaEstados.Add(new EstadoClass { NomeEstado = "Tocantins", Sigla = "TO" });
        }

        private void PreenchimentoComboBoxGrupo()
        {
            cmbEstado.Properties.DataSource = ListaEstados;
            cmbEstado.Properties.DisplayMember = "NomeEstado";
            cmbEstado.Properties.ValueMember = "Sigla";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoCEP(txtCEP);
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            Validacoes.IsPreencimentoCompleto(txtCEP);
        }
    }
}