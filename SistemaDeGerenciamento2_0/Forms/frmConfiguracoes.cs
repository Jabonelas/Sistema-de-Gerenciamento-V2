using DevExpress.XtraEditors;
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
    public partial class frmConfiguracoes : DevExpress.XtraEditors.XtraForm
    {
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            TelaNovoUsuario();
        }

        private void TelaNovoUsuario()
        {
            pnlConfiguracoes.Controls.Clear();
            frmNovoUsuario frmCadastroUsuario = new frmNovoUsuario();
            frmCadastroUsuario.TopLevel = false;
            pnlConfiguracoes.Controls.Add(frmCadastroUsuario);
            pnlConfiguracoes.Tag = frmCadastroUsuario;
            frmCadastroUsuario.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            TelaCadastrarEmpresa();
        }

        private void TelaCadastrarEmpresa()
        {
            pnlConfiguracoes.Controls.Clear();
            frmDadosEmpresa frmNovoUsuario = new frmDadosEmpresa();
            frmNovoUsuario.TopLevel = false;
            pnlConfiguracoes.Controls.Add(frmNovoUsuario);
            pnlConfiguracoes.Tag = frmNovoUsuario;
            frmNovoUsuario.Show();
        }
    }
}