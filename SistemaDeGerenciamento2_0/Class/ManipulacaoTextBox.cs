using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0
{
    internal class ManipulacaoTextBox
    {
        public static bool TeclaDigitadaFoiNumero(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 20;

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            return true;
        }

        public static bool TeclaDigitadaFoiLetras(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 20;

            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)32)
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
            catch (Exception ex)
            {
            }
        }

        public static bool TeclaDigitadaFoiLetrasOuNumeros(KeyPressEventArgs e, DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.Properties.MaxLength = 20;

            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)32 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            return true;
        }
    }
}