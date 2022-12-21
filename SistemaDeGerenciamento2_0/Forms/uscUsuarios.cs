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
using static SistemaDeGerenciamento2_0.Class.Estados;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class uscUsuarios : DevExpress.XtraEditors.XtraUserControl
    {
        public string nomeFuncionario { get => lblNomeFuncionario.Text; set => lblNomeFuncionario.Text = value; }
        public string usuario { get => lblUsuario.Text; set => lblUsuario.Text = value; }
        public string id { get => lblId.Text; set => lblId.Text = value; }

        private Form frmTelaPrincipal;

        public uscUsuarios(Form _frmTelaPrincipal)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario(Convert.ToInt32(id), frmTelaPrincipal, nomeFuncionario);
            //frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario(IDCadastro, frmTelaPrincipal, nomeFuncionario);
            frmCadastroUsuario.ShowDialog();
        }
    }
}