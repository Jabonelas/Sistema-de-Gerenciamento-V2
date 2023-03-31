using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
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
        public static int idRegistro = 0;

        public frmClienteCPF()
        {
            InitializeComponent();
        }

        private void BuscarClientePeloCPF()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadoCliente = db.tb_registro.Where(x => x.rg_cpf == txtClienteCPF.Text && x.rg_tipo_cadastro == "Cliente"
                    || x.rg_cnpj == txtClienteCPF.Text && x.rg_tipo_cadastro == "Cliente").Select(x => x.id_registro);

                    dadoCliente.ForEach(x => idRegistro = x);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
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
            if (cmbTipoCliente.Text == "Pessoa Fisica")
            {
                ManipulacaoTextBox.FormatoCPF(e, txtClienteCPF);
            }
            else
            {
                ManipulacaoTextBox.FormatoCNPJ(e, txtClienteCPF);
            }
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
            BuscarClientePeloCPF();

            frmPDV.clienteCPF = txtClienteCPF.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(this);
        }

        private void txtClienteCPF_Leave(object sender, EventArgs e)
        {
            if (txtClienteCPF.Text != string.Empty && txtClienteCPF.Text != " _")
            {
                if (cmbTipoCliente.Text == "Pessoa Fisica")
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
                else
                {
                    if (Validacoes.IsCampoPreenchido(txtClienteCPF) == true)
                    {
                        if (Validacoes.IsCnpjValido(txtClienteCPF.Text) == false)
                        {
                            MensagemAtencao.MensagemCampoDigitadoInvalido("CNPJ");

                            ModificacoesTextBox(txtClienteCPF);
                        }
                        else
                        {
                            txtClienteCPF.BackColor = Color.FromArgb(0, 255, 255, 255);
                        }
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

        private void cmbTipoCliente_TextChanged(object sender, EventArgs e)
        {
            if (cmbTipoCliente.Text == "Pessoa Fisica")
            {
                lblCliente.Text = "Cliente CPF";
            }
            else
            {
                lblCliente.Text = "Cliente CNPJ";
            }
        }
    }
}