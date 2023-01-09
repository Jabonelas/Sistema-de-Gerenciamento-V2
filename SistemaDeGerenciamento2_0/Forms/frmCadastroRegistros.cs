using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Context;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmCadastroRegistros : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private string tipoCadastro = string.Empty;

        private string CPFouCNPJCadastrado = string.Empty;

        private frmTelaPrincipal frmTelaPrincipal;

        private string tipoPessoa = string.Empty;

        public frmCadastroRegistros(string _tipoCadastro, frmTelaPrincipal _frmTelaPrincipal, string _CPFouCNPJCadastrado, string _tipoPessoa)
        {
            InitializeComponent();

            tipoCadastro = _tipoCadastro;

            frmTelaPrincipal = _frmTelaPrincipal;

            CPFouCNPJCadastrado = _CPFouCNPJCadastrado;

            tipoPessoa = _tipoPessoa;

            cmbTipoPessoa.Text = tipoCadastro;

            ReloadData();
        }

        public frmCadastroRegistros(string _tipoPessoa, frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            tipoPessoa = _tipoPessoa;

            cmbTipoPessoa.Text = "Pessoa Fisica";

            frmTelaPrincipal = _frmTelaPrincipal;

            ReloadData();
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                TipoCadastro(tipoPessoa);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            TipoCliente();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            TipoFuncionario();
        }

        private void btnFornecedor_Click_1(object sender, EventArgs e)
        {
            TipoFornecedor();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoPessoa_SelectedValueChanged(object sender, EventArgs e)
        {
            TipoPessoa();
        }

        private void frmCadastroRegistros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MensagemAtencao.MensagemCancelar(this);
            }
        }

        private void TipoCadastro(string _tipoCadastro)
        {
            if (_tipoCadastro == "Cliente")
            {
                TipoCliente();
            }
            else if (_tipoCadastro == "Funcionario")
            {
                TipoFuncionario();
            }
            else if (_tipoCadastro == "Fornecedor")
            {
                TipoFornecedor();
            }
        }

        private void TipoPessoa()
        {
            if (cmbTipoPessoa.Text == "Pessoa Fisica")
            {
                if (CPFouCNPJCadastrado == string.Empty)
                {
                    TelaAcessoCadastroPessoaFisicaCadastrar();
                }
                else
                {
                    TelaAcessoCadastroPessoaFisicaAlterar();
                }
            }
            else if (cmbTipoPessoa.Text == "Pessoa Juridica")
            {
                if (CPFouCNPJCadastrado == string.Empty)
                {
                    TelaAcessoCadastroPessoaJuridicaCadastrar();
                }
                else
                {
                    TelaAcessoCadastroPessoaJuridicaAlterar();
                }
            }
        }

        private void TelaAcessoCadastroPessoaFisicaCadastrar()
        {
            pnlCadastroRegistro.Controls.Clear();
            frmCadastroRegistroPessoaFisica frm = new frmCadastroRegistroPessoaFisica(tipoPessoa, this);
            frm.TopLevel = false;
            pnlCadastroRegistro.Controls.Add(frm);
            pnlCadastroRegistro.Tag = frm;
            frm.Show();
        }

        private void TelaAcessoCadastroPessoaFisicaAlterar()
        {
            pnlCadastroRegistro.Controls.Clear();
            frmCadastroRegistroPessoaFisica frm = new frmCadastroRegistroPessoaFisica(tipoCadastro, this, CPFouCNPJCadastrado);
            frm.TopLevel = false;
            pnlCadastroRegistro.Controls.Add(frm);
            pnlCadastroRegistro.Tag = frm;
            frm.Show();
        }

        private void TelaAcessoCadastroPessoaJuridicaCadastrar()
        {
            pnlCadastroRegistro.Controls.Clear();
            frmCadastroRegistroPessoaJuridica frm = new frmCadastroRegistroPessoaJuridica(tipoPessoa, this);
            frm.TopLevel = false;
            pnlCadastroRegistro.Controls.Add(frm);
            pnlCadastroRegistro.Tag = frm;
            frm.Show();
        }

        private void TelaAcessoCadastroPessoaJuridicaAlterar()
        {
            pnlCadastroRegistro.Controls.Clear();
            frmCadastroRegistroPessoaJuridica frm = new frmCadastroRegistroPessoaJuridica(tipoPessoa, this, CPFouCNPJCadastrado);
            frm.TopLevel = false;
            pnlCadastroRegistro.Controls.Add(frm);
            pnlCadastroRegistro.Tag = frm;
            frm.Show();
        }

        private void TipoCliente()
        {
            btnCliente.Appearance.BackColor = Color.LightGray;
            btnFuncionario.Appearance.BackColor = Color.Transparent;
            btnFornecedor.Appearance.BackColor = Color.Transparent;

            tipoPessoa = "Cliente";

            TipoPessoa();
        }

        private void TipoFornecedor()
        {
            btnCliente.Appearance.BackColor = Color.Transparent;
            btnFuncionario.Appearance.BackColor = Color.Transparent;
            btnFornecedor.Appearance.BackColor = Color.LightGray;

            tipoPessoa = "Fornecedor";

            TipoPessoa();
        }

        private void TipoFuncionario()
        {
            btnCliente.Appearance.BackColor = Color.Transparent;
            btnFuncionario.Appearance.BackColor = Color.LightGray;
            btnFornecedor.Appearance.BackColor = Color.Transparent;

            tipoPessoa = "Funcionario";

            TipoPessoa();
        }

        private void frmCadastroRegistros_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmCadastroRegistros_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}