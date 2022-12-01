using DevExpress.Emf;
using DevExpress.XtraEditors.ColorPick.Picker;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Class
{
    internal static class Validacoes
    {
        #region Validar Data

        public static bool IsDataValida(DevExpress.XtraEditors.TextEdit _textBox)
        {
            if (_textBox.Text.Length == _textBox.Properties.MaxLength && _textBox.Text != "----------")
            {
                DateTime time;
                if (DateTime.TryParse(_textBox.Text, out time))
                {
                    _textBox.BackColor = Color.FromArgb(0, 255, 255, 255);

                    return true;
                }
                else
                {
                    _textBox.BackColor = Color.LightGray;

                    MessageBox.Show($"Data Digitada Invalida: {_textBox.Text}", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    _textBox.Focus();

                    return false;
                }
            }
            return true;
        }

        #endregion Validar Data

        #region Validar Preenchimento Completo do TextBox

        public static bool IsPreencimentoCompleto(DevExpress.XtraEditors.TextEdit _textBox)
        {
            if (_textBox.Text.Length == _textBox.Properties.MaxLength || _textBox.Text.Length == 0)
            {
                _textBox.BackColor = Color.FromArgb(0, 255, 255, 255);

                return true;
            }
            else if (_textBox.Text.Length != _textBox.Properties.MaxLength && _textBox.Text.Length != 0)
            {
                _textBox.BackColor = Color.LightGray;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _textBox.Focus();
            }

            return false;
        }

        #endregion Validar Preenchimento Completo do TextBox

        public static bool IsCpfValido(string _cpf)
        {
            switch (_cpf)
            {
                case "000.000.000-00":
                    return false;

                case "111.111.111-11":
                    return false;

                case "222.222.222-22":
                    return false;

                case "333.333.333-33":
                    return false;

                case "444.444.444-44":
                    return false;

                case "555.555.555-55":
                    return false;

                case "666.666.666-66":
                    return false;

                case "777.777.777-77":
                    return false;

                case "888.888.888-88":
                    return false;

                case "999.999.999-99":
                    return false;
            }

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            _cpf = _cpf.Trim();
            _cpf = _cpf.Replace(".", "").Replace("-", "");
            if (_cpf.Length != 11)
                return false;
            tempCpf = _cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return _cpf.EndsWith(digito);
        }
    }
}