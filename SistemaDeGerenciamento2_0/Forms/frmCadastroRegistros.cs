using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmCadastroRegistros : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private string tipoCadastro = string.Empty;

        public frmCadastroRegistros(string _tipoCadastro)
        {
            InitializeComponent();

            cmbTipoPessoa.Text = "Pessoa Fisica";

            tipoCadastro = _tipoCadastro;

            TipoCadastro(tipoCadastro);
        }

        private frmTelaPrincipal frmTelaPrincipal;

        public frmCadastroRegistros(string _tipoCadastro, frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            cmbTipoPessoa.Text = "Pessoa Fisica";

            tipoCadastro = _tipoCadastro;

            frmTelaPrincipal = _frmTelaPrincipal;

            ReloadData();
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                TipoCadastro(tipoCadastro);
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

        private void btnFornecedor_Click(object sender, EventArgs e)
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
                TelaAcessoCadastroPessoaFisica();
            }
            else
            {
                TelaAcessoCadastroPessoaJuridica();
            }
        }

        private void TelaAcessoCadastroPessoaFisica()
        {
            pnlCadastroRegistro.Controls.Clear();
            frmCadastroRegistroPessoaFisica frm = new frmCadastroRegistroPessoaFisica(tipoCadastro, this);
            frm.TopLevel = false;
            pnlCadastroRegistro.Controls.Add(frm);
            pnlCadastroRegistro.Tag = frm;
            frm.Show();
        }

        private void TelaAcessoCadastroPessoaJuridica()
        {
            pnlCadastroRegistro.Controls.Clear();
            frmCadastroRegistroPessoaJuridica frm = new frmCadastroRegistroPessoaJuridica(tipoCadastro, this);
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

            tipoCadastro = "Cliente";

            TipoPessoa();
        }

        private void TipoFornecedor()
        {
            btnCliente.Appearance.BackColor = Color.Transparent;
            btnFuncionario.Appearance.BackColor = Color.Transparent;
            btnFornecedor.Appearance.BackColor = Color.LightGray;

            tipoCadastro = "Fornecedor";

            TipoPessoa();
        }

        private void TipoFuncionario()
        {
            btnCliente.Appearance.BackColor = Color.Transparent;
            btnFuncionario.Appearance.BackColor = Color.LightGray;
            btnFornecedor.Appearance.BackColor = Color.Transparent;

            tipoCadastro = "Funcionario";

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