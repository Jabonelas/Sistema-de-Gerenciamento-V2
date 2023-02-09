using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Layout;
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
    public partial class frmHistoricoVenda : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        public bool IsPreencherGrid = false;

        public DateTime dataInicial = DateTime.Today;
        public DateTime dataFinal = DateTime.Today;

        private frmCalendario frmCalendario;

        public frmHistoricoVenda()
        {
            InitializeComponent();

            PreencherDataEsteMes();

            PreencherGrid();
        }

        private void PreencherDataEsteMes()
        {
            dataInicial = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dataFinal = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            txtCalendario.Text = $"{dataInicial.ToShortDateString()} - {dataFinal.ToShortDateString()}";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHistoricoVenda_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmHistoricoVenda_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void txtCalendario_Enter(object sender, EventArgs e)
        {
            ExibirCalendario();
        }

        private void ExibirCalendario()
        {
            frmCalendario = new frmCalendario(this);
            frmCalendario.StartPosition = FormStartPosition.Manual;
            frmCalendario.Location = new Point(480, 200);
            frmCalendario.Show();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            ExibirCalendario();
        }

        private void txtCalendario_Leave(object sender, EventArgs e)
        {
            FechandoTela();
        }

        private void btnCalendario_Leave(object sender, EventArgs e)
        {
            FechandoTela();
        }

        private void FechandoTela()
        {
            if (IsPreencherGrid == true)
            {
                PreencherGrid();
            }

            IsPreencherGrid = false;

            frmCalendario.Close();
        }

        private DataTable dt = new DataTable();

        private void CriandoColunasGrid()
        {
            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("Data");
            dt.Columns.Add("Cliente");
            dt.Columns.Add("Produto");
            dt.Columns.Add("Código");
            dt.Columns.Add("Número Nota Fiscal");
            dt.Columns.Add("Vendedor");
            dt.Columns.Add("Quantidade");
            dt.Columns.Add("Valor Pago");
            dt.Columns.Add("Valor Juros");
            dt.Columns.Add("Valor Desconto");
            dt.Columns.Add("Tipo Pagamento");
        }

        private void PreencherGrid()
        {
            CriandoColunasGrid();

            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var result = db.tb_nota_fiscal_saida.Join(db.tb_registro, nfs => nfs.fk_registro_cliente, rg => rg.id_registro,
                    (nfs, rg) => new { nfs, rg })
                    .Join(db.tb_estoque, x => x.nfs.fk_estoque, e => e.id_estoque, (x, e) => new { x, e })
                    .Join(db.tb_produto, x => x.e.fk_produto, p => p.id_produto, (x, p) => new { x.x.nfs, x.x.rg, p })
                    .Select(x => new
                    {
                        x.nfs.nfs_numero_nf_saida,
                        x.nfs.nfs_data_emissao,
                        x.nfs.nfs_quantidade,
                        x.nfs.nfs_valor_pago,
                        x.nfs.nfs_valor_juros,
                        x.nfs.nfs_valor_desconto,
                        x.nfs.nfs_vendedor,
                        x.nfs.nfs_tipo_pagamento,
                        rg_nome = x.rg.rg_nome,
                        pd_codigo = x.p.pd_codigo,
                        pd_nome = x.p.pd_nome
                    })
                    .Where(x => x.nfs_data_emissao <= dataFinal && x.nfs_data_emissao >= dataInicial).ToList();

                    decimal valorTotal = 0;

                    foreach (var item in result)
                    {
                        DateTime data = item.nfs_data_emissao;
                        string cliente = item.rg_nome;
                        string produto = item.pd_nome;
                        string codigoProduto = item.pd_codigo;
                        int numeroNF = item.nfs_numero_nf_saida;
                        string vendedor = item.nfs_vendedor;
                        decimal quantidade = item.nfs_quantidade;
                        decimal valorPago = item.nfs_valor_pago;
                        string valorJuros = Convert.ToDecimal(item.nfs_valor_juros).ToString("C2");
                        string valorDesconto = Convert.ToDecimal(item.nfs_valor_desconto).ToString("C2");
                        string tipoPagamento = item.nfs_tipo_pagamento;

                        dt.Rows.Add(data, cliente, produto, codigoProduto, numeroNF, vendedor, quantidade, valorPago.ToString("C2"),
                            valorJuros, valorDesconto, tipoPagamento);

                        valorTotal += valorPago;
                    }

                    lblValorTotal.Text = valorTotal.ToString("C2");
                }

                gridControl1.DataSource = dt;
                gridControl1.Refresh();
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Historico de Vendas - Relatorio - Historico de Venda | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarHistoricoDeVenda(x);
            }
        }

        private void frmHistoricoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtCalendario_Click(object sender, EventArgs e)
        {
            FechandoTela();

            ExibirCalendario();
        }
    }
}