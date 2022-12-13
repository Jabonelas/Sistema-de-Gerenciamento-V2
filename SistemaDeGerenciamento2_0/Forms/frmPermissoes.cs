using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmPermissoes : DevExpress.XtraEditors.XtraForm
    {
        private frmCadastroUsuario form = new frmCadastroUsuario();

        public frmPermissoes(frmCadastroUsuario _form)
        {
            InitializeComponent();

            form = _form;
        }

        private int? FKPermissoes = 0;

        //private void BuscarFKPermissoes()
        //{
        //    try
        //    {
        //        using (SistemaDeGerenciamento2_0Entities7 db = new SistemaDeGerenciamento2_0Entities7())
        //        {
        //            int IDCadastro = Convert.ToInt32(form.cmbFuncionario.Properties.GetDisplayValueByKeyValue(form.cmbFuncionario));

        //            FKPermissoes = db.tb_registro.Where(x => x.id_registro.Equals(IDCadastro)).Select(x => x.fk_permissoes).FirstOrDefault();
        //        }
        //    }
        //    catch (Exception x)
        //    {
        //        MessageBox.Show(x.ToString());
        //    }
        //}

        private void PreencherCheckBox()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities7 db = new SistemaDeGerenciamento2_0Entities7())
                {
                    var chekedBoxPreenchidos = db.tb_permissoes.Where(x => x.id_permissoes.Equals(FKPermissoes));
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (form.txtConfirmacaoSenha.Text == form.txtSenha.Text)
            {
            }
            else
            {
                MensagemAtencao.MensagemSenhasDivergentes();
                form.txtConfirmacaoSenha.Focus();
            }
        }
    }
}