using DevExpress.Utils.Extensions;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmNovoUsuario : DevExpress.XtraEditors.XtraForm
    {
        private List<tb_registro> listaFuncionarios = new List<tb_registro>();

        private frmTelaPrincipal principal;

        public frmNovoUsuario(frmTelaPrincipal _principal)
        {
            InitializeComponent();

            principal = _principal;

            ReloadData();
        }

        private void ReloadData()
        {
            try
            {
                using (var handle = SplashScreenManager.ShowOverlayForm(principal))
                {
                    ListaFuncionarios();

                    ListandoUsuarios();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void ListaFuncionarios()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities7 db = new SistemaDeGerenciamento2_0Entities7())
                {
                    var funcionarios = db.tb_registro.Where(x => x.rg_tipo_cadastro == "Funcionario");

                    funcionarios.ForEach(x => listaFuncionarios.Add(x));
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void ListandoUsuarios()
        {
            foreach (var item in listaFuncionarios)
            {
                pnlUsuarios.Controls.Add(new uscUsuarios()
                {
                    nomeFuncionario = item.rg_nome,
                    usuario = item.rg_login,
                    IDCadastro = item.id_registro,
                });
            }
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario();
            frmCadastroUsuario.ShowDialog();
        }
    }
}