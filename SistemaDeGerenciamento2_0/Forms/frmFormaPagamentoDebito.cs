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
    public partial class frmFormaPagamentoDebito : DevExpress.XtraEditors.XtraForm
    {
        public frmFormaPagamentoDebito()
        {
            InitializeComponent();
        }

        public frmFormaPagamentoDebito(string _valorTotal)
        {
            InitializeComponent();

            lblValorTotal.Text = _valorTotal;
            lblNomeUsuario.Text = frmLogin.UsuarioLogado;
        }
    }
}