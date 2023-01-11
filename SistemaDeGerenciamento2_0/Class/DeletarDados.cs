using SistemaDeGerenciamento2_0.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento2_0.Class
{
    public static class DeletarDados
    {
        public static void DeletarCadastroProduto(string _codigoProduto)
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadosDeletarCadastroProduto = (from produto in db.tb_produto
                                                       where produto.pd_codigo.Equals(_codigoProduto)
                                                       select new
                                                       {
                                                           Produto = produto
                                                       }).ToList();

                    db.tb_produto.Remove(dadosDeletarCadastroProduto[0].Produto);
                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Apagar Cadastro do Produto | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoDeletarCadastroProduto(x);
            }
        }

        public static void DeletarCadastro(string _CNPJouCPF)
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadosDeletarCadastro = (from registro in db.tb_registro
                                                join endereco in db.tb_enderecos
                                                on registro.fk_endereco equals endereco.id_endereco
                                                join informacoes in db.tb_informacoes_comerciais
                                                on registro.fk_informacao_comercial equals informacoes.id_informacao_comercial
                                                where registro.rg_cnpj == _CNPJouCPF || registro.rg_cpf == _CNPJouCPF
                                                select new
                                                {
                                                    Registro = registro,
                                                    Endereco = endereco,
                                                    Informacoes = informacoes
                                                }).ToList();

                    db.tb_registro.Remove(dadosDeletarCadastro[0].Registro);
                    db.tb_enderecos.Remove(dadosDeletarCadastro[0].Endereco);
                    db.tb_informacoes_comerciais.Remove(dadosDeletarCadastro[0].Informacoes);
                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Apagar Cadastro | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoDeletarCadastro(x);
            }
        }
    }
}