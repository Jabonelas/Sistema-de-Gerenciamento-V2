using DevExpress.XtraEditors;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
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
    public partial class frmFormaPagamentoDinheiro : DevExpress.XtraEditors.XtraForm
    {
        private decimal valorPagoNoProduto = 0;
        private decimal valorJuros = 0;
        private decimal valorFinalPago = 0;

        private string numeroNF;

        private frmPDV frmPDV;

        private frmPagamento frmPagamento;

        private frmClienteCPF frmClienteCPF;

        private frmTelaPrincipal frmTelaPrincipal;

        private PermissoesUsuario permissoesUsuario = new PermissoesUsuario();

        public frmFormaPagamentoDinheiro(string _valorFinalPago, string _numeroNF, decimal _valorPagoNoProduto,
            decimal _valorJuros, frmTelaPrincipal _frmTelaPrincipal, frmPagamento _frmPagamento)
        {
            InitializeComponent();

            lblValorTotal.Text = _valorFinalPago;

            numeroNF = _numeroNF;

            valorPagoNoProduto = _valorPagoNoProduto;

            valorJuros = _valorJuros;

            frmTelaPrincipal = _frmTelaPrincipal;

            frmPagamento = _frmPagamento;

            valorFinalPago = Convert.ToDecimal(_valorFinalPago.Replace("R$", ""));

            lblNomeUsuario.Text = frmLogin.UsuarioLogado.ToUpper();
        }

        private void txtValorEntregue_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtValorEntregue.Text != string.Empty)
            {
                lblTroco.Text = (Convert.ToDecimal(txtValorEntregue.Text.Replace("R$", "")) - Convert.ToDecimal(lblValorTotal.Text.Replace("R$", ""))).ToString("C2");
            }
        }

        private void btn1FinalizarVenda_Click(object sender, EventArgs e)
        {
            NotaFiscalSaida();

            AlterandoEstoque();

            btn1CancelarVenda.Enabled = false;
            btn1FinalizarVenda.Enabled = false;
        }

        private void AlterandoEstoque()
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
                MessageBox.Show(x.ToString());
            }
        }

        private void NotaFiscalSaida()
        {
            try
            {
                int numeroNFSaida = Convert.ToInt32(numeroNF);

                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    foreach (var item in frmPDV.listaSecundaria)
                    {
                        int idProduto = item.IdProduto;
                        decimal quantidadeProduto = item.QuantidadeProduto;
                        decimal valorProdutoSemDesconto = item.PrecoProduto;
                        decimal valorDesconto = item.ValorDesconto;

                        int fkCliente = 0;

                        if (frmClienteCPF.idRegistro != 0)
                        {
                            fkCliente = frmClienteCPF.idRegistro;

                            var NFSaida = new tb_nota_fiscal_saida()
                            {
                                nfs_numero_nf_saida = numeroNFSaida,
                                nfs_data_emissao = DateTime.Today,
                                nfs_quantidade = quantidadeProduto,
                                nfs_valor_total_parcial = valorProdutoSemDesconto,
                                nfs_valor_desconto = valorDesconto,
                                nfs_valor_pago = valorPagoNoProduto,
                                nfs_valor_juros = valorJuros,
                                nfs_valor_final_pago = valorFinalPago,
                                nfs_vendedor = frmLogin.UsuarioLogado,
                                nfs_tipo_pagamento = "Dinheiro",
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
                                nfs_data_emissao = DateTime.Today,
                                nfs_quantidade = quantidadeProduto,
                                nfs_valor_total_parcial = valorProdutoSemDesconto,
                                nfs_valor_desconto = valorDesconto,
                                nfs_valor_pago = valorPagoNoProduto,
                                nfs_valor_juros = valorJuros,
                                nfs_valor_final_pago = valorFinalPago,
                                nfs_vendedor = frmLogin.UsuarioLogado,
                                nfs_tipo_pagamento = "Dinheiro",
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

        private void btn1CancelarVenda_Click(object sender, EventArgs e)
        {
            CancelarVenda();
        }

        private void CancelarVenda()
        {
            permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
            permissoesUsuario.VerificarCancelarVendaTelaPDV("Cancelar Venda Tela PDV");

            if (frmPDV.permissaoCancelarVenda == true)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Realmente Cancela a Venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    frmPDV.permissaoCancelarVenda = false;
                    frmPagamento.Close();
                }
            }
        }
    }
}