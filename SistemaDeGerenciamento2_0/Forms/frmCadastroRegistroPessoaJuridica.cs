﻿using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmCadastroRegistroPessoaJuridica : DevExpress.XtraEditors.XtraForm
    {
        private int FK_Endereco = 0;
        private int FK_InformacoesComerciais = 0;

        private string tipoCadastro = string.Empty;

        private ApiCorreios Api = new ApiCorreios();

        private Form telaRegistro = null;

        public frmCadastroRegistroPessoaJuridica(string _tipoCadastro, Form _telaRegistro)
        {
            InitializeComponent();

            telaRegistro = _telaRegistro;

            tipoCadastro = _tipoCadastro;

            SetandoDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnBuscarPorCEP_Click(object sender, EventArgs e)
        {
            PreenchimentoPorCEP(txtCEP);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(telaRegistro);
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoCNPJ(e, txtCNPJ);
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCNPJ.Text != string.Empty)
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

                        txtCNPJ.Text = string.Empty;

                        txtCNPJ.Focus();
                    }
                }
            }
        }

        private void txtEmailXML_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoEmail(e, txtEmail);
        }

        private void txtEmailXML_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty)
            {
                if (Validacoes.IsEmailValido(txtEmail.Text) == false)
                {
                    MensagemAtencao.MensagemCampoDigitadoInvalido("Email");

                    txtEmail.BackColor = Color.LightGray;

                    txtEmail.Text = string.Empty;

                    txtEmail.Focus();
                }
                else
                {
                    txtEmail.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoEmail(e, txtEmail);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty)
            {
                if (Validacoes.IsEmailValido(txtEmail.Text) == false)
                {
                    txtEmail.BackColor = Color.LightGray;

                    MensagemAtencao.MensagemCampoDigitadoInvalido("Email");

                    txtEmail.Text = string.Empty;

                    txtEmail.Focus();
                }
                else
                {
                    txtEmail.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoCelular(e, txtCelular);
        }

        private void txtTelefoneFixo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoCelular(e, txtTelefoneFixo);
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasNumero(e, txtCEP);

            ManipulacaoTextBox.FormatoCEP(txtCEP);
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, txtCidade);
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtBairro);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtNumero);
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            Validacoes.IsCampoPreenchido(txtCEP);
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text != string.Empty)
            {
                if (Validacoes.IsCampoPreenchido(txtCelular) == false)
                {
                    txtCelular.BackColor = Color.LightGray;

                    MensagemAtencao.MensagemCampoDigitadoInvalido("Celular");

                    txtCelular.Text = string.Empty;

                    txtCelular.Focus();
                }
                else
                {
                    txtCelular.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
        }

        private void txtTelefoneFixo_Leave(object sender, EventArgs e)
        {
            if (txtTelefoneFixo.Text != string.Empty)
            {
                if (Validacoes.IsCampoPreenchido(txtTelefoneFixo) == false)
                {
                    txtTelefoneFixo.BackColor = Color.LightGray;

                    MensagemAtencao.MensagemCampoDigitadoInvalido("Telefone");

                    txtTelefoneFixo.Text = string.Empty;

                    txtTelefoneFixo.Focus();
                }
                else
                {
                    txtTelefoneFixo.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
        }

        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoDinheiro(e, sender, txtLimiteCredito);
        }

        private void frmCadastroRegistroPessoaJuridica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MensagemAtencao.MensagemCancelar(telaRegistro);
            }
            else if (e.KeyCode == Keys.F10)
            {
                Salvar();
            }
        }

        private void SetandoDados()
        {
            lblDataCadastro.Text = DateTime.Now.ToString();

            PreenchimentoComboBoxEstado();
        }

        private void PreenchimentoComboBoxEstado()
        {
            Estados.PreechendoListaEstado();

            cmbEstado.Properties.DataSource = Estados.listaEstados;
            cmbEstado.Properties.DisplayMember = "Sigla";
            cmbEstado.Properties.ValueMember = "NomeEstado";
        }

        private void Salvar()
        {
            if (IsCampoEnderecoPreenchido() == true && IsCampoBasicoPreenchido() == true)
            {
                if (IsCNPJJaExistente() == false)
                {
                    SalvarInformacoesComerciais();

                    SalvarEndereco();

                    SalvarRegisto();

                    ChamandoAlertaSucessoNoCantoInferiorDireito();

                    LimparCampos.LimpaCampos(this.Controls);

                    txtLimiteCredito.Text = "R$ 0,00";

                    txtObservacoes.Text = string.Empty;
                }
            }
            else
            {
                MensagemAtencao.MensagemPreencherCampos();
            }
        }

        private void SalvarInformacoesComerciais()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    var informacaoComercialPessoaFisica = new tb_informacoes_comerciais()
                    {
                        ic_limite_credito = Convert.ToDecimal(txtLimiteCredito.Text.Replace("R$ ", "")),
                        ic_prioridade = cmbPrioridade.Text,
                        ic_situacao = cmbSituacao.Text,
                        ic_vendedor = "Nome Usuario que esta cadastrando"
                    };

                    db.tb_informacoes_comerciais.Add(informacaoComercialPessoaFisica);
                    db.SaveChanges();

                    FK_InformacoesComerciais = informacaoComercialPessoaFisica.id_informacao_comercial;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Registro - Informações Comerciais - Pessoa Fisica | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroRegistroInformacoesComerciaisPessoaFisica(x);
            }
        }

        private void ChamandoAlertaSucessoNoCantoInferiorDireito()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n   Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $"{msg.titulo}", msg.texto, string.Empty, msg.image, msg);
        }

        private bool IsCNPJJaExistente()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    var IsCNPJCadastrado = db.tb_registro.Where(x => x.rg_cnpj == txtCNPJ.Text).Any();

                    if (IsCNPJCadastrado == true)
                    {
                        MensagemAtencao.MensagemJaExistente("CNPJ");
                    }
                    return IsCNPJCadastrado;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar CNPJ para verifica a exitencia no cadastro - Registro Pessoa Juridica | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarCNPJParaVerificacaoExistencia(x);

                return false;
            }
        }

        private bool IsCampoBasicoPreenchido()
        {
            if (txtCNPJ.Text != string.Empty && txtNomeFantasia.Text != string.Empty && txtRazaoSocial.Text != string.Empty)
            {
                SetandoCorFundoComponentesBasico(Color.FromArgb(0, 255, 255, 255));

                return true;
            }
            else
            {
                SetandoCorFundoComponentesBasico(Color.LightGray);

                return false;
            }
        }

        private void SetandoCorFundoComponentesBasico(Color _corFundo)
        {
            txtCNPJ.BackColor = _corFundo;
            txtNomeFantasia.BackColor = _corFundo;
            txtRazaoSocial.BackColor = _corFundo;
        }

        private bool IsCampoEnderecoPreenchido()
        {
            if (cmbTipoEndereco.Text != string.Empty && cmbEstado.Text != string.Empty && txtCidade.Text != string.Empty &&
                txtBairro.Text != string.Empty && txtLogradouro.Text != string.Empty && txtNumero.Text != string.Empty)
            {
                SetandoCorFundoComponetesEndereco(Color.FromArgb(0, 255, 255, 255));

                return true;
            }
            else
            {
                SetandoCorFundoComponetesEndereco(Color.LightGray);

                return false;
            }
        }

        private void SetandoCorFundoComponetesEndereco(Color _corFundo)
        {
            cmbTipoEndereco.BackColor = _corFundo;
            txtCEP.BackColor = _corFundo;
            cmbEstado.BackColor = _corFundo;
            txtCidade.BackColor = _corFundo;
            txtBairro.BackColor = _corFundo;
            txtLogradouro.BackColor = _corFundo;
            txtNumero.BackColor = _corFundo;
        }

        private void SalvarEndereco()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    var enderecoPessoaFisica = new tb_enderecos()
                    {
                        ed_tipo = cmbTipoEndereco.Text,
                        ed_cep = txtCEP.Text,
                        ed_estado = cmbEstado.Text,
                        ed_cidade = txtCidade.Text,
                        ed_bairro = txtBairro.Text,
                        ed_locgradouro = txtLogradouro.Text,
                        ed_numero = txtNumero.Text,
                        ed_complemento = txtComplemento.Text,
                    };

                    db.tb_enderecos.Add(enderecoPessoaFisica);
                    db.SaveChanges();

                    FK_Endereco = enderecoPessoaFisica.id_endereco;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Registro - Endereço - Pessoa Juridica | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroRegistroEnderecoPessoaJuridica(x);
            }
        }

        private void SalvarRegisto()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    var pessoaFisica = new tb_registro()
                    {
                        rg_tipo_cadastro = tipoCadastro,
                        rg_data_cadastro = Convert.ToDateTime(lblDataCadastro.Text),
                        rg_categoria = "Pessoa Juridica",
                        rg_cnpj = txtCNPJ.Text,
                        rg_nome_fantasia = txtNomeFantasia.Text,
                        rg_razao_social = txtRazaoSocial.Text,
                        rg_email_xml = txtEmailXML.Text,
                        rg_inscricao_estadual = txtInscricaoEstadual.Text,
                        rg_inscricao_municipal = txtInscricaoMunicipal.Text,
                        rg_email = txtEmail.Text,
                        rg_celular = txtCelular.Text,
                        rg_telefone_fixo = txtTelefoneFixo.Text,
                        fk_endereco = FK_Endereco,
                        fk_informacao_comercial = FK_InformacoesComerciais,
                    };

                    db.tb_registro.Add(pessoaFisica);
                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Registro - Pessoa Juridica | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroRegistroPessoaJuridica(x);
            }
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
    }
}