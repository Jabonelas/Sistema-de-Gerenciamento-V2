using DevExpress.XtraEditors;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmClienteCPF : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        public frmClienteCPF()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClienteCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtClienteCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoCPF(e, txtClienteCPF);
        }

        private void frmClienteCPF_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmClienteCPF_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            frmPDV.clienteCPF = txtClienteCPF.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(this);
        }

        private void txtClienteCPF_Leave(object sender, EventArgs e)
        {
            if (txtClienteCPF.Text != string.Empty)
            {
                if (Validacoes.IsCampoPreenchido(txtClienteCPF) == true)
                {
                    if (Validacoes.IsCpfValido(txtClienteCPF.Text) == false)
                    {
                        MensagemAtencao.MensagemCampoDigitadoInvalido("CPF");

                        ModificacoesTextBox(txtClienteCPF);
                    }
                    else
                    {
                        txtClienteCPF.BackColor = Color.FromArgb(0, 255, 255, 255);
                    }
                }
            }
        }

        private void ModificacoesTextBox(DevExpress.XtraEditors.TextEdit _textBox)
        {
            _textBox.BackColor = Color.LightGray;

            _textBox.Text = string.Empty;

            _textBox.Focus();
        }
    }
}