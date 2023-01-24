using Microsoft.Win32;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
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
        private string CPFouCNPJCadastrado = string.Empty;

        private bool IsAlteracaoCadastro = false;

        private Form telaRegistro = null;

        private frmLogin frmLogin;

        private ApiCorreios Api = new ApiCorreios();

        public frmCadastroRegistroPessoaJuridica(string _tipoCadastro, Form _telaRegistro)
        {
            InitializeComponent();

            telaRegistro = _telaRegistro;

            tipoCadastro = _tipoCadastro;

            SetandoDados();
        }

        public frmCadastroRegistroPessoaJuridica(string _tipoCadastro, Form _telaRegistro, string _CPFouCNPJCadastrado)
        {
            InitializeComponent();

            telaRegistro = _telaRegistro;

            tipoCadastro = _tipoCadastro;

            CPFouCNPJCadastrado = _CPFouCNPJCadastrado;

            ExibirDadosCadastro();

            IsAlteracaoCadastro = true;
        }

        private void AlterarDadosCadastro()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadosCadastroParaAlterar = (from registro in db.tb_registro
                                                    join endereco in db.tb_enderecos
                                                    on registro.fk_endereco equals endereco.id_endereco
                                                    join informacoes in db.tb_informacoes_comerciais
                                                    on registro.fk_informacao_comercial equals informacoes.id_informacao_comercial
                                                    where registro.rg_cnpj == CPFouCNPJCadastrado
                                                    select new
                                                    {
                                                        Registro = registro,
                                                        Endereco = endereco,
                                                        Informacoes = informacoes
                                                    }).ToList();

                    foreach (var item in dadosCadastroParaAlterar)
                    {
                        //Registro
                        item.Registro.rg_cnpj = txtCNPJ.Text;
                        item.Registro.rg_data_cadastro = Convert.ToDateTime(txtDataCadastro.Text);
                        item.Registro.rg_nome_fantasia = txtNomeFantasia.Text;
                        item.Registro.rg_razao_social = txtRazaoSocial.Text;
                        item.Registro.rg_email_xml = txtEmailXML.Text;
                        item.Registro.rg_inscricao_estadual = txtInscricaoEstadual.Text;
                        item.Registro.rg_inscricao_municipal = txtInscricaoMunicipal.Text;
                        item.Registro.rg_email = txtEmail.Text;
                        item.Registro.rg_celular = txtCelular.Text;
                        item.Registro.rg_telefone_fixo = txtTelefoneFixo.Text;
                        item.Registro.rg_observacoes = txtObservacoes.Text;
                        //Endereço
                        item.Endereco.ed_tipo = cmbTipoEndereco.Text;
                        item.Endereco.ed_cep = txtCEP.Text;
                        item.Endereco.ed_estado = cmbEstado.Text;
                        item.Endereco.ed_cidade = txtCidade.Text;
                        item.Endereco.ed_bairro = txtBairro.Text;
                        item.Endereco.ed_locgradouro = txtLogradouro.Text;
                        item.Endereco.ed_numero = txtNumero.Text;
                        item.Endereco.ed_complemento = txtComplemento.Text;
                        //Informações Comerciais
                        item.Informacoes.ic_prioridade = cmbPrioridade.Text;
                        item.Informacoes.ic_situacao = cmbSituacao.Text;
                        item.Informacoes.ic_limite_credito = Convert.ToDecimal(txtLimiteCredito.Text.Replace("R$", ""));
                    }

                    db.SaveChanges();

                    AlertaConfirmacao.ChamandoAlertaSucessoNoCantoInferiorDireito(AlertaSalvar, this);
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Alterar Dados Registro Pessoa Juridica | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoAtualizarCadastroPessoaJuridica(x);
            }
        }

        private void ExibirDadosCadastro()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadosCadastro = (from registro in db.tb_registro
                                         join endereco in db.tb_enderecos
                                         on registro.fk_endereco equals endereco.id_endereco
                                         join informacoes in db.tb_informacoes_comerciais
                                         on registro.fk_informacao_comercial equals informacoes.id_informacao_comercial
                                         where registro.rg_cnpj == CPFouCNPJCadastrado
                                         select new
                                         {
                                             Registro = registro,
                                             Endereco = endereco,
                                             Informacoes = informacoes
                                         }).ToList();

                    foreach (var item in dadosCadastro)
                    {
                        //Registro
                        txtCNPJ.Text = item.Registro.rg_cnpj;
                        txtDataCadastro.Text = item.Registro.rg_data_cadastro.ToShortDateString();
                        txtNomeFantasia.Text = item.Registro.rg_nome_fantasia;
                        txtRazaoSocial.Text = item.Registro.rg_razao_social;
                        txtEmailXML.Text = item.Registro.rg_email_xml;
                        txtInscricaoEstadual.Text = item.Registro.rg_inscricao_estadual;
                        txtInscricaoMunicipal.Text = item.Registro.rg_inscricao_municipal;
                        txtEmail.Text = item.Registro.rg_email;
                        txtCelular.Text = item.Registro.rg_celular;
                        txtTelefoneFixo.Text = item.Registro.rg_telefone_fixo;
                        txtObservacoes.Text = item.Registro.rg_observacoes;
                        //Endereço
                        cmbTipoEndereco.Text = item.Endereco.ed_tipo;
                        txtCEP.Text = item.Endereco.ed_cep;
                        cmbEstado.Text = item.Endereco.ed_estado;
                        txtCidade.Text = item.Endereco.ed_cidade;
                        txtBairro.Text = item.Endereco.ed_bairro;
                        txtLogradouro.Text = item.Endereco.ed_locgradouro;
                        txtNumero.Text = item.Endereco.ed_numero;
                        txtComplemento.Text = item.Endereco.ed_complemento;
                        //Informações Comerciais
                        cmbPrioridade.Text = item.Informacoes.ic_prioridade;
                        cmbSituacao.Text = item.Informacoes.ic_situacao;
                        txtLimiteCredito.Text = item.Informacoes.ic_limite_credito.ToString();
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Dados Registro Pessoa Juridica | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarDadosRegistroPessoaJuridica(x);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsAlteracaoCadastro == false)
            {
                SalvarCadastro();
            }
            else
            {
                AlterarDadosCadastro();
            }
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
                    if (Validacoes.IsCnpjValido(txtCNPJ.Text) == false)
                    {
                        MensagemAtencao.MensagemCampoDigitadoInvalido("CNPJ");

                        ModificacoesTextBox(txtCNPJ);
                    }
                    else
                    {
                        txtCNPJ.BackColor = Color.FromArgb(0, 255, 255, 255);
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
            if (txtEmailXML.Text != string.Empty)
            {
                if (Validacoes.IsEmailValido(txtEmailXML.Text) == false)
                {
                    MensagemAtencao.MensagemCampoDigitadoInvalido("Email");

                    ModificacoesTextBox(txtEmailXML);
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
                    MensagemAtencao.MensagemCampoDigitadoInvalido("Email");

                    ModificacoesTextBox(txtEmail);
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
            ManipulacaoTextBox.DigitarApenasNumero(e, txtNumero);
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
                    MensagemAtencao.MensagemCampoDigitadoInvalido("Celular");

                    ModificacoesTextBox(txtCelular);
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
                    MensagemAtencao.MensagemCampoDigitadoInvalido("Telefone");

                    ModificacoesTextBox(txtTelefoneFixo);
                }
                else
                {
                    txtTelefoneFixo.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
        }

        private void ModificacoesTextBox(DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.BackColor = Color.LightGray;

            _textBox.Text = string.Empty;

            _textBox.Focus();
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
                SalvarCadastro();
            }
        }

        private void SetandoDados()
        {
            txtDataCadastro.Text = DateTime.Now.ToString();

            PreenchimentoComboBoxEstado();
        }

        private void PreenchimentoComboBoxEstado()
        {
            Estados.PreechendoListaEstado();

            cmbEstado.Properties.DataSource = Estados.listaEstados;
            cmbEstado.Properties.DisplayMember = "Sigla";
            cmbEstado.Properties.ValueMember = "NomeEstado";
        }

        private void SalvarCadastro()
        {
            if (IsCampoEnderecoPreenchido() == true && IsCampoBasicoPreenchido() == true)
            {
                if (IsCNPJJaExistente() == false)
                {
                    SalvarInformacoesComerciais();

                    SalvarEndereco();

                    SalvarRegisto();

                    AlertaConfirmacao.ChamandoAlertaSucessoNoCantoInferiorDireito(AlertaSalvar, this);

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
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    string usuarioLogado = frmLogin.UsuarioLogado;

                    var informacaoComercialPessoaFisica = new tb_informacoes_comerciais()
                    {
                        ic_limite_credito = Convert.ToDecimal(txtLimiteCredito.Text.Replace("R$ ", "")),
                        ic_prioridade = cmbPrioridade.Text,
                        ic_situacao = cmbSituacao.Text,
                        ic_vendedor = usuarioLogado
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

        private bool IsCNPJJaExistente()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
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
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
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
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var pessoaFisica = new tb_registro()
                    {
                        rg_tipo_cadastro = tipoCadastro,
                        rg_data_cadastro = Convert.ToDateTime(txtDataCadastro.Text),
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