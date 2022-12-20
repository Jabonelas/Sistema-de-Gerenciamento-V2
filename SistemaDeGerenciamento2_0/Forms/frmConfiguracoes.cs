using DevExpress.Data.PivotGrid;
using DevExpress.Utils.Extensions;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmConfiguracoes : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private frmTelaPrincipal frmTelaPrincipal;

        public frmConfiguracoes(frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;

            TelaNovoUsuario();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            this.Size = new Size(953, 622);
            pnlConfiguracoes.Size = new Size(944, 542);

            TelaNovoUsuario();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            this.Size = new Size(953, 670);
            pnlConfiguracoes.Size = new Size(944, 600);

            TelaCadastrarEmpresa();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Size = new Size(953, 432);
            pnlConfiguracoes.Size = new Size(923, 341);

            TelaPerfilUsuario();
        }

        private void TelaNovoUsuario()
        {
            pnlConfiguracoes.Controls.Clear();
            frmNovoUsuario frmCadastroUsuario = new frmNovoUsuario(frmTelaPrincipal);
            frmCadastroUsuario.TopLevel = false;
            pnlConfiguracoes.Controls.Add(frmCadastroUsuario);
            pnlConfiguracoes.Tag = frmCadastroUsuario;
            frmCadastroUsuario.Show();
        }

        private void TelaCadastrarEmpresa()
        {
            pnlConfiguracoes.Controls.Clear();
            frmDadosEmpresa frmNovoUsuario = new frmDadosEmpresa(frmTelaPrincipal);
            frmNovoUsuario.TopLevel = false;
            pnlConfiguracoes.Controls.Add(frmNovoUsuario);
            pnlConfiguracoes.Tag = frmNovoUsuario;
            frmNovoUsuario.Show();
        }

        private void TelaPerfilUsuario()
        {
            pnlConfiguracoes.Controls.Clear();
            frmPerfilUsuario frmPerfilUsuario = new frmPerfilUsuario(frmTelaPrincipal);
            frmPerfilUsuario.TopLevel = false;
            pnlConfiguracoes.Controls.Add(frmPerfilUsuario);
            pnlConfiguracoes.Tag = frmPerfilUsuario;
            frmPerfilUsuario.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(this);
        }

        private void frmConfiguracoes_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmConfiguracoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmConfiguracoes_KeyDown(object sender, KeyEventArgs e)
        {
            MensagemAtencao.MensagemCancelar(this);
        }

        private void btnConfiguracaoFinanceira_Click(object sender, EventArgs e)
        {
            //this.Size = new Size(953, 400);
            //pnlConfiguracoes.Size = new Size(923, 300);

            TelaConfiguracoesFinanceiras();
        }

        private void TelaConfiguracoesFinanceiras()
        {
            pnlConfiguracoes.Controls.Clear();
            frmConfiguracaoFinanceira frmConfiguracaoFinanceira = new frmConfiguracaoFinanceira();
            frmConfiguracaoFinanceira.TopLevel = false;
            pnlConfiguracoes.Controls.Add(frmConfiguracaoFinanceira);
            pnlConfiguracoes.Tag = frmConfiguracaoFinanceira;
            frmConfiguracaoFinanceira.Show();
        }
    }
}