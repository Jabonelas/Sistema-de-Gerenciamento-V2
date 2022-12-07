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
        public static bool DigitarApenasNumero(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 20;

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            return true;
        }

        public static bool DigitarApenasLetras(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 100;

            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)32)
            {
                e.Handled = true;
            }

            return true;
        }

        public static bool DigitarApenasLetrasOuNumeros(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 20;

            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)32 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            return true;
        }

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

        public static bool FormatoEmail(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 50;

            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)64
                && !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)45 && e.KeyChar != (char)46
                && e.KeyChar != (char)95 && e.KeyChar != (char)47)
            {
                e.Handled = true;
            }

            return true;
        }

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

        public static void FormatoCNPJ(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _txtBox)
        {
            _txtBox.Properties.MaxLength = 18;

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (_txtBox.Text.Length)
                {
                    case 0:
                        _txtBox.Text = "";
                        break;

                    case 2:
                        _txtBox.Text = _txtBox.Text + ".";
                        _txtBox.SelectionStart = 3;
                        break;

                    case 6:
                        _txtBox.Text = _txtBox.Text + ".";
                        _txtBox.SelectionStart = 7;
                        break;

                    case 10:
                        _txtBox.Text = _txtBox.Text + "/";
                        _txtBox.SelectionStart = 11;
                        break;

                    case 15:
                        _txtBox.Text = _txtBox.Text + "-";
                        _txtBox.SelectionStart = 16;
                        break;
                }
            }
        }
    }
}