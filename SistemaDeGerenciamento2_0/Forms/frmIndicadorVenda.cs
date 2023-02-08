using DevExpress.CodeParser;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Context;
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
    public partial class frmIndicadorVenda : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private int contIndex = 1;

        private frmTelaPrincipal frmTelaPrincipal;

        public frmIndicadorVenda(frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;

            ReloadData();

            //PercorrerListaValorBruto();
            //ColunaProduto1();
            //ColunaProduto2();
            //ColunaProduto3();
            //ColunaProduto4();
            //ColunaProduto5();
        }

        private void ColunaProduto1()
        {
            //string codigoProduto = listaProdutos.FirstOrDefault(x => x.index.Equals(1)).codigoProduto;

            Series series = new Series($"Cód. Produto {codigoProduto1}", ViewType.Bar);
            //Series series = new Series("coluna 1", ViewType.Bar);

            GerarColunaProduto1(series);
        }

        private void ColunaProduto2()
        {
            //string codigoProduto = listaProdutos.FirstOrDefault(x => x.index.Equals(2)).codigoProduto;

            Series series = new Series($"Cód. Produto {codigoProduto2}", ViewType.Bar);
            //Series series = new Series("coluna 2", ViewType.Bar);

            GerarColunaProduto2(series);
        }

        private void ColunaProduto3()
        {
            //string codigoProduto = listaProdutos.FirstOrDefault(x => x.index.Equals(3)).codigoProduto;

            Series series = new Series($"Cód. Produto {codigoProduto3}", ViewType.Bar);
            //Series series = new Series("coluna 3", ViewType.Bar);

            GerarColunaProduto3(series);
        }

        private void ColunaProduto4()
        {
            //string codigoProduto = listaProdutos.FirstOrDefault(x => x.index.Equals(4)).codigoProduto;

            Series series = new Series($"Cód. Produto {codigoProduto4}", ViewType.Bar);
            //Series series = new Series("coluna 4", ViewType.Bar);

            GerarColunaProduto4(series);
        }

        private string codigoProduto1 = string.Empty;
        private string codigoProduto2 = string.Empty;
        private string codigoProduto3 = string.Empty;
        private string codigoProduto4 = string.Empty;
        private string codigoProduto5 = string.Empty;

        private void CodigosProdutos()
        {
            codigoProduto1 = listaProdutos.FirstOrDefault(x => x.index.Equals(1)).codigoProduto;
            codigoProduto2 = listaProdutos.FirstOrDefault(x => x.index.Equals(2)).codigoProduto;
            codigoProduto3 = listaProdutos.FirstOrDefault(x => x.index.Equals(3)).codigoProduto;
            codigoProduto4 = listaProdutos.FirstOrDefault(x => x.index.Equals(4)).codigoProduto;
            codigoProduto5 = listaProdutos.FirstOrDefault(x => x.index.Equals(5)).codigoProduto;
        }

        private void ColunaProduto5()
        {
            //string codigoProduto = listaProdutos.FirstOrDefault(x => x.index.Equals(5)).codigoProduto;

            Series series = new Series($"Cód. Produto {codigoProduto5}", ViewType.Bar);
            //Series series = new Series("coluna 5", ViewType.Bar);

            GerarColunaProduto5(series);
        }

        private void GerarColunaProduto1(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartData1();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaProduto2(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartData2();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaProduto3(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartData3();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaProduto4(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartData4();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaProduto5(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartData5();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private DataTable CreateChartData1()
        {
            DataTable table = new DataTable("Table1");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto1(table);

            return table;
        }

        private DataTable CreateChartData2()
        {
            DataTable table = new DataTable("Table2");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto2(table);

            return table;
        }

        private DataTable CreateChartData3()
        {
            DataTable table = new DataTable("Table3");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto3(table);

            return table;
        }

        private DataTable CreateChartData4()
        {
            DataTable table = new DataTable("Table4");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto4(table);

            return table;
        }

        private DataTable CreateChartData5()
        {
            DataTable table = new DataTable("Table5");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunProduto5(table);

            return table;
        }

        private void DeletarColuna1()
        {
            if (codigoProduto1 != null)
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto {codigoProduto1}");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
            else
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto ");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void DeletarColuna2()
        {
            if (codigoProduto2 != null)
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto {codigoProduto2}");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
            else
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto ");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void DeletarColuna3()
        {
            if (codigoProduto3 != null)
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto {codigoProduto3}");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
            else
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto ");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void DeletarColuna4()
        {
            if (codigoProduto4 != null)
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto {codigoProduto4}");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
            else
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto ");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
        }

        private void DeletarColuna5()
        {
            if (codigoProduto5 != null)
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto {codigoProduto5}");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
            else
            {
                var indeceValorBruto = chartControl1.Series.First(x => x.Name == $"Cód. Produto ");
                chartControl1.Series.Remove((Series)indeceValorBruto);
            }
        }

        public struct DadosProdutos
        {
            public int index { get; set; }
            public string codigoProduto { get; set; }
            public string nomeProduto { get; set; }
            public decimal quantidade { get; set; }
        }

        private List<DadosProdutos> listaProdutos = new List<DadosProdutos>();

        private void PercorrerListaValorBruto()
        {
            try
            {
                SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context();

                var result = db.tb_produto
                    .Join(db.tb_estoque, p => p.id_produto, e => e.fk_produto, (p, e) => new { Produto = p, Estoque = e })
                    .Join(db.tb_nota_fiscal_saida, pe => pe.Estoque.id_estoque, nfs => nfs.fk_estoque, (pe, nfs) => new { ProdutoEstoque = pe, NotaFiscal = nfs })
                    .Where(x => x.NotaFiscal.nfs_data_emissao >= dataInicial && x.NotaFiscal.nfs_data_emissao <= dataFinal)
                    //.Where(x => x.NotaFiscal.nfs_data_emissao.Month == DateTime.Now.Month)
                    .GroupBy(x => new { x.ProdutoEstoque.Produto.pd_codigo, x.ProdutoEstoque.Produto.pd_nome })
                    .Select(x => new
                    {
                        pd_codigo = x.Key.pd_codigo,
                        pd_nome = x.Key.pd_nome,
                        Quantidade = x.Sum(n => n.NotaFiscal.nfs_quantidade)
                    })
                    .OrderByDescending(x => x.Quantidade)
                .Take(5).ToList();

                listaProdutos.Clear();

                foreach (var item in result)
                {
                    listaProdutos.Add(new DadosProdutos { index = contIndex, codigoProduto = item.pd_codigo, nomeProduto = item.pd_nome, quantidade = item.Quantidade });

                    contIndex++;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());

                //LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Dados Relatorio por dia - Relatorio - Faturamento por dia | {x.Message} | {x.StackTrace}");

                //MensagemErros.ErroAoBuscarDadosFaturamentoPorDia(x);
            }
        }

        private void PreencherColunProduto1(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutos)
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

        private void PreencherColunProduto2(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutos)
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

        private void PreencherColunProduto3(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutos)
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

        private void PreencherColunProduto4(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutos)
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

        private void PreencherColunProduto5(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaProdutos)
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

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                sqlDataSource1.FillAsync();
                sqlDataSource2.FillAsync();
                sqlDataSource3.FillAsync();
                sqlDataSource4.FillAsync();

                PercorrerListaValorBruto();

                CodigosProdutos();

                ColunaProduto1();
                ColunaProduto2();
                ColunaProduto3();
                ColunaProduto4();
                ColunaProduto5();
            }
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

        private void txtCalendario_Enter(object sender, EventArgs e)
        {
            ExibirCalendario();
        }

        public DateTime dataInicial = DateTime.Today;
        public DateTime dataFinal = DateTime.Today;

        private frmCalendario frmCalendario;

        private void ExibirCalendario()
        {
            frmCalendario = new frmCalendario(this);
            frmCalendario.StartPosition = FormStartPosition.Manual;
            frmCalendario.Location = new Point(480, 200);
            frmCalendario.Show();
        }

        private void txtCalendario_TextChanged(object sender, EventArgs e)
        {
            //PercorrerListaValorBruto();

            //CodigosProdutos();

            //DeletarColuna1();
            //ColunaProduto1();
            //DeletarColuna2();
            //ColunaProduto2();
            //DeletarColuna3();
            //ColunaProduto3();
            //DeletarColuna4();
            //ColunaProduto4();
            //DeletarColuna5();
            //ColunaProduto5();
        }

        private void txtCalendario_Leave(object sender, EventArgs e)
        {
            //CodigosProdutos();

            DeletarColuna1();
            DeletarColuna2();
            DeletarColuna3();
            DeletarColuna4();
            DeletarColuna5();

            PercorrerListaValorBruto();

            CodigosProdutos();

            ColunaProduto1();
            ColunaProduto2();
            ColunaProduto3();
            ColunaProduto4();
            ColunaProduto5();
        }
    }
}