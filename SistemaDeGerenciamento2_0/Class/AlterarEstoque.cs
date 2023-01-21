using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento2_0.Class
{
    public static class AlterarEstoque
    {
        public static void AlterandoEstoque()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    foreach (var item1 in frmPDV.listaSecundaria)
                    {
                        var produtoParaAlterarEstoque = db.tb_estoque.Where(x => x.fk_produto == item1.IdProduto).ToList();

                        foreach (var item2 in produtoParaAlterarEstoque)
                        {
                            item2.ep_quantidade -= item1.QuantidadeProduto;

                            db.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Atualizar Estoque Apos Venda - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoAtualizarEstoqueDepoisDeVenda(x);
            }
        }
    }
}