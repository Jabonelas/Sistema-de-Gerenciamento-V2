using DevExpress.CodeParser;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmIndicadorVenda : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;
        private int contIndexQtd = 1;
        private int contIndexVlr = 1;

        public string solicitacao = string.Empty;
        private string codigoProduto1Qtd = string.Empty;
        private string codigoProduto2Qtd = string.Empty;
        private string codigoProduto3Qtd = string.Empty;
        private string codigoProduto4Qtd = string.Empty;
        private string codigoProduto5Qtd = string.Empty;

        private string codigoProduto1Vlr = string.Empty;
        private string codigoProduto2Vlr = string.Empty;
        private string codigoProduto3Vlr = string.Empty;
        private string codigoProduto4Vlr = string.Empty;
        private string codigoProduto5Vlr = string.Empty;

        public DateTime dataInicial = DateTime.Today;
        public DateTime dataFinal = DateTime.Today;

        private frmCalendario frmCalendario;

        private frmTelaPrincipal frmTelaPrincipal;

        private List<DadosProdutosQuantidade> listaProdutosQtd = new List<DadosProdutosQuantidade>();
        private List<DadosProdutosValor> listaProdutosVlr = new List<DadosProdutosValor>();

        public frmIndicadorVenda(frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;

            ReloadData();
        }

        private void ColunaProduto1Qtd()
        {
            if (codigoProduto1Qtd != null)
            {
                Series series = new Series($"Cód. Produto {codigoProduto1Qtd}", ViewType.Bar);

                GerarColunaProduto1Qtd(series);
            }
        }

        private void ColunaProduto2Qtd()
        {
            if (codigoProduto2Qtd != null)
            {
                Series series = new Series($"Cód. Produto {codigoProduto2Qtd}", ViewType.Bar);

                GerarColunaProduto2Qtd(series);
            }
        }

        private void ColunaProduto3Qtd()
        {
            if (codigoProduto3Qtd != null)
            {
                Series series = new Series($"Cód. Produto {codigoProduto3Qtd}", ViewType.Bar);

                GerarColunaProduto3Qtd(series);
            }
        }

        private void ColunaProduto4Qtd()
        {
            if (codigoProduto4Qtd != null)
            {
                Series series = new Series($"Cód. Produto {codigoProduto4Qtd}", ViewType.Bar);

                GerarColunaProduto4Qtd(series);
            }
        }

        private void CodigosProdutosQtd()
        {
            codigoProduto1Qtd = listaProdutosQtd.FirstOrDefault(x => x.index.Equals(1)).codigoProduto;
            codigoProduto2Qtd = listaProdutosQtd.FirstOrDefault(x => x.index.Equals(2)).codigoProduto;
            codigoProduto3Qtd = listaProdutosQtd.FirstOrDefault(x => x.index.Equals(3)).codigoProduto;
            codigoProduto4Qtd = listaProdutosQtd.FirstOrDefault(x => x.index.Equals(4)).codigoProduto;
            codigoProduto5Qtd = listaProdutosQtd.FirstOrDefault(x => x.index.Equals(5)).codigoProduto;
        }

        private void ColunaProduto5Qtd()
        {
            if (codigoProduto5Qtd != null)
            {
                Series series = new Series($"Cód. Produto {codigoProduto5Qtd}", ViewType.Bar);

                GerarColunaProduto5Qtd(series);
            }
        }

        private void GerarColunaProduto1Qtd(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartData1Qtd();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaProduto2Qtd(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartData2Qtd();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaProduto3Qtd(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartData3Qtd();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaProduto4Qtd(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartData4Qtd();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaProduto5Qtd(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartData5Qtd();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private DataTable CreateChartData1Qtd()
        {
            DataTable table = new DataTable("Table1");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto1Qtd(table);

            return table;
        }

        private DataTable CreateChartData2Qtd()
        {
            DataTable table = new DataTable("Table2");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto2Qtd(table);

            return table;
        }

        private DataTable CreateChartData3Qtd()
        {
            DataTable table = new DataTable("Table3");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto3Qtd(table);

            return table;
        }

        private DataTable CreateChartData4Qtd()
        {
            DataTable table = new DataTable("Table4");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto4Qtd(table);

            return table;
        }

        private DataTable CreateChartData5Qtd()
        {
            DataTable table = new DataTable("Table5");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto5Qtd(table);

            return table;
        }

        private void DeletarColuna1Qtd()
        {
            if (codigoProduto1Qtd != null)
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto {codigoProduto1Qtd}");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void DeletarColuna2Qtd()
        {
            if (codigoProduto2Qtd != null)
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto {codigoProduto2Qtd}");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void DeletarColuna3Qtd()
        {
            if (codigoProduto3Qtd != null)
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto {codigoProduto3Qtd}");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void DeletarColuna4Qtd()
        {
            if (codigoProduto4Qtd != null)
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto {codigoProduto4Qtd}");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void DeletarColuna5Qtd()
        {
            if (codigoProduto5Qtd != null)
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto {codigoProduto5Qtd}");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void PreencherColunProduto1Qtd(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutosQtd)
            {
                if (item.index == 1)
                {
                    string nome = item.nomeProduto;
                    string codigoProduto = item.codigoProduto.ToString();
                    string quantidade = item.quantidade.ToString("N0");

                    row = table.NewRow();
                    row["Argument"] = $"Cód. Produto: {codigoProduto}";
                    row["Value"] = quantidade;
                    table.Rows.Add(row);
                }
            }
        }

        private void PreencherColunProduto2Qtd(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutosQtd)
            {
                if (item.index == 2)
                {
                    string nome = item.nomeProduto;
                    string codigoProduto = item.codigoProduto.ToString();
                    string quantidade = item.quantidade.ToString("N0");

                    row = table.NewRow();
                    row["Argument"] = $"Cód. Produto: {codigoProduto}";
                    row["Value"] = quantidade;
                    table.Rows.Add(row);
                }
            }
        }

        private void PreencherColunProduto3Qtd(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutosQtd)
            {
                if (item.index == 3)
                {
                    string nome = item.nomeProduto;
                    string codigoProduto = item.codigoProduto.ToString();
                    string quantidade = item.quantidade.ToString("N0");

                    row = table.NewRow();
                    row["Argument"] = $"Cód. Produto: {codigoProduto}";
                    row["Value"] = quantidade;
                    table.Rows.Add(row);
                }
            }
        }

        private void PreencherColunProduto4Qtd(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutosQtd)
            {
                if (item.index == 4)
                {
                    string nome = item.nomeProduto;
                    string codigoProduto = item.codigoProduto.ToString();
                    string quantidade = item.quantidade.ToString("N0");

                    row = table.NewRow();
                    row["Argument"] = $"Cód. Produto: {codigoProduto}";
                    row["Value"] = quantidade;
                    table.Rows.Add(row);
                }
            }
        }

        private void PreencherColunProduto5Qtd(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutosQtd)
            {
                if (item.index == 5)
                {
                    string nome = item.nomeProduto;
                    string codigoProduto = item.codigoProduto.ToString();
                    string quantidade = item.quantidade.ToString("N0");

                    row = table.NewRow();
                    row["Argument"] = $"Cód. Produto: {codigoProduto}";
                    row["Value"] = quantidade;
                    table.Rows.Add(row);
                }
            }
        }

        private void ColunaProduto1Vlr()
        {
            if (codigoProduto1Vlr != null)
            {
                Series series = new Series($"Cód. Produto {codigoProduto1Vlr}", ViewType.Bar);

                GerarColunaProduto1Vlr(series);
            }
        }

        private void ColunaProduto2Vlr()
        {
            if (codigoProduto2Vlr != null)
            {
                Series series = new Series($"Cód. Produto {codigoProduto2Vlr}", ViewType.Bar);

                GerarColunaProduto2Vlr(series);
            }
        }

        private void ColunaProduto3Vlr()
        {
            if (codigoProduto3Vlr != null)
            {
                Series series = new Series($"Cód. Produto {codigoProduto3Vlr}", ViewType.Bar);

                GerarColunaProduto3Vlr(series);
            }
        }

        private void ColunaProduto4Vlr()
        {
            if (codigoProduto4Vlr != null)
            {
                Series series = new Series($"Cód. Produto {codigoProduto4Vlr}", ViewType.Bar);

                GerarColunaProduto4Vlr(series);
            }
        }

        private void CodigosProdutosVlr()
        {
            codigoProduto1Vlr = listaProdutosVlr.FirstOrDefault(x => x.index.Equals(1)).codigoProduto;
            codigoProduto2Vlr = listaProdutosVlr.FirstOrDefault(x => x.index.Equals(2)).codigoProduto;
            codigoProduto3Vlr = listaProdutosVlr.FirstOrDefault(x => x.index.Equals(3)).codigoProduto;
            codigoProduto4Vlr = listaProdutosVlr.FirstOrDefault(x => x.index.Equals(4)).codigoProduto;
            codigoProduto5Vlr = listaProdutosVlr.FirstOrDefault(x => x.index.Equals(5)).codigoProduto;
        }

        private void ColunaProduto5Vlr()
        {
            if (codigoProduto5Vlr != null)
            {
                Series series = new Series($"Cód. Produto {codigoProduto5Vlr}", ViewType.Bar);

                GerarColunaProduto5Vlr(series);
            }
        }

        private void GerarColunaProduto1Vlr(Series series)
        {
            chartControl2.Series.Add(series);
            series.DataSource = CreateChartData1Vlr();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaProduto2Vlr(Series series)
        {
            chartControl2.Series.Add(series);
            series.DataSource = CreateChartData2Vlr();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaProduto3Vlr(Series series)
        {
            chartControl2.Series.Add(series);
            series.DataSource = CreateChartData3Vlr();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaProduto4Vlr(Series series)
        {
            chartControl2.Series.Add(series);
            series.DataSource = CreateChartData4Vlr();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaProduto5Vlr(Series series)
        {
            chartControl2.Series.Add(series);
            series.DataSource = CreateChartData5Vlr();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private DataTable CreateChartData1Vlr()
        {
            DataTable table = new DataTable("Table1");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto1Vlr(table);

            return table;
        }

        private DataTable CreateChartData2Vlr()
        {
            DataTable table = new DataTable("Table2");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto2Vlr(table);

            return table;
        }

        private DataTable CreateChartData3Vlr()
        {
            DataTable table = new DataTable("Table3");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto3Vlr(table);

            return table;
        }

        private DataTable CreateChartData4Vlr()
        {
            DataTable table = new DataTable("Table4");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto4Vlr(table);

            return table;
        }

        private DataTable CreateChartData5Vlr()
        {
            DataTable table = new DataTable("Table5");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto5Vlr(table);

            return table;
        }

        private void DeletarColuna1Vlr()
        {
            if (codigoProduto1Vlr != null)
            {
                var indeceValorBruto = chartControl2.Series.First(x => x.Name == $"Cód. Produto {codigoProduto1Vlr}");
                chartControl2.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void DeletarColuna2Vlr()
        {
            if (codigoProduto2Vlr != null)
            {
                var indeceValorBruto = chartControl2.Series.First(x => x.Name == $"Cód. Produto {codigoProduto2Vlr}");
                chartControl2.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void DeletarColuna3Vlr()
        {
            if (codigoProduto3Vlr != null)
            {
                var indeceValorBruto = chartControl2.Series.First(x => x.Name == $"Cód. Produto {codigoProduto3Vlr}");
                chartControl2.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void DeletarColuna4Vlr()
        {
            if (codigoProduto4Vlr != null)
            {
                var indeceValorBruto = chartControl2.Series.First(x => x.Name == $"Cód. Produto {codigoProduto4Vlr}");
                chartControl2.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void DeletarColuna5Vlr()
        {
            if (codigoProduto5Vlr != null)
            {
                var indeceValorBruto = chartControl2.Series.First(x => x.Name == $"Cód. Produto {codigoProduto5Vlr}");
                chartControl2.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void PreencherColunProduto1Vlr(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutosVlr)
            {
                if (item.index == 1)
                {
                    string nome = item.nomeProduto;
                    string codigoProduto = item.codigoProduto.ToString();
                    decimal valor = item.valor;

                    row = table.NewRow();
                    row["Argument"] = $"Cód. Produto: {codigoProduto}";
                    row["Value"] = valor;
                    table.Rows.Add(row);
                }
            }
        }

        private void PreencherColunProduto2Vlr(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutosVlr)
            {
                if (item.index == 2)
                {
                    string nome = item.nomeProduto;
                    string codigoProduto = item.codigoProduto.ToString();
                    decimal valor = item.valor;

                    row = table.NewRow();
                    row["Argument"] = $"Cód. Produto: {codigoProduto}";
                    row["Value"] = valor;
                    table.Rows.Add(row);
                }
            }
        }

        private void PreencherColunProduto3Vlr(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutosVlr)
            {
                if (item.index == 3)
                {
                    string nome = item.nomeProduto;
                    string codigoProduto = item.codigoProduto.ToString();
                    decimal valor = item.valor;

                    row = table.NewRow();
                    row["Argument"] = $"Cód. Produto: {codigoProduto}";
                    row["Value"] = valor;
                    table.Rows.Add(row);
                }
            }
        }

        private void PreencherColunProduto4Vlr(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutosVlr)
            {
                if (item.index == 4)
                {
                    string nome = item.nomeProduto;
                    string codigoProduto = item.codigoProduto.ToString();
                    decimal valor = item.valor;

                    row = table.NewRow();
                    row["Argument"] = $"Cód. Produto: {codigoProduto}";
                    row["Value"] = valor;
                    table.Rows.Add(row);
                }
            }
        }

        private void PreencherColunProduto5Vlr(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutosVlr)
            {
                if (item.index == 5)
                {
                    string nome = item.nomeProduto;
                    string codigoProduto = item.codigoProduto.ToString();
                    decimal valor = item.valor;

                    row = table.NewRow();
                    row["Argument"] = $"Cód. Produto: {codigoProduto}";
                    row["Value"] = valor;
                    table.Rows.Add(row);
                }
            }
        }

        private void BuscarValorProdutosMaisVendidos()
        {
            try
            {
                SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context();

                var result = db.tb_nota_fiscal_saida
                    .Join(db.tb_estoque, nfs => nfs.fk_estoque, est => est.id_estoque, (nfs, est) => new { nfs, est })
                    .Join(db.tb_produto, x => x.est.fk_produto, prod => prod.id_produto, (x, prod) => new { x.nfs, prod })
                     .Where(x => x.nfs.nfs_data_emissao >= dataInicial && x.nfs.nfs_data_emissao <= dataFinal)
                    .GroupBy(x => new { x.prod.pd_codigo, x.prod.pd_nome })
                    .Select(g => new
                    {
                        codigoProduto = g.Key.pd_codigo,
                        nomeProduto = g.Key.pd_nome,
                        Valor = g.Sum(x => x.nfs.nfs_valor_pago)
                    })
                    .OrderByDescending(x => x.Valor)
                    .Take(5)
                    .ToList();

                listaProdutosVlr.Clear();

                contIndexVlr = 1;

                foreach (var item in result)
                {
                    listaProdutosVlr.Add(new DadosProdutosValor { index = contIndexVlr, codigoProduto = item.codigoProduto, nomeProduto = item.nomeProduto, valor = item.Valor });

                    contIndexVlr++;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Valores de Produtos Mais Vendidos no Indicaro de Vendas - Relatorio - Indicaor de Venda | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarValoresProdutosVendidos(x);
            }
        }

        private void BuscarQuantidadeProdutosMaisVendidos()
        {
            try
            {
                SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context();

                var result = db.tb_produto
                    .Join(db.tb_estoque, p => p.id_produto, e => e.fk_produto, (p, e) => new { Produto = p, Estoque = e })
                    .Join(db.tb_nota_fiscal_saida, pe => pe.Estoque.id_estoque, nfs => nfs.fk_estoque, (pe, nfs) => new { ProdutoEstoque = pe, NotaFiscal = nfs })
                    .Where(x => x.NotaFiscal.nfs_data_emissao >= dataInicial && x.NotaFiscal.nfs_data_emissao <= dataFinal)
                    .GroupBy(x => new { x.ProdutoEstoque.Produto.pd_codigo, x.ProdutoEstoque.Produto.pd_nome })
                    .Select(x => new
                    {
                        pd_codigo = x.Key.pd_codigo,
                        pd_nome = x.Key.pd_nome,
                        Quantidade = x.Sum(n => n.NotaFiscal.nfs_quantidade)
                    })
                    .OrderByDescending(x => x.Quantidade)
                    .Take(5).ToList();

                listaProdutosQtd.Clear();

                contIndexQtd = 1;

                foreach (var item in result)
                {
                    listaProdutosQtd.Add(new DadosProdutosQuantidade { index = contIndexQtd, codigoProduto = item.pd_codigo, nomeProduto = item.pd_nome, quantidade = item.Quantidade });

                    contIndexQtd++;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Quantidade de Produtos Mais Vendidos no Indicaro de Vendas - Relatorio - Indicaor de Venda | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarQuantidadeProdutosVendidos(x);
            }
        }

        public struct DadosProdutosQuantidade
        {
            public int index { get; set; }
            public string codigoProduto { get; set; }
            public string nomeProduto { get; set; }
            public decimal quantidade { get; set; }
        }

        public struct DadosProdutosValor
        {
            public int index { get; set; }
            public string codigoProduto { get; set; }
            public string nomeProduto { get; set; }
            public decimal valor { get; set; }
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                sqlDataSource3.FillAsync();
                sqlDataSource4.FillAsync();

                PreencherDataEsteMes();

                PreencherGraficoQuantidadeProdutos();

                PreencherGraficoValorProdutos();
            }
        }

        private void PreencherGraficoQuantidadeProdutos()
        {
            //BuscarProdutosMaisVendidos();

            BuscarQuantidadeProdutosMaisVendidos();

            CodigosProdutosQtd();

            ColunaProduto1Qtd();
            ColunaProduto2Qtd();
            ColunaProduto3Qtd();
            ColunaProduto4Qtd();
            ColunaProduto5Qtd();
        }

        private void PreencherGraficoValorProdutos()
        {
            //BuscarProdutosMaisVendidos();

            BuscarValorProdutosMaisVendidos();

            CodigosProdutosVlr();

            ColunaProduto1Vlr();
            ColunaProduto2Vlr();
            ColunaProduto3Vlr();
            ColunaProduto4Vlr();
            ColunaProduto5Vlr();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIndicadorVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmIndicadorVenda_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmIndicadorVenda_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void PreencherDataEsteMes()
        {
            dataInicial = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dataFinal = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            txtCalendarioQtd.Text = $"{dataInicial.ToShortDateString()} - {dataFinal.ToShortDateString()}";
            txtCalendarioVlr.Text = $"{dataInicial.ToShortDateString()} - {dataFinal.ToShortDateString()}";
        }

        private void ExibirCalendarioQtd()
        {
            solicitacao = "Qtd";

            frmCalendario = new frmCalendario(this);
            frmCalendario.StartPosition = FormStartPosition.Manual;
            frmCalendario.Location = new Point(290, 83);
            frmCalendario.Show();
        }

        private void ExibirCalendarioVlr()
        {
            solicitacao = "Vlr";

            frmCalendario = new frmCalendario(this);
            frmCalendario.StartPosition = FormStartPosition.Manual;
            frmCalendario.Location = new Point(490, 83);
            frmCalendario.Show();
        }

        private void txtCalendario_Enter(object sender, EventArgs e)
        {
            ExibirCalendarioQtd();
        }

        private void txtCalendario_Leave(object sender, EventArgs e)
        {
            DeletarColuna1Qtd();
            DeletarColuna2Qtd();
            DeletarColuna3Qtd();
            DeletarColuna4Qtd();
            DeletarColuna5Qtd();

            PreencherGraficoQuantidadeProdutos();

            FecharTelaCalendario();
        }

        private void txtCalendario_Click(object sender, EventArgs e)
        {
            FecharTelaCalendario();

            ExibirCalendarioQtd();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            FecharTelaCalendario();

            ExibirCalendarioQtd();
        }

        private void FecharTelaCalendario()
        {
            if (frmCalendario != null)
            {
                frmCalendario.Close();
            }
        }

        private void btnCalendarioVlr_Click(object sender, EventArgs e)
        {
            FecharTelaCalendario();

            ExibirCalendarioVlr();
        }

        private void txtCalendarioVlr_Enter(object sender, EventArgs e)
        {
            ExibirCalendarioVlr();
        }

        private void txtCalendarioVlr_Leave(object sender, EventArgs e)
        {
            DeletarColuna1Vlr();
            DeletarColuna2Vlr();
            DeletarColuna3Vlr();
            DeletarColuna4Vlr();
            DeletarColuna5Vlr();

            PreencherGraficoValorProdutos();

            FecharTelaCalendario();
        }

        private void txtCalendarioVlr_Click(object sender, EventArgs e)
        {
            FecharTelaCalendario();

            ExibirCalendarioVlr();
        }

        private void btnCalendarioQtd_Leave(object sender, EventArgs e)
        {
            FecharTelaCalendario();

            DeletarColuna1Qtd();
            DeletarColuna2Qtd();
            DeletarColuna3Qtd();
            DeletarColuna4Qtd();
            DeletarColuna5Qtd();

            PreencherGraficoQuantidadeProdutos();
        }

        private void btnCalendarioVlr_Leave(object sender, EventArgs e)
        {
            DeletarColuna1Vlr();
            DeletarColuna2Vlr();
            DeletarColuna3Vlr();
            DeletarColuna4Vlr();
            DeletarColuna5Vlr();

            PreencherGraficoValorProdutos();

            FecharTelaCalendario();
        }

        private void frmIndicadorVenda_Click(object sender, EventArgs e)
        {
            FecharTelaCalendario();
        }
    }
}