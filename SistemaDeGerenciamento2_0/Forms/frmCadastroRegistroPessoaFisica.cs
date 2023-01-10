using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static SistemaDeGerenciamento2_0.Class.Estados;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmCadastroRegistroPessoaFisica : DevExpress.XtraEditors.XtraForm
    {
        private int FK_Endereco = 0;

        private int FK_InformacoesComerciais = 0;

        private string tipoCadastro = string.Empty;

        private string CPFouCNPJCadastrado = string.Empty;

        private frmLogin frmLogin;

        private Form telaRegistro = null;

        private ApiCorreios Api = new ApiCorreios();

        public frmCadastroRegistroPessoaFisica(string _tipoCadastro, Form _telaRegistro, string _CPFouCNPJCadastrado)
        {
            InitializeComponent();

            tipoCadastro = _tipoCadastro;

            telaRegistro = _telaRegistro;

            CPFouCNPJCadastrado = _CPFouCNPJCadastrado;

            ExibirDadosCadastro();
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
                                         where registro.rg_cpf == CPFouCNPJCadastrado
                                         select new
                                         {
                                             Registro = registro,
                                             Endereco = endereco,
                                             Informacoes = informacoes
                                         }).ToList();

                    foreach (var item in dadosCadastro)
                    {
                        //Registro
                        txtCPF.Text = item.Registro.rg_cpf;
                        txtDataCadastro.Text = item.Registro.rg_data_cadastro.ToShortDateString();
                        txtRG.Text = item.Registro.rg_rg;
                        txtNome.Text = item.Registro.rg_nome;
                        cmbSexo.Text = item.Registro.rg_sexo;
                        txtDataNascimento.Text = item.Registro.rg_data_nascimento.ToString();
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
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Dados Registro Pessoa Fisica | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarDadosRegistroPessoaFisica(x);
            }
        }

        public frmCadastroRegistroPessoaFisica(string _tipoCadastro, Form _telaRegistro)
        {
            InitializeComponent();

            tipoCadastro = _tipoCadastro;

            telaRegistro = _telaRegistro;

            SetandoDados();
        }

        private bool IsAlterarCadastro = false;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsAlterarCadastro == false)
            {
                SalvarCadastro();
            }
            else
            {
                AlterarDadosCadastro();
            }
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
                                                    where registro.rg_cpf == CPFouCNPJCadastrado
                                                    select new
                                                    {
                                                        Registro = registro,
                                                        Endereco = endereco,
                                                        Informacoes = informacoes
                                                    }).ToList();

                    foreach (var item in dadosCadastroParaAlterar)
                    {
                        item.Registro.rg_cpf = txtCPF.Text;
                        item.Registro.rg_data_cadastro = Convert.ToDateTime(txtDataCadastro.Text);
                        item.Registro.rg_rg = txtRG.Text;
                        item.Registro.rg_nome = txtNome.Text;
                        item.Registro.rg_sexo = cmbSexo.Text;
                        item.Registro.rg_data_nascimento = Convert.ToDateTime(txtDataNascimento.Text);
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

                    ChamandoAlertaSucessoNoCantoInferiorDireito();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Alterar Dados Registro Pessoa Juridica | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoAtualizarCadastroPessoaJuridica(x);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(telaRegistro);
        }

        private void btnBuscarPorCEP_Click(object sender, EventArgs e)
        {
            PreenchimentoPorCEP(txtCEP);
        }

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoData(e, txtDataNascimento);
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoCPF(e, txtCPF);
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
            ManipulacaoTextBox.FormatoEmail(e, txtEmail);
        }

        private void txtDataNascimento_Leave(object sender, EventArgs e)
        {
            if (txtDataNascimento.Text != string.Empty)
            {
                if (Validacoes.IsCampoPreenchido(txtDataNascimento) == true)
                {
                    if (Validacoes.IsDataValida(txtDataNascimento) == true)
                    {
                        VerificarIdade();
                    }
                }
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoCelular(e, txtCelular);
        }

        private void txtResidencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoTelefone(e, txtTelefoneFixo);
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text != string.Empty)
            {
                if (Validacoes.IsCampoPreenchido(txtCPF) == true)
                {
                    if (Validacoes.IsCpfValido(txtCPF.Text) == false)
                    {
                        MensagemAtencao.MensagemCampoDigitadoInvalido("CPF");

                        ModificacoesTextBox(txtCPF);
                    }
                    else
                    {
                        txtCPF.BackColor = Color.FromArgb(0, 255, 255, 255);
                    }
                }
            }
        }

        private void ModificacoesTextBox(DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.BackColor = Color.LightGray;

            _textBox.Text = string.Empty;

            _textBox.Focus();
        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
            if (txtRG.Text != string.Empty)
            {
                if (Validacoes.IsCampoPreenchido(txtRG) == true)
                {
                    if (Validacoes.IsRGValido(txtRG.Text) == false)
                    {
                        MensagemAtencao.MensagemCampoDigitadoInvalido("RG");

                        ModificacoesTextBox(txtRG);
                    }
                    else
                    {
                        txtRG.BackColor = Color.FromArgb(0, 255, 255, 255);
                    }
                }
            }
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

        private void txtTelefoneResidencial_Leave(object sender, EventArgs e)
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

        private void VerificarIdade()
        {
            var dataNascimentoInformada = Convert.ToDateTime(txtDataNascimento.Text);

            if (dataNascimentoInformada.AddYears(18) > DateTime.Today)
            {
                MensagemAtencao.MensagemDataNasciemntoInvalida();

                ModificacoesTextBox(txtDataNascimento);
            }
            else
            {
                txtDataNascimento.BackColor = Color.FromArgb(0, 255, 255, 255);
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasNumero(e, txtCEP);

            ManipulacaoTextBox.FormatoCEP(txtCEP);
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            Validacoes.IsCampoPreenchido(txtCEP);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasNumero(e, txtNumero);
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, txtCidade);
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtBairro);
        }

        private void txtLimiteCredito_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoDinheiro(e, sender, txtLimiteCredito);
        }

        private void txtLimiteCredito_Leave(object sender, EventArgs e)
        {
            if (txtLimiteCredito.Text != string.Empty)
            {
                decimal valorCredito = Convert.ToDecimal(txtLimiteCredito.Text.Replace("R$ ", ""));

                if (valorCredito < 0)
                {
                    MensagemAtencao.MensagemNaoAceitoValoresNegativos();

                    txtLimiteCredito.Focus();
                }
            }
        }

        private void frmCadastroRegistroPessoaFisica_KeyDown(object sender, KeyEventArgs e)
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

            LayoutTipoCadastro(tipoCadastro);
        }

        private void ChamandoAlertaSucessoNoCantoInferiorDireito()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n   Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $"{msg.titulo}", msg.texto, string.Empty, msg.image, msg);
        }

        private void SalvarCadastro()
        {
            if (IsCampoEnderecoPreenchido() == true && IsCampoBasicoPreenchido() == true)
            {
                if (IsCPFJaCadastrado() == false)
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

        private bool IsCPFJaCadastrado()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var IsExisteCPFCadastrado = db.tb_registro.Where(x => x.rg_cpf == txtCPF.Text).Any();

                    if (IsExisteCPFCadastrado == true)
                    {
                        MensagemAtencao.MensagemJaExistente("CPF");
                    }

                    return IsExisteCPFCadastrado;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar CPF para verifica a exitencia no cadastro - Registro Pessoa Fisica | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarCPFParaVerificacaoExistencia(x);

                return false;
            }
        }

        private void LayoutTipoCadastro(string _tipoCadastro)
        {
            if (_tipoCadastro == "Fornecedor" || _tipoCadastro == "Funcionario")
            {
                cmbPrioridade.Enabled = false;
                cmbSituacao.Enabled = false;
                txtLimiteCredito.Enabled = false;
            }
            else
            {
                cmbPrioridade.Enabled = true;
                cmbSituacao.Enabled = true;
                txtLimiteCredito.Enabled = true;
            }
        }

        private void PreenchimentoComboBoxEstado()
        {
            Estados.PreechendoListaEstado();

            cmbEstado.Properties.DataSource = Estados.listaEstados;
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

        private bool IsCampoBasicoPreenchido()
        {
            if (txtCPF.Text != string.Empty && txtNome.Text != string.Empty)
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
            txtCPF.BackColor = _corFundo;
            txtNome.BackColor = _corFundo;
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
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Registro - Endereço - Pessoa Fisica | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroRegistroEnderecoPessoaFisica(x);
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
                        rg_categoria = "Pessoa Fisica",
                        rg_cpf = txtCPF.Text,
                        rg_rg = txtRG.Text,
                        rg_nome = txtNome.Text,
                        rg_sexo = cmbSexo.Text,
                        rg_data_nascimento = Convert.ToDateTime(txtDataNascimento.Text),
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
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Registro | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroRegistroPessoaFisica(x);
            }
        }
    }
}