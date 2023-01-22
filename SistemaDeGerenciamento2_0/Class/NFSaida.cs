using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Forms;
using SistemaDeGerenciamento2_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemaDeGerenciamento2_0.Class
{
    public static class NFSaida
    {
        public static void NotaFiscalSaida(string _numeroNF, decimal valorPagoNoProduto, decimal valorJuros, decimal valorFinalPago, string _tipoPagamento)
        {
            try
            {
                int numeroNFSaida = Convert.ToInt32(_numeroNF);

                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    foreach (var item in frmPDV.listaSecundaria)
                    {
                        int fkCliente = 0;
                        int idProduto = item.IdProduto;
                        decimal quantidadeProduto = item.QuantidadeProduto;
                        decimal valorProdutoSemDesconto = item.PrecoProdutoSemDesconto;
                        decimal valorProdutoComDesconto = item.PrecoProdutoComDesconto;
                        decimal valorDesconto = item.ValorDesconto;

                        if (frmClienteCPF.idRegistro != 0)
                        {
                            fkCliente = frmClienteCPF.idRegistro;

                            var NFSaida = new tb_nota_fiscal_saida()
                            {
                                nfs_numero_nf_saida = numeroNFSaida,
                                nfs_data_emissao = DateTime.Now,
                                nfs_quantidade = quantidadeProduto,
                                nfs_valor_parcial = valorProdutoSemDesconto,
                                nfs_valor_desconto = valorDesconto,
                                nfs_valor_pago = valorProdutoComDesconto,
                                nfs_valor_juros = valorJuros,
                                nfs_valor_total_pago = valorFinalPago,
                                nfs_vendedor = frmLogin.UsuarioLogado,
                                nfs_tipo_pagamento = _tipoPagamento,
                                fk_estoque = idProduto,
                                fk_registro_cliente = fkCliente
                            };

                            db.tb_nota_fiscal_saida.Add(NFSaida);
                            db.SaveChanges();
                        }
                        else
                        {
                            var NFSaida = new tb_nota_fiscal_saida()
                            {
                                nfs_numero_nf_saida = numeroNFSaida,
                                nfs_data_emissao = DateTime.Now,
                                nfs_quantidade = quantidadeProduto,
                                nfs_valor_parcial = valorProdutoSemDesconto,
                                nfs_valor_desconto = valorDesconto,
                                nfs_valor_pago = valorProdutoComDesconto,
                                nfs_valor_juros = valorJuros,
                                nfs_valor_total_pago = valorFinalPago,
                                nfs_vendedor = frmLogin.UsuarioLogado,
                                nfs_tipo_pagamento = _tipoPagamento,
                                fk_estoque = idProduto,
                            };

                            db.tb_nota_fiscal_saida.Add(NFSaida);
                            db.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public static void NotaFiscalSaidaCredito(string _numeroNF, decimal valorPagoNoProduto, decimal valorJuros, decimal valorFinalPago, string _tipoPagamento)
        {
            try
            {
                int numeroNFSaida = Convert.ToInt32(_numeroNF);

                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    foreach (var item1 in frmFormaPagamentoCredito.listaConfiguracoesFinanceiras)
                    {
                        foreach (var item in frmPDV.listaSecundaria)
                        {
                            int fkCliente = 0;
                            int idProduto = item.IdProduto;
                            decimal quantidadeProduto = item.QuantidadeProduto;
                            decimal valorProdutoSemDesconto = item.PrecoProdutoSemDesconto;
                            decimal valorProdutoComDesconto = item.PrecoProdutoComDesconto;
                            decimal valorDesconto = item.ValorDesconto;

                            if (frmClienteCPF.idRegistro != 0)
                            {
                                fkCliente = frmClienteCPF.idRegistro;

                                var NFSaida = new tb_nota_fiscal_saida()
                                {
                                    nfs_numero_nf_saida = numeroNFSaida,
                                    nfs_data_emissao = DateTime.Now,
                                    nfs_quantidade = quantidadeProduto,
                                    nfs_valor_parcial = valorProdutoSemDesconto,
                                    nfs_valor_desconto = valorDesconto,
                                    nfs_valor_pago = Convert.ToDecimal(valorProdutoComDesconto * item1.cf_juros_dia / 100 + valorProdutoComDesconto),
                                    nfs_valor_juros = Convert.ToDecimal(valorProdutoComDesconto * item1.cf_juros_dia / 100),
                                    nfs_valor_total_pago = valorFinalPago,
                                    nfs_vendedor = frmLogin.UsuarioLogado,
                                    nfs_tipo_pagamento = _tipoPagamento,
                                    fk_estoque = idProduto,
                                    fk_registro_cliente = fkCliente
                                };

                                db.tb_nota_fiscal_saida.Add(NFSaida);
                                db.SaveChanges();
                            }
                            else
                            {
                                var NFSaida = new tb_nota_fiscal_saida()
                                {
                                    nfs_numero_nf_saida = numeroNFSaida,
                                    nfs_data_emissao = DateTime.Now,
                                    nfs_quantidade = quantidadeProduto,
                                    nfs_valor_parcial = valorProdutoSemDesconto,
                                    nfs_valor_desconto = valorDesconto,
                                    nfs_valor_pago = Convert.ToDecimal(valorProdutoComDesconto * item1.cf_juros_dia / 100 + valorProdutoComDesconto),
                                    nfs_valor_juros = Convert.ToDecimal(valorProdutoComDesconto * item1.cf_juros_dia / 100),
                                    nfs_valor_total_pago = valorFinalPago,
                                    nfs_vendedor = frmLogin.UsuarioLogado,
                                    nfs_tipo_pagamento = _tipoPagamento,
                                    fk_estoque = idProduto,
                                };

                                db.tb_nota_fiscal_saida.Add(NFSaida);
                                db.SaveChanges();
                            }
                        }

                        break;
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}