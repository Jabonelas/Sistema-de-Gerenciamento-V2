using DevExpress.XtraEditors;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmDadosEmpresa : DevExpress.XtraEditors.XtraForm
    {
        private bool IsEmpresaJaCadastrada = false;

        private int FK_Endereco = 0;
        private int IDEndereco = 0;

        private ApiCorreios Api = new ApiCorreios();

        private List<tb_registro> listaDadosEmpresa = new List<tb_registro>();
        private List<tb_enderecos> listaEnderecoEmpresa = new List<tb_enderecos>();

        public frmDadosEmpresa()
        {
            InitializeComponent();

            var tarefa = Task.Run(async () =>
            {
                await BuscaPreencherTextBoxDadosEmpresa();
                await BuscaPreencherTextBoxEnderecoEmpresa();
            });

            var esperador = tarefa.GetAwaiter();
            esperador.OnCompleted(() =>
            {
                PreenchendoTextBoxDadosEmpresa();

                PreenchendoTextBoxEnderecoEmpresa();
            });

            PreenchimentoComboBoxEstado();
        }

        private void btnBuscarPorCEP_Click(object sender, EventArgs e)
        {
            if (txtCEP.Text != string.Empty)
            {
                PreenchimentoPorCEP(txtCEP);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool IsCampoPreenchidos = VerificandoPreenchimento();

            if (IsCampoPreenchidos == true)
            {
                if (IsEmpresaJaCadastrada == false)
                {
                    SalvarEndereco();

                    SalvarRegistro();
                }
                else
                {
                    AtualizarRegistroEmpresa();

                    AtualizarEnderecoEmrpesa();
                }

                ChamandoAlertaSucessoNoCantoInferiorDireito();
            }
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
            if (txtTelefoneFixo.Text != string.Empty)
            {
                if (Validacoes.IsCampoPreenchido(txtTelefoneFixo) == false)
                {
                    txtTelefoneFixo.BackColor = Color.LightGray;

                    MensagemAtencao.MensagemCampoDigitadoInvalido("Telefone");

                    txtTelefoneFixo.Focus();
                }
                else
                {
                    txtTelefoneFixo.BackColor = Color.FromArgb(0, 255, 255, 255);
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

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoCelular(e, txtCelular);
        }

        private void txtTelefoneFixo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoTelefone(e, txtTelefoneFixo);
        }

        private void PreenchimentoComboBoxEstado()
        {
            ListaEstados.PreechendoListaEstado();

            cmbEstado.Properties.DataSource = ListaEstados.listaEstados;
            cmbEstado.Properties.DisplayMember = "Sigla";
            cmbEstado.Properties.ValueMember = "NomeEstado";
        }

        private void PreenchimentoPorCEP(DevExpress.XtraEditors.TextEdit _txtCEP)
        {
            if (txtCEP.Text != string.Empty)
            {
                if (Validacoes.IsCampoPreenchido(txtCEP) == true)
                {
                    var tarefa = Api.APICorreios((_txtCEP.Text).Replace("-", ""));
                    var esperador = tarefa.GetAwaiter();

                    esperador.OnCompleted(() =>
                    {
                        var item = Api.RetornoApi();

                        if (item.uf != null)
                        {
                            PreenchendoCamposCEP(item);

                            txtCEP.BackColor = Color.FromArgb(0, 255, 255, 255);
                        }
                        else
                        {
                            _txtCEP.Focus();

                            txtCEP.BackColor = Color.LightGray;

                            MensagemAtencao.MensagemCampoDigitadoInvalido("CEP");
                        }
                    });
                }
            }
            else
            {
                LimparCamposPreenchidoPorCEP();
            }
        }

        private void ChamandoAlertaSucessoNoCantoInferiorDireito()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n   Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $"{msg.titulo}", msg.texto, string.Empty, msg.image, msg);
        }

        private void LimparCamposPreenchidoPorCEP()
        {
            cmbEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
        }

        private void PreenchendoCamposCEP(DadosCEP _item)
        {
            txtLogradouro.Text = _item.logradouro;
            txtComplemento.Text = _item.complemento;
            txtBairro.Text = _item.bairro;
            txtCidade.Text = _item.localidade;
            cmbEstado.Text = _item.uf;
        }

        private void AtualizarEnderecoEmrpesa()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    var enderecoEmpresa = db.tb_enderecos.Where(x => x.id_endereco.Equals(IDEndereco)).ToList();

                    foreach (var item in enderecoEmpresa)
                    {
                        item.ed_estado = cmbEstado.Text;
                        item.ed_cep = txtCEP.Text;
                        item.ed_numero = txtNumero.Text;
                        item.ed_cidade = txtCidade.Text;
                        item.ed_complemento = txtComplemento.Text;
                        item.ed_bairro = txtBairro.Text;
                        item.ed_locgradouro = txtLogradouro.Text;
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Atualizar Endereço Empresa | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoAtualizarEnderecoEmpresa(x);
            }
        }

        private void AtualizarRegistroEmpresa()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    var dadosEmpresa = db.tb_registro.Where(x => x.rg_categoria.Equals("Empresa")).ToList();

                    foreach (var item in dadosEmpresa)
                    {
                        item.rg_cnpj = txtCNPJ.Text;
                        item.rg_inscricao_estadual = txtInscricaoEstadual.Text;
                        item.rg_inscricao_municipal = txtInscricaoMunicipal.Text;
                        item.rg_nome_fantasia = txtNomeFantasia.Text;
                        item.rg_razao_social = txtRazaoSocial.Text;
                        item.rg_email = txtEmail.Text;
                        item.rg_celular = txtCelular.Text;
                        item.rg_telefone_fixo = txtTelefoneFixo.Text;
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Atualizar Dados Empresa | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoAtualizarDadosEmpresa(x);
            }
        }

        private async Task BuscaPreencherTextBoxEnderecoEmpresa()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    listaEnderecoEmpresa = db.tb_enderecos.Where(x => x.id_endereco.Equals(IDEndereco)).ToList();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Dados Empresa | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarEndereco(x);
            }
        }

        private async Task BuscaPreencherTextBoxDadosEmpresa()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    listaDadosEmpresa = db.tb_registro.Where(x => x.rg_categoria.Equals("Empresa")).ToList();

                    foreach (var item in listaDadosEmpresa)
                    {
                        IDEndereco = Convert.ToInt32(item.fk_endereco);
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Dados Empresa | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarDadosEmpresa(x);
            }
        }

        private void SalvarEndereco()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    var enderecoEmpresa = new tb_enderecos()
                    {
                        ed_tipo = "Empresa",
                        ed_cep = txtCEP.Text,
                        ed_estado = cmbEstado.Text,
                        ed_cidade = txtCidade.Text,
                        ed_bairro = txtBairro.Text,
                        ed_locgradouro = txtLogradouro.Text,
                        ed_numero = txtNumero.Text,
                        ed_complemento = txtComplemento.Text,
                    };

                    db.tb_enderecos.Add(enderecoEmpresa);

                    db.SaveChanges();

                    FK_Endereco = enderecoEmpresa.id_endereco;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Endereco Empresa | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroEnderecoEmpresa(x);
            }
        }

        private void SalvarRegistro()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    var dadosEmpresa = new tb_registro()
                    {
                        rg_tipo_cadastro = "Empresa",
                        rg_categoria = "Empresa",
                        rg_data_cadastro = DateTime.Today,
                        rg_cnpj = txtCNPJ.Text,
                        rg_inscricao_estadual = txtInscricaoEstadual.Text,
                        rg_inscricao_municipal = txtInscricaoMunicipal.Text,
                        rg_nome_fantasia = txtNomeFantasia.Text,
                        rg_razao_social = txtRazaoSocial.Text,
                        rg_email = txtEmail.Text,
                        rg_celular = txtCelular.Text,
                        rg_telefone_fixo = txtTelefoneFixo.Text,
                        fk_endereco = FK_Endereco
                    };
                    db.tb_registro.Add(dadosEmpresa);

                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Dados Empresa | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroDadosEmpresa(x);
            }
        }

        private bool VerificandoPreenchimento()
        {
            if (txtCNPJ.Text != string.Empty && txtNomeFantasia.Text != string.Empty && txtRazaoSocial.Text != string.Empty && txtEmail.Text != string.Empty
                && txtTelefoneFixo.Text != string.Empty && txtCEP.Text != string.Empty && cmbEstado.Text != string.Empty && txtCidade.Text != string.Empty &&
            txtBairro.Text != string.Empty && txtLogradouro.Text != string.Empty && txtNumero.Text != string.Empty)

            {
                SetandoCorFundoTextBox(Color.FromArgb(0, 255, 255, 255));

                return true;
            }

            SetandoCorFundoTextBox(Color.LightGray);

            MensagemAtencao.MensagemPreencherCampos();

            return false;
        }

        private void SetandoCorFundoTextBox(Color _corFundo)
        {
            txtCNPJ.BackColor = _corFundo;
            txtNomeFantasia.BackColor = _corFundo;
            txtRazaoSocial.BackColor = _corFundo;
            txtEmail.BackColor = _corFundo;
            txtTelefoneFixo.BackColor = _corFundo;

            txtCEP.BackColor = _corFundo;
            cmbEstado.BackColor = _corFundo;
            txtCidade.BackColor = _corFundo;
            txtBairro.BackColor = _corFundo;
            txtLogradouro.BackColor = _corFundo;
            txtNumero.BackColor = _corFundo;
        }

        private void PreenchendoTextBoxDadosEmpresa()
        {
            if (listaDadosEmpresa.Count > 0)
            {
                foreach (var item in listaDadosEmpresa)
                {
                    txtCNPJ.Text = item.rg_cnpj;
                    txtInscricaoEstadual.Text = item.rg_inscricao_estadual;
                    txtInscricaoMunicipal.Text = item.rg_inscricao_municipal;
                    txtNomeFantasia.Text = item.rg_nome_fantasia;
                    txtRazaoSocial.Text = item.rg_razao_social;
                    txtEmail.Text = item.rg_email;
                    txtCelular.Text = item.rg_celular;
                    txtTelefoneFixo.Text = item.rg_telefone_fixo;

                    IsEmpresaJaCadastrada = true;
                }
            }
        }

        private void PreenchendoTextBoxEnderecoEmpresa()
        {
            if (listaEnderecoEmpresa.Count > 0)
            {
                foreach (var item in listaEnderecoEmpresa)
                {
                    txtCEP.Text = item.ed_cep;
                    cmbEstado.Text = item.ed_estado;
                    txtCidade.Text = item.ed_cidade;
                    txtBairro.Text = item.ed_bairro;
                    txtLogradouro.Text = item.ed_locgradouro;
                    txtNumero.Text = item.ed_numero;
                    txtComplemento.Text = item.ed_complemento;
                }
            }
        }
    }
}