using DevExpress.XtraEditors;
using SistemaDeGerenciamento2_0.Class;
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
    public partial class frmConexaoBanco : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        public frmConexaoBanco()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConexaoBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                ConfirmarStringConexaoBanco();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            ConfirmarStringConexaoBanco();
        }

        private void ConfirmarStringConexaoBanco()
        {
            LogConexaoBanco.EscreverArquivoDeLogStringConexaoBanco($"NOMESERVIDOR={txtNomeServidor.Text}" +
            $"\nBANCO={txtBanco.Text}" +
            $"\nLOGIN={txtLogin.Text}" +
            $"\nSENHA={txtSenha.Text}");

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(this);
        }

        private void frmConexaoBanco_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmConexaoBanco_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}