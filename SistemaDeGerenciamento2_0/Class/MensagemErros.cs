using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Class
{
    internal class MensagemErros
    {
        #region Cadastrar

        #region Produto

        public static void ErroAoCadastroProduto(Exception _e)
        {
            MessageBox.Show($"(CAD-PR01) Erro ao Cadastrar Produto \n\nErro: {_e}", "Erro Cadastro Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroCodigoDeBarrasProduto(Exception _e)
        {
            MessageBox.Show($"(CAD-PR02) Erro ao Cadastrar Codigo de Barras do Produto \n\nErro: {_e}", "Erro Cadastrar Codigo de Barras do Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Produto

        #region Grupo

        public static void ErroAoCadastroGrupo(Exception _e)
        {
            MessageBox.Show($"(CAD-GR01) Erro ao Cadastrar Grupo \n\nErro: {_e.Message}", "Erro Cadastro Grupo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroAgrupador(Exception _e)
        {
            MessageBox.Show($"(CAD-AG01) Erro ao Cadastrar Agrupador \n\nErro: {_e}", "Erro Cadastro Agrupador!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Grupo

        #region Registro

        public static void ErroAoCadastroRegistroEnderecoPessoaJuridica(Exception _e)
        {
            MessageBox.Show($"(CAD-RE01) Erro ao Cadastrar Registro - Endereço  - Pessoa Juridica \n\nErro: {_e.Message}", "Erro Cadastro Registro - Endereço  - Pessoa Juridica!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroRegistroPessoaFisica(Exception _e)
        {
            MessageBox.Show($"(CAD-RE02) Erro ao Cadastrar Registro - Pessoa Fisica \n\nErro: {_e.Message}", "Erro Cadastro Registro - Pessoa Fisica!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroRegistroInformacoesComerciaisPessoaFisica(Exception _e)
        {
            MessageBox.Show($"(CAD-RE03) Erro ao Cadastrar Registro - Informações Comerciais - Pessoa Fisica \n\nErro: {_e.Message}", "Erro Cadastro Registro - Informações Comerciais - Pessoa Fisica!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroRegistroInformacoesComerciaisPessoaJuridica(Exception _e)
        {
            MessageBox.Show($"(CAD-RE04) Erro ao Cadastrar Registro - Informações Comerciais - Pessoa Juridica \n\nErro: {_e.Message}", "Erro Cadastro Registro - Informações Comerciais - Pessoa Juridica!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroRegistroEnderecoPessoaFisica(Exception _e)
        {
            MessageBox.Show($"(CAD-RE05) Erro ao Cadastrar Registro - Endereço  - Pessoa Fisica \n\nErro: {_e.Message}", "Erro Cadastro Registro - Endereço  - Pessoa Fisica!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroRegistroPessoaJuridica(Exception _e)
        {
            MessageBox.Show($"(CAD-RE06) Erro ao Cadastrar Registro - Pessoa Juridica \n\nErro: {_e.Message}", "Erro Cadastro Registro - Pessoa Juridica!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Registro

        #endregion Cadastrar

        #region Buscar

        #region Grupo

        public static void ErroAoBuscarGrupo(Exception _e)
        {
            MessageBox.Show($"(BUS-GR01) Erro ao Buscar Grupo \n\nErro: {_e}", "Erro Buscar Grupo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarGrupoEAgrupador(Exception _e)
        {
            MessageBox.Show($"(BUS-GR02) Erro ao Buscar Grupo e Agrupador \n\nErro: {_e}", "Erro Buscar Grupo e Agrupador!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarAgrupadorTelaGrupo(Exception _e)
        {
            MessageBox.Show($"(BUS-GR03) Erro ao Buscar Agrupador na tela de Grupo \n\nErro: {_e}", "Erro Buscar Agrupador!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Grupo

        #region Agrupador

        public static void ErroAoBuscarAgrupador(Exception _e)
        {
            MessageBox.Show($"(BUS-AG01) Erro ao Buscar Agrupador \n\nErro: {_e}", "Erro Buscar Agrupador!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Agrupador

        #region Produto

        public static void ErroAoBuscarCodigoDeProduto(Exception _e)
        {
            MessageBox.Show($"(BUS-PR01) Erro ao Buscar Codigo de Produto \n\nErro: {_e}", "Erro Buscar Codigo de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarNomeDoProdutoEFornecedor(Exception _e)
        {
            MessageBox.Show($"(BUS-PR02) Erro ao Buscar Nome do Produto e Fornecedor \n\nErro: {_e}", "Erro Buscar Nome do Produto e Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarCodigoDeBarrasProduto(Exception _e)
        {
            MessageBox.Show($"(BUS-PR03) Erro ao Buscar Codigo de Barras Produto \n\nErro: {_e}", "Erro Buscar Codigo de Barras roduto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Produto

        #region Registro

        public static void ErroAoBuscarCPFParaVerificacaoExistencia(Exception _e)
        {
            MessageBox.Show($"(BUS-RE01) Erro ao Buscar CPF para verificação de existencia \n\nErro: {_e}", "Erro Buscar CPF para verificação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarCNPJParaVerificacaoExistencia(Exception _e)
        {
            MessageBox.Show($"(BUS-RE02) Erro ao Buscar CNPJ para verificação de existencia \n\nErro: {_e}", "Erro Buscar CNPJ para verificação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Registro

        #region Financeiro

        public static void ErroAoBuscarCNPJParaVerificacaSeExisteCadastro(Exception _e)
        {
            MessageBox.Show($"(BUS-FI01) Erro ao Buscar CNPJ para verificação de existencia de cadastro \n\nErro: {_e}", "Erro Buscar CNPJ para verificação de existencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Financeiro

        #endregion Buscar

        #region Atualizar

        #region Produto

        public static void ErroAoAtualizarProduto(Exception _e)
        {
            MessageBox.Show($"(CAD-AT01) Erro ao Atualizar Codigo de Barras do Produto \n\nErro: {_e}", "Erro Atuazliar Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Produto

        #endregion Atualizar

        #region Ler Arquivos

        public static void ErroAoLerDadosEmissorXml(Exception _e)
        {
            MessageBox.Show($"(LER-XML01) Erro ao Ler Dados do Emissor da Xml \n\nErro: {_e}", "Erro Leitura Xml!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoLerDadosGeralXml(Exception _e)
        {
            MessageBox.Show($"(LER-XML02) Erro ao Ler Dados Gerais da Xml \n\nErro: {_e}", "Erro Leitura Xml!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Ler Arquivos
    }
}