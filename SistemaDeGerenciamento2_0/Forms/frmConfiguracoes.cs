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

        private Form frmTelaPrincipal = null;

        public frmConfiguracoes(frmTelaPrincipal _frmTelaPrincipal, string _telaSolicitada)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;

            VerificarTela(_telaSolicitada);
        }

        private void VerificarTela(string _tela)
        {
            if (_tela == "ConfigUsuario")
            {
                //TelaNovoUsuario(frmTelaPrincipal);

                ExibindoTelaUsuario();
            }
            else if (_tela == "ConfigEmpresa")

            {
                TelaExibindoEmpresa();
            }
            else if (_tela == "ConfigPerfil")
            {
                ExibindoTelaPerfil();
            }
            else if (_tela == "ConfigFinanceiro")
            {
                ExibindoTelaConfiguracaoFinanceira();
            }
        }

        public frmConfiguracoes(frmAcessoRapido frmAcessoRapido)
        {
            InitializeComponent();

            TelaNovoUsuario(frmAcessoRapido);
        }

        private void ExibindoTelaUsuario()
        {
            this.Size = new Size(953, 622);
            pnlConfiguracoes.Size = new Size(944, 542);

            if (frmTelaPrincipal == null)
            {
                TelaNovoUsuario(this);
            }
            else
            {
                TelaNovoUsuario(frmTelaPrincipal);
            }
        }

        private void TelaExibindoEmpresa()
        {
            this.Size = new Size(953, 670);
            pnlConfiguracoes.Size = new Size(944, 600);

            if (frmTelaPrincipal == null)
            {
                TelaCadastrarEmpresa(this);
            }
            else
            {
                TelaCadastrarEmpresa(frmTelaPrincipal);
            }
        }

        private void ExibindoTelaPerfil()
        {
            this.Size = new Size(953, 432);
            pnlConfiguracoes.Size = new Size(923, 341);

            TelaPerfilUsuario();
        }

        private void TelaNovoUsuario(Form frmTelaPrincipal)
        {
            pnlConfiguracoes.Controls.Clear();
            frmNovoUsuario frmCadastroUsuario = new frmNovoUsuario(frmTelaPrincipal);
            frmCadastroUsuario.TopLevel = false;
            pnlConfiguracoes.Controls.Add(frmCadastroUsuario);
            pnlConfiguracoes.Tag = frmCadastroUsuario;
            frmCadastroUsuario.Show();
        }

        private void TelaCadastrarEmpresa(Form frmTelaPrincipal)
        {
            pnlConfiguracoes.Controls.Clear();
            frmDadosEmpresa frmDadosEmpresa = new frmDadosEmpresa(frmTelaPrincipal);
            frmDadosEmpresa.TopLevel = false;
            frmDadosEmpresa.btnCancelar.Visible = false;
            frmDadosEmpresa.btnSalvar.Location = new Point(784, 539);
            pnlConfiguracoes.Controls.Add(frmDadosEmpresa);
            pnlConfiguracoes.Tag = frmDadosEmpresa;
            frmDadosEmpresa.Show();
        }

        private void TelaPerfilUsuario()
        {
            pnlConfiguracoes.Controls.Clear();
            frmPerfilUsuario frmPerfilUsuario = new frmPerfilUsuario();
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
            if (e.KeyCode == Keys.Escape)
            {
                MensagemAtencao.MensagemCancelar(this);
            }
        }

        private void ExibindoTelaConfiguracaoFinanceira()
        {
            this.Size = new Size(953, 670);
            pnlConfiguracoes.Size = new Size(944, 600);

            if (frmTelaPrincipal == null)
            {
                TelaConfiguracoesFinanceiras(this);
            }
            else
            {
                TelaConfiguracoesFinanceiras(frmTelaPrincipal);
            }
        }

        private void TelaConfiguracoesFinanceiras(Form frmTelaPrincipal)
        {
            pnlConfiguracoes.Controls.Clear();
            frmConfiguracaoFinanceira frmConfiguracaoFinanceira = new frmConfiguracaoFinanceira(frmTelaPrincipal);
            frmConfiguracaoFinanceira.TopLevel = false;
            frmConfiguracaoFinanceira.KeyPreview = false;
            frmConfiguracaoFinanceira.btnCancelar.Visible = false;
            frmConfiguracaoFinanceira.btnSalvar.Location = new Point(779, 546);
            pnlConfiguracoes.Controls.Add(frmConfiguracaoFinanceira);
            pnlConfiguracoes.Tag = frmConfiguracaoFinanceira;
            frmConfiguracaoFinanceira.Show();
        }
    }
}