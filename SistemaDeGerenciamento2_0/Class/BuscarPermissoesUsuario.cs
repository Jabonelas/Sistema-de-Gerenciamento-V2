using DevExpress.Utils.Extensions;
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
    internal class BuscarPermissoesUsuario
    {
        public List<tb_permissoes> listaPermissoes = new List<tb_permissoes>();

        public List<tb_permissoes> ListaPermissoesUsuario()
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

                    acessosUsuario.ForEach(x => listaPermissoes.Add(x.Permissao));

                    return listaPermissoes;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Permissões Usuários Na Tela Exibir Todos Os Cadastros| {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarPermissoesTelaTodosCadastro(x);

                return null;
            }
        }
    }
}