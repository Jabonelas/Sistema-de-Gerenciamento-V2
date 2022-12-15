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
    public partial class uscUsuarios : DevExpress.XtraEditors.XtraUserControl
    {
        public string nomeFuncionario { get => lblNomeFuncionario.Text; set => lblNomeFuncionario.Text = value; }
        public string usuario { get => lblUsuario.Text; set => lblUsuario.Text = value; }

        public int? IDCadastro = 0;

        public uscUsuarios()
        {
            InitializeComponent();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario(IDCadastro);
            frmCadastroUsuario.ShowDialog();
        }
    }
}