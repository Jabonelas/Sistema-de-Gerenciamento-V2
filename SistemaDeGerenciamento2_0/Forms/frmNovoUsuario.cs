using DevExpress.Utils.Extensions;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmNovoUsuario : DevExpress.XtraEditors.XtraForm
    {
        private List<tb_registro> listaFuncionarios = new List<tb_registro>();

        private Form frmTelaPrincipal;

        public frmNovoUsuario(Form _frmTelaPrincipal)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;

            ReloadData();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario();
            frmCadastroUsuario.ShowDialog();
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                ListaFuncionarios();

                ListandoUsuarios();
            }
        }

        private void ListaFuncionarios()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    var funcionarios = db.tb_registro.Where(x => x.rg_tipo_cadastro == "Funcionario");

                    funcionarios.ForEach(x => listaFuncionarios.Add(x));
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Lista de Funcionarios Cadastrados - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarListaFuncionarios(x);
            }
        }

        private void ListandoUsuarios()
        {
            foreach (var item in listaFuncionarios)
            {
                pnlUsuarios.Controls.Add(new uscUsuarios(frmTelaPrincipal)
                {
                    nomeFuncionario = item.rg_nome,
                    usuario = item.rg_login,
                    id = item.id_registro.ToString(),
                });
            }
        }
    }
}