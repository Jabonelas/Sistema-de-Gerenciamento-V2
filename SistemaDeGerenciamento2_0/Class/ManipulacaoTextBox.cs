using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0
{
    internal static class ManipulacaoTextBox
    {
        #region Digitar Apenas Numeros

        public static bool DigitarApenasNumero(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 20;

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            return true;
        }

        #endregion Digitar Apenas Numeros

        #region Digitar Apenas Letras

        public static bool DigitarApenasLetras(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 100;

            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)32)
            {
                e.Handled = true;
            }

            return true;
        }

        #endregion Digitar Apenas Letras

        #region Digitar Apenas Letras e Numeros

        public static bool DigitarApenasLetrasOuNumeros(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 20;

            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)32 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            return true;
        }

        #endregion Digitar Apenas Letras e Numeros

        #region Formato Dinheiro

        public static void FormatoDinheiro(KeyPressEventArgs e, object sender, DevExpress.XtraEditors.TextEdit _textBox)
        {
            try
            {
                _textBox.Properties.MaxLength = 20;

                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (_textBox.Text.Length <= 13 || e.KeyChar.Equals((char)Keys.Back))
                    {
                        DevExpress.XtraEditors.TextEdit textBox = (DevExpress.XtraEditors.TextEdit)sender;
                        string testoDoTextBox = Regex.Replace(textBox.Text, "[^0-9]", string.Empty);
                        if (testoDoTextBox == string.Empty)
                        {
                            testoDoTextBox = "00";
                        }

                        testoDoTextBox += e.KeyChar;
                        textBox.Text = String.Format("R$ {0:#,##0.00}", double.Parse(testoDoTextBox) / 100);
                        textBox.Select(textBox.Text.Length, 0);
                    }
                }
                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }

        #endregion Formato Dinheiro

        #region Formato Porcentagem

        public static void PreenchimentoPorcentagem(KeyPressEventArgs e, object sender, DevExpress.XtraEditors.TextEdit _textBox)
        {
            try
            {
                _textBox.Properties.MaxLength = 7;

                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (_textBox.SelectionLength <= 7 || e.KeyChar.Equals((char)Keys.Back))
                    {
                        DevExpress.XtraEditors.TextEdit textbox = (DevExpress.XtraEditors.TextEdit)sender;
                        string testoDoTextBox = Regex.Replace(textbox.Text, "[^0-9]", string.Empty);
                        if (testoDoTextBox == string.Empty)
                        {
                            testoDoTextBox = "0";
                        }
                        testoDoTextBox += e.KeyChar;
                        textbox.Text = String.Format("{0:#,##0.00} %", double.Parse(testoDoTextBox) / 100);
                        textbox.Select(textbox.Text.Length, 0);
                    }
                }
                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }

        #endregion Formato Porcentagem

        #region Formato Data

        public static void FormatoData(DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 10;

            switch (_textBox.Text.Length)
            {
                case 0:
                    _textBox.Text = "";
                    break;

                case 2:
                    _textBox.Text = _textBox.Text + "/";
                    _textBox.SelectionStart = 3;
                    break;

                case 5:
                    _textBox.Text = _textBox.Text + "/";
                    _textBox.SelectionStart = 6;
                    break;
            }
        }

        #endregion Formato Data

        #region Formato de CPF

        public static void FormatoCPF(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 14;

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (_textBox.Text.Length)
                {
                    case 0:
                        _textBox.Text = "";
                        break;

                    case 3:
                        _textBox.Text = _textBox.Text + ".";
                        _textBox.SelectionStart = 4;
                        break;

                    case 7:
                        _textBox.Text = _textBox.Text + ".";
                        _textBox.SelectionStart = 8;
                        break;

                    case 11:
                        _textBox.Text = _textBox.Text + "-";
                        _textBox.SelectionStart = 12;
                        break;
                }
            }
        }

        #endregion Formato de CPF

        #region Formato RG

        public static void FormatoRG(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox
            )
        {
            _textBox.Properties.MaxLength = 12;

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (_textBox.Text.Length)
                {
                    case 0:
                        _textBox.Text = "";
                        break;

                    case 2:
                        _textBox.Text = _textBox.Text + ".";
                        _textBox.SelectionStart = 3;
                        break;

                    case 6:
                        _textBox.Text = _textBox.Text + ".";
                        _textBox.SelectionStart = 7;
                        break;

                    case 10:
                        _textBox.Text = _textBox.Text + "-";
                        _textBox.SelectionStart = 11;
                        break;
                }
            }
        }

        #endregion Formato RG

        #region Formatar TextBox Email

        public static bool FormatoEmail(KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)64
                && !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)45 && e.KeyChar != (char)46
                && e.KeyChar != (char)95 && e.KeyChar != (char)47)
            {
                e.Handled = true;
            }

            return true;
        }

        #endregion Formatar TextBox Email

        #region Formato Celular

        public static void FormatoCelular(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 15;

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (_textBox.Text.Length)
                {
                    case 0:
                        _textBox.Text = "(";
                        _textBox.SelectionStart = 1;
                        break;

                    case 3:
                        _textBox.Text = _textBox.Text + ") ";
                        _textBox.SelectionStart = 5;
                        break;

                    case 10:
                        _textBox.Text = _textBox.Text + "-";
                        _textBox.SelectionStart = 11;
                        break;
                }
            }
        }

        #endregion Formato Celular

        #region Formato Telefone Residencial

        public static void FormatoTelefone(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 14;

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (_textBox.Text.Length)
                {
                    case 0:
                        _textBox.Text = "(";
                        _textBox.SelectionStart = 1;
                        break;

                    case 3:
                        _textBox.Text = _textBox.Text + ") ";
                        _textBox.SelectionStart = 5;
                        break;

                    case 9:
                        _textBox.Text = _textBox.Text + "-";
                        _textBox.SelectionStart = 10;
                        break;
                }
            }
        }

        #endregion Formato Telefone Residencial

        #region Formato CEP

        public static void FormatoCEP(DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 9;

            switch (_textBox.Text.Length)
            {
                case 0:
                    _textBox.Text = "";
                    break;

                case 5:
                    _textBox.Text = _textBox.Text + "-";
                    _textBox.SelectionStart = 6;
                    break;
            }
        }

        #endregion Formato CEP
    }
}