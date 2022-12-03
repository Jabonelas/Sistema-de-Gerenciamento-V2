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

        #endregion Produto

        #endregion Buscar

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