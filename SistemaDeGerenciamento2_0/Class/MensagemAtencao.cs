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

        public static void MensagemPreencherCampos(Form form)
        {
            MessageBox.Show("Por Favor, Preencher Campos Obrigatorios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}