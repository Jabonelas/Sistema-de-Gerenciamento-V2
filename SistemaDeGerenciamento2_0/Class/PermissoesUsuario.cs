using DevExpress.Utils.Extensions;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Forms;
using SistemaDeGerenciamento2_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento2_0.Class
{
    internal class PermissoesUsuario
    {
        private frmTelaPrincipal frmTelaPrincipal;

        public List<tb_permissoes> listaPermissoesUsuario = new List<tb_permissoes>();

        public void ReloadData(frmTelaPrincipal _frmTelaPrincipal)
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(_frmTelaPrincipal))
            {
                BuscarPermissoesUsuario();

                frmTelaPrincipal = _frmTelaPrincipal;
            }
        }

        public void BuscarPermissoesUsuario()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var acessosUsuario = db.tb_permissoes.Join(db.tb_registro, permissao => permissao.id_permissoes, registro => registro.fk_permissoes, (permissao, registro) => new
                    {
                        Permissao = permissao,
                        Registro = registro,
                    }).Where(x => x.Permissao.id_permissoes == x.Registro.fk_permissoes && x.Registro.rg_login == frmLogin.UsuarioLogado);

                    acessosUsuario.ForEach(x => listaPermissoesUsuario.Add(x.Permissao));
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Permissões Usuários | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarPermissoes(x);
            }
        }

        public void VerificarAcessoCadastro(string _Cadastro)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_efetuar_cadastro);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros(_Cadastro, frmTelaPrincipal);
                frmCadastroRegistros.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoTodosCadastros(string _Cadastro)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_visualizar_cadastro_completo);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmCadastro frmCadastro = new frmCadastro(frmTelaPrincipal);
                frmCadastro.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoCadastroProduto()
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_adicionar_produto);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmCadastroProduto frmCadastroProduto = new frmCadastroProduto();
                frmCadastroProduto.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, "Adiconar Produto");
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoTodosProdutos()
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_visualizar_todos_produtos);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmProdutos frmProdutos = new frmProdutos(frmTelaPrincipal);
                frmProdutos.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, "Todos Produtos");
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoEditarProduto(string _codigoProduto)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_editar_produto);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmCadastroProduto frmCadastroProduto = new frmCadastroProduto(_codigoProduto);
                frmCadastroProduto.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, "Editar Produto");
                frmConfirmarAcesso.ShowDialog();
            }
        }
    }
}