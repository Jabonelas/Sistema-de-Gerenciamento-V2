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

        public static void ErroAoCadastroProduto(Exception _e)
        {
            MessageBox.Show($"(CAD-PR01) Erro ao Cadastrar Produto \n\nErro: {_e}", "Erro Cadastro Produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroGrupo(Exception _e)
        {
            MessageBox.Show($"(CAD-GR01) Erro ao Cadastrar Grupo \n\nErro: {_e}", "Erro Cadastro Grupo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoCadastroAgrupador(Exception _e)
        {
            MessageBox.Show($"(CAD-AG01) Erro ao Cadastrar Agrupador \n\nErro: {_e}", "Erro Cadastro Agrupador!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastrar

        #region Buscar

        public static void ErroAoBuscarGrupo(Exception _e)
        {
            MessageBox.Show($"(BUS-GR01) Erro ao Buscar Grupo \n\nErro: {_e}", "Erro Buscar Grupo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErroAoBuscarAgrupador(Exception _e)
        {
            MessageBox.Show($"(BUS-AG01) Erro ao Buscar Agrupador \n\nErro: {_e}", "Erro Buscar Agrupador!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

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