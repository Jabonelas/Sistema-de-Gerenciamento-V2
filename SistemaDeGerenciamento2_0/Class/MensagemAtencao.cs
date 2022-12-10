using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0
{
    internal class MensagemAtencao
    {
        public static void MensagemCancelar(Form form)
        {
            DialogResult OpcaoDoUsuario = new DialogResult();
            OpcaoDoUsuario = MessageBox.Show("Realmente Deseja Cancelar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (OpcaoDoUsuario == DialogResult.Yes)
            {
                form.Close();
            }
        }

        public static void MensagemPreencherCampos()
        {
            MessageBox.Show("Por Favor, Preencher Campos Obrigatorios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MensagemProdutoJaExistente()
        {
            MessageBox.Show("Desculpe, codigo de produto ou nome de produto ja existente, por favor digite um valor diferente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MensagemCampoDigitadoInvalido(string _corpo)
        {
            MessageBox.Show($"Por Favor Digite Um {_corpo} válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MensagemDataNasciemntoInvalida()
        {
            MessageBox.Show("Desculpe, Cliente / Fornecedor menor de Idade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MensagemNaoCadastrado(string _corpo)
        {
            MessageBox.Show($"Desculpe, {_corpo} não cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MensagemJaExistente(string _corpoMensagem)
        {
            MessageBox.Show($"Desculpe, {_corpoMensagem} ja existente, por favor digite um valor diferente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MensagemNaoAceitoValoresNegativos()
        {
            MessageBox.Show("Desculpe, não é aceitos valores negativos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MensagemProdutoComValoresDivergentes()
        {
            MessageBox.Show("Desculpe, Produtos com Valores Divergentes do Cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}