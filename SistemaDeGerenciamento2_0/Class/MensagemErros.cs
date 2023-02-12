using System;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Class
{
    internal class MensagemErros
    {
        #region Cadastrar

        #region Tela Principal

        public static void ErroAoCadastroDespesaContasFixas(Exception _e)
        {
            MessageBox.Show($"(CAD-TP01) Erro ao Cadastrar Despesa/Contas Fixas \n\nErro: {_e}", "Erro Cadastro Despesa/Conta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Tela Principal

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

        public static void ErroAoCadastroDadosEmpresa(Exception _e)
        {
            MessageBox.Show($"(CAD-RE07) Erro ao Cadastrar Dados da Empresa \n\nErro: {_e.Message}", "Erro Cadastro Dados da Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroEnderecoEmpresa(Exception _e)
        {
            MessageBox.Show($"(CAD-RE08) Erro ao Cadastrar Endereço da Empresa \n\nErro: {_e.Message}", "Erro Cadastro Endereço da Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Registro

        #region NF Entrada

        public static void ErroAoCadastroNotaFiscalEntrada(Exception _e)
        {
            MessageBox.Show($"(CAD-NFE01) Erro ao Cadastrar Nota Fiscal de Entrada\n\nErro: {_e.Message}", "Erro Cadastrar Nota Fiscal de Entrada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion NF Entrada

        #region Estoque

        public static void ErroAoCadastroEstoque(Exception _e)
        {
            MessageBox.Show($"(CAD-ES01) Erro ao Cadastrar Estoque\n\nErro: {_e.Message}", "Erro Cadastrar Estoque!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Estoque

        #region Financeiro

        public static void ErroAoCadastroFinanceiro(Exception _e)
        {
            MessageBox.Show($"(CAD-FI01) Erro ao Cadastro Financeiro \n\nErro: {_e.Message}", "Erro Cadastro Financeiro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroFinanceiroDescontoPorGrupo(Exception _e)
        {
            MessageBox.Show($"(CAD-FI02) Erro ao Cadastro Financeiro Desconto Por Grupo \n\nErro: {_e.Message}", "Erro Cadastro Financeiro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Financeiro

        #region Configuracoes

        public static void ErroAoCadastroPermissoes(Exception _e)
        {
            MessageBox.Show($"(CAD-CO01) Erro ao Cadastrar Permissões do Usuário\n\nErro: {_e.Message}", "Erro Cadastrar Permissões!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroUsuario(Exception _e)
        {
            MessageBox.Show($"(CAD-CO02) Erro ao Cadastrar Usuário\n\nErro: {_e.Message}", "Erro Cadastrar Usuário!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Configuracoes

        #region Despesa

        public static void ErroAoCadastroDespesa(Exception _e)
        {
            MessageBox.Show($"(CAD-DE01) Erro ao Cadastrar Despesa\n\nErro: {_e.Message}", "Erro Cadastrar Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Despesa

        #region Despesas

        public static void ErroAoCadastroDespesas(Exception _e)
        {
            MessageBox.Show($"(CAD-DE01) Erro ao Cadastrar Despesa \n\nErro: {_e.Message}", "Erro Cadastrar Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroDespesasRepeticao(Exception _e)
        {
            MessageBox.Show($"(CAD-DE02) Erro ao Cadastrar Despesa Repetição \n\nErro: {_e.Message}", "Erro Cadastrar Despesa Repetição!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Despesas

        #endregion Cadastrar

        #region Buscar

        #region Tela Principal

        public static void ErroAoBuscarProdutosComEstoqueBaixo(Exception _e)
        {
            MessageBox.Show($"(BUS-TP01) Erro ao Buscar Produtos Com Estoque Baixo \n\nErro: {_e}", "Erro Buscar Produto Estoque Baixo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarContasAtrasadas(Exception _e)
        {
            MessageBox.Show($"(BUS-TP02) Erro ao Buscar Contas Atrasadas \n\nErro: {_e}", "Erro Buscar Produto Estoque Baixo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarDespesaContasComRepeticaoAtrasadas(Exception _e)
        {
            MessageBox.Show($"(BUS-TP03) Erro ao Buscar Despesa/Contas Com Repetição \n\nErro: {_e}", "Erro Buscar Despesa/Conta Com Repetição!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Tela Principal

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
            MessageBox.Show($"(BUS-PR03) Erro ao Buscar Codigo de Barras Produto \n\nErro: {_e}", "Erro Buscar Codigo de Barras Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarDadosEmpresa(Exception _e)
        {
            MessageBox.Show($"(BUS-PR04) Erro ao Buscar Dados da Empresa \n\nErro: {_e}", "Erro Buscar Dados da Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarEndereco(Exception _e)
        {
            MessageBox.Show($"(BUS-PR05) Erro ao Buscar Endereço da Empresa \n\nErro: {_e}", "Erro Buscar Endereço da Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarValorDoProduto(Exception _e)
        {
            MessageBox.Show($"(BUS-PR06) Erro ao Buscar Valor do Produto \n\nErro: {_e}", "Erro Buscar Valor do Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarCodigoDoProdutoEDescricao(Exception _e)
        {
            MessageBox.Show($"(BUS-PR07) Erro ao Buscar Código do Produto e Descrição \n\nErro: {_e}", "Erro Buscar Código do Produto e Descrição!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarDadosProduto(Exception _e)
        {
            MessageBox.Show($"(BUS-PR08) Erro ao Buscar Dados Cadastro de Produto \n\nErro: {_e}", "Erro Buscar Dados Cadastro de Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static void ErroAoBuscarCNPJDaEmpresaTelaNFEmpresa(Exception _e)
        {
            MessageBox.Show($"(BUS-RE03) Erro ao Buscar CNPJ da Empresa Tela de Nota Fiscal de Saida \n\nErro: {_e}", "Erro Buscar CNPJ da Empresa Nota Fiscal de Saida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarDadosUsuario(Exception _e)
        {
            MessageBox.Show($"(BUS-RE04) Erro ao Buscar Dados Usuário \n\nErro: {_e}", "Erro Buscar Dados Usuário!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarDadosRegistroPessoaJuridica(Exception _e)
        {
            MessageBox.Show($"(BUS-RE05) Erro ao Buscar Dados Registro Pessoa Juridica \n\nErro: {_e}", "Erro Buscar Dados Registro Pessoa Juridica!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarDadosRegistroPessoaFisica(Exception _e)
        {
            MessageBox.Show($"(BUS-RE06) Erro ao Buscar Dados Registro Pessoa Fisica \n\nErro: {_e}", "Erro Buscar Dados Registro Pessoa Fisica!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Registro

        #region Financeiro

        public static void ErroAoBuscarCNPJParaVerificacaSeExisteCadastro(Exception _e)
        {
            MessageBox.Show($"(BUS-FI01) Erro ao Buscar CNPJ para verificação de existencia de cadastro \n\nErro: {_e}", "Erro Buscar CNPJ para verificação de existencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarExistenciaConfiguracaoFinanceiras(Exception _e)
        {
            MessageBox.Show($"(BUS-FI02) Erro ao Buscar Existencia de Configurações financeiras \n\nErro: {_e}", "Erro Buscar Existencia de Configurações financeiras!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarDadosConfiguracaoFinanceiras(Exception _e)
        {
            MessageBox.Show($"(BUS-FI03) Erro ao Buscar Dados Configurações financeiras \n\nErro: {_e}", "Erro Buscar Dados Configurações financeiras!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarValorTotal(Exception _e)
        {
            MessageBox.Show($"(BUS-FI04) Erro ao Buscar Total Aguardando \n\nErro: {_e}", "Erro Buscar Total Aguardando!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarValorAguardandoPagamento(Exception _e)
        {
            MessageBox.Show($"(BUS-FI05) Erro ao Buscar Total Aguardando Pagamento \n\nErro: {_e}", "Erro Buscar Total Aguardando Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarValorPagamentoRealizado(Exception _e)
        {
            MessageBox.Show($"(BUS-FI06) Erro ao Buscar Total Pagamento Realizado \n\nErro: {_e}", "Erro Buscar Total Pagamento Realizado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarValorPagamentoAtrasado(Exception _e)
        {
            MessageBox.Show($"(BUS-FI07) Erro ao Buscar Total Pagamento Atrasado \n\nErro: {_e}", "Erro Buscar Total Pagamento Atrasado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Financeiro

        #region NF Entrada

        public static void ErroAoBuscarNFEntradaExistente(Exception _e)
        {
            MessageBox.Show($"(BUS-NFE01) Erro ao Bucar Nota Fiscal de Entrada para verificar existencia \n\nErro: {_e}", "Erro Buscar Nota Fiscal de Entrada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion NF Entrada

        #region Despesa

        public static void ErroAoBuscarDadosDespesa(Exception _e)
        {
            MessageBox.Show($"(BUS-DE01) Erro ao Bucar Dados Despesa \n\nErro: {_e}", "Erro Buscar Dados Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarTipoCustoDespesa(Exception _e)
        {
            MessageBox.Show($"(BUS-DE02) Erro ao Bucar Tipo de Custo de Despesa \n\nErro: {_e}", "Erro Buscar Tipo Custo Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Despesa

        #region Configuracoes

        public static void ErroAoBuscarDadosNovoUsuario(Exception _e)
        {
            MessageBox.Show($"(BUS-CO01) Erro ao Bucar Usuário e Senha para preencher dados da tela de cadastrar novo usuário \n\nErro: {_e}", "Erro Buscar Usuário!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarPermissoesUsuario(Exception _e)
        {
            MessageBox.Show($"(BUS-CO02) Erro ao Bucar Permissões do Usuário Para Preenhcer CheckBox \n\nErro: {_e}", "Erro Buscar Permissões!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarListaFuncionarios(Exception _e)
        {
            MessageBox.Show($"(BUS-CO03) Erro ao Bucar Lista Funcionarios Cadastrado \n\nErro: {_e}", "Erro Buscar  Funcionarios!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Configuracoes

        #region Login

        public static void ErroAoBuscarUsuarioSenha(Exception _e)
        {
            MessageBox.Show($"(BUS-LO01) Erro ao Bucar Usuário e Senha \n\nErro: {_e}", "Erro Buscar Usuário/Senha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarUsuarioSenhaAcessoRestrito(Exception _e)
        {
            MessageBox.Show($"(BUS-LO02) Erro ao Bucar Usuário e Senha Para Acesso Restrito \n\nErro: {_e}", "Erro Buscar Usuário/Senha Acesso Restrito!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Login

        #region Permissoes

        public static void ErroAoBuscarPermissoes(Exception _e)
        {
            MessageBox.Show($"(BUS-PE01) Erro ao Bucar Permissões Usuário \n\nErro: {_e}", "Erro Buscar Permissões Usuário!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarPermissoesAcessoRestrito(Exception _e)
        {
            MessageBox.Show($"(BUS-PE02) Erro ao Bucar Permissões Usuário Para Acesso Restrito \n\nErro: {_e}", "Erro Buscar Permissões Usuário Acesso Restrito!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarPermissoesTelaTodosCadastro(Exception _e)
        {
            MessageBox.Show($"(BUS-PE03) Erro ao Bucar Permissões Usuário Tela Todos Cadastro \n\nErro: {_e}", "Erro Buscar Permissões Usuário Tela Todos Cadastros!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarPermissoesTelaAcessoRapido(Exception _e)
        {
            MessageBox.Show($"(BUS-PE04) Erro ao Bucar Permissões Usuário Tela de Acesso Rapido \n\nErro: {_e}", "Erro Buscar Permissões Usuário Tela de Acesso Rapido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Permissoes

        #region PDV

        public static void ErroAoBuscarGrupoDesconto(Exception _e)
        {
            MessageBox.Show($"(BUS-PDV01) Erro ao Buscar Grupo com Desconto \n\nErro: {_e}", "Erro Buscar Grupo com Desconto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarTodosOsProdutos(Exception _e)
        {
            MessageBox.Show($"(BUS-PDV02) Erro ao Buscar Todos os Produtos \n\nErro: {_e}", "Erro Buscar Todos os Produtos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarProdutoPorCodigoDeBarras(Exception _e)
        {
            MessageBox.Show($"(BUS-PDV03) Erro ao Buscar Produto por Codigo de Barras \n\nErro: {_e}", "Erro Buscar Produto por Codigo de Barras!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarUltimaNFSaida(Exception _e)
        {
            MessageBox.Show($"(BUS-PDV04) Erro ao Buscar Numero da Ultima NF de Saida \n\nErro: {_e}", "Erro Buscar Ultima NF de Saida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion PDV

        #region Pagamento

        public static void ErroAoBuscarDadosConfiguracoesFinanceirasTelaPagamento(Exception _e)
        {
            MessageBox.Show($"(BUS-PG01) Erro ao Buscar Dados Configurações Financeiras Tela de Pagamento \n\nErro: {_e}", "Erro Buscar Dados Configurações Financeiras!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarDadosConfiguracoesFinanceirasTelaPagamentoCredito(Exception _e)
        {
            MessageBox.Show($"(BUS-PG02) Erro ao Buscar Dados Configurações Financeiras Tela de Pagamento Credito \n\nErro: {_e}", "Erro Buscar Dados Configurações Financeiras!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarCNPJDaEmpresaTelaPagamentoPix(Exception _e)
        {
            MessageBox.Show($"(BUS-PG03) Erro ao Buscar CNPJ da empresa Tela de Pagamento Pix \n\nErro: {_e}", "Erro Buscar CNPJ da empresa Tela de Pagamento Pix!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Pagamento

        #region Relatorios

        public static void ErroAoBuscarDadosFaturamentoPorDia(Exception _e)
        {
            MessageBox.Show($"(BUS-FD01) Erro ao Buscar Dados do Faturamento por dia \n\nErro: {_e}", "Erro Buscar Dados do Faturamento por dia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarDadosFaturamentoPorVendedor(Exception _e)
        {
            MessageBox.Show($"(BUS-FD02) Erro ao Buscar Dados do Faturamento por vendedor \n\nErro: {_e}", "Erro Buscar Dados do Faturamento por vendedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarHistoricoDeVenda(Exception _e)
        {
            MessageBox.Show($"(BUS-FD03) Erro ao Buscar Historico de Vendas \n\nErro: {_e}", "Erro Buscar Historico de Vendas!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarQuantidadeProdutosVendidos(Exception _e)
        {
            MessageBox.Show($"(BUS-FD04) Erro ao Buscar Quantidade de Produtos Vendidos Indicador de Venda \n\nErro: {_e}", "Erro Buscar Quantidade Produtos Vendidos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarValoresProdutosVendidos(Exception _e)
        {
            MessageBox.Show($"(BUS-FD05) Erro ao Buscar Valores de Produtos Vendidos Indicador de Venda \n\nErro: {_e}", "Erro Buscar Valores Produtos Vendidos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Relatorios

        #region Visao Geral

        public static void ErroAoBuscarValoresDespesaAnual(Exception _e)
        {
            MessageBox.Show($"(BUS-VG01) Erro ao Buscar Valores de Despesa Anual \n\nErro: {_e}", "Erro Buscar Valores Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarValoresNFSaidaAnual(Exception _e)
        {
            MessageBox.Show($"(BUS-VG02) Erro ao Buscar Valores Nota Fiscal Saida Anual \n\nErro: {_e}", "Erro Buscar Valores Nota Fiscal Saida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarValoresDespesaSemanal(Exception _e)
        {
            MessageBox.Show($"(BUS-VG03) Erro ao Buscar Valores de Despesa Semanal \n\nErro: {_e}", "Erro Buscar Valores Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarValoresNFSaidaSemanal(Exception _e)
        {
            MessageBox.Show($"(BUS-VG04) Erro ao Buscar Valores Nota Fiscal Saida Semanal \n\nErro: {_e}", "Erro Buscar Valores Nota Fiscal Saida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Visao Geral

        #endregion Buscar

        #region Atualizar

        #region Tela Principal

        public static void ErroAoAtualizarDespesaContasFixas(Exception _e)
        {
            MessageBox.Show($"(ATU-TP01) Erro ao Atualizar Despesa/Conta Fixas \n\nErro: {_e}", "Erro Atualizar Despesa/Conta Fixas!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Tela Principal

        #region Produto

        public static void ErroAoAtualizarCodigoDeBarrasProduto(Exception _e)
        {
            MessageBox.Show($"(ATU-AT01) Erro ao Atualizar Codigo de Barras do Produto \n\nErro: {_e}", "Erro Atualizar Codigo de Barras Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoAtualizarDadosProduto(Exception _e)
        {
            MessageBox.Show($"(ATU-AT02) Erro ao Atualizar Dados do Produto \n\nErro: {_e}", "Erro Atualizar Dados do Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Produto

        #region Registro

        public static void ErroAoAtualizarEnderecoEmpresa(Exception _e)
        {
            MessageBox.Show($"(ATU-RG01) Erro ao Atualizar Endereço da Empresa \n\nErro: {_e}", "Erro Atualizar Endereço da Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoAtualizarDadosEmpresa(Exception _e)
        {
            MessageBox.Show($"(ATU-RG02) Erro ao Atualizar Dados da Empresa \n\nErro: {_e}", "Erro Atualizar Dados da Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoAtualizarSenhaUsuario(Exception _e)
        {
            MessageBox.Show($"(ATU-RG03) Erro ao Atualizar Senha Usuario \n\nErro: {_e}", "Erro Atualizar Senha Usuário!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoAtualizarCadastroPessoaJuridica(Exception _e)
        {
            MessageBox.Show($"(ATU-RG04) Erro ao Atualizar Cadastro Pessoa Juridica \n\nErro: {_e}", "Erro Atualizar Cadastro Pessoa Juridica!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Registro

        #region Financeiro

        public static void ErroAoAtualizarDadosFinanceiros(Exception _e)
        {
            MessageBox.Show($"(ATU-FI01) Erro ao Atualizar Dados Financeiros \n\nErro: {_e}", "Erro Atualizar Dados Financieros!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoAtualizarParaApagarDespesaContas(Exception _e)
        {
            MessageBox.Show($"(ATU-FI02) Erro ao Atualizar para apagar Despesas/Contas \n\nErro: {_e}", "Erro Atualizar Despesa/Contas!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Financeiro

        #region Configuracoes

        public static void ErroAoAtualizarPermissoesUsuario(Exception _e)
        {
            MessageBox.Show($"(ATU-CO01) Erro ao Atualizar Permissões do Usuário\n\nErro: {_e}", "Erro Atualizar Permissões!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Configuracoes

        #region Despesa

        public static void ErroAoAtualizarDespesa(Exception _e)
        {
            MessageBox.Show($"(ATU-DE01) Erro ao Atualizar Despesa \n\nErro: {_e}", "Erro Atualizar Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Despesa

        #region Estoque

        public static void ErroAoAtualizarEstoqueDepoisDeVenda(Exception _e)
        {
            MessageBox.Show($"(ATU-ES01) Erro ao Atualizar Estoque Apos Venda \n\nErro: {_e}", "Erro Atualizar Estoque!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Estoque

        #region Pagamento

        public static void ErroAoAtualizarPagamentoDespesa(Exception _e)
        {
            MessageBox.Show($"(ATU-PA01) Erro ao Atualizar Pagamento Despesa \n\nErro: {_e}", "Erro Atualizar Pagamento Despesa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Pagamento

        #endregion Atualizar

        #region Deletar

        #region Configurações Financeiras

        public static void ErroAoDeletarGrupoComDesconto(Exception _e)
        {
            MessageBox.Show($"(DEL-FI01) Erro ao Deletar Grupo com Desconto \n\nErro: {_e}", "Erro Deletar Grupo com Desconto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Configurações Financeiras

        #region Cadastro

        public static void ErroAoDeletarCadastro(Exception _e)
        {
            MessageBox.Show($"(DEL-CA01) Erro ao Deletar Cadastro \n\nErro: {_e}", "Erro Deletar Cadastro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastro

        #region Produto

        public static void ErroAoDeletarCadastroProduto(Exception _e)
        {
            MessageBox.Show($"(DEL-PD01) Erro ao Deletar Cadastro do Produto \n\nErro: {_e}", "Erro Deletar Cadastro do Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Produto

        #endregion Deletar

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