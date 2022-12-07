using DevExpress.Emf;
using DevExpress.XtraEditors.ColorPick.Picker;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static bool IsCampoPreenchido(DevExpress.XtraEditors.TextEdit _textBox)
        {
            if (_textBox.Text.Length == _textBox.Properties.MaxLength || _textBox.Text.Length == 0)
            {
                _textBox.BackColor = Color.FromArgb(0, 255, 255, 255);

                return true;
            }
            else if (_textBox.Text.Length != _textBox.Properties.MaxLength && _textBox.Text.Length != 0)
            {
                _textBox.BackColor = Color.LightGray;

                MessageBox.Show("Por Favor Preencha o Campo Completamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _textBox.Focus();
            }

            return false;
        }

        #endregion Validar Preenchimento Completo do TextBox

        #region Validar CPF

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

        #endregion Validar CPF

        #region Validar RG

        public static bool IsRGValido(string rg)
        {
            //Elimina da string os traços, pontos e virgulas,
            rg = rg.Replace("-", "").Replace(".", "").Replace(",", "");

            //Verifica se o tamanho da string é 9
            if (rg.Length == 9)
            {
                int[] n = new int[9];

                //obtém cada um dos caracteres do rg
                n[0] = Convert.ToInt32(rg.Substring(0, 1));
                n[1] = Convert.ToInt32(rg.Substring(1, 1));
                n[2] = Convert.ToInt32(rg.Substring(2, 1));
                n[3] = Convert.ToInt32(rg.Substring(3, 1));
                n[4] = Convert.ToInt32(rg.Substring(4, 1));
                n[5] = Convert.ToInt32(rg.Substring(5, 1));
                n[6] = Convert.ToInt32(rg.Substring(6, 1));
                n[7] = Convert.ToInt32(rg.Substring(7, 1));
                n[8] = Convert.ToInt32(rg.Substring(8, 1));

                //Aplica a regra de validação do RG, multiplicando cada digito por valores pré-determinados
                n[0] *= 2;
                n[1] *= 3;
                n[2] *= 4;
                n[3] *= 5;
                n[4] *= 6;
                n[5] *= 7;
                n[6] *= 8;
                n[7] *= 9;
                n[8] *= 100;

                //Valida o RG
                int somaFinal = n[0] + n[1] + n[2] + n[3] + n[4] + n[5] + n[6] + n[7] + n[8];
                //int somaFinal = n[0] + n[1] + n[2] + n[3] + n[4] + n[5] + n[6] + n[7];
                if ((somaFinal % 11) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion Validar RG

        #region Validar Email

        public static bool IsEmailValido(string _email)
        {
            Regex validaEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (!validaEmail.IsMatch(_email))
            {
                return false;
            }
            return true;
        }

        #endregion Validar Email

        #region Validar CNPJ

        public static bool IsCnpjValido(string _cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            _cnpj = _cnpj.Trim();
            _cnpj = _cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (_cnpj.Length != 14)
                return false;
            tempCnpj = _cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return _cnpj.EndsWith(digito);
        }

        #endregion Validar CNPJ
    }
}