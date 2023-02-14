using DevExpress.Utils.Extensions;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaDeGerenciamento2_0.Forms.frmIndicadorVenda;
using static SistemaDeGerenciamento2_0.Forms.frmVisaoGeral;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmVisaoGeral : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;
        private int anoAtual = DateTime.Today.Year;

        private decimal valorTotalAnual = 0;
        private decimal despesaTotalAnual = 0;
        private decimal valorTotalSemanal = 0;
        private decimal despesaTotalSemanal = 0;

        private List<DadosAnual> listaNFSaidaAnual = new List<DadosAnual>();
        private List<DadosAnual> listaDespesaAnual = new List<DadosAnual>();

        private List<DadosSemanal> listaNFSaidaSemanal = new List<DadosSemanal>();
        private List<DadosSemanal> listaDespesaSemanal = new List<DadosSemanal>();

        private frmTelaPrincipal frmTelaPrincipal;

        public frmVisaoGeral(frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            //PreencherComboBoxMes();

            frmTelaPrincipal = _frmTelaPrincipal;

            ReloadData();
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                PreencherComboBoxMes();

                DateTime mesAtual = DateTime.Today;

                //cmbMes.Properties.ValueMember = mesAtual.Month.ToString();
                //cmbMes.Text = ConverterMesPorExtenso(mesAtual.Month);

                //cmbAno.Text = anoAtual.ToString();
            }
        }

        private void PreencherComboBoxMes()
        {
            Dictionary<int, string> listaMes = new Dictionary<int, string>();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Mes");

            dt.Rows.Add(new string[] { "1", "Janeiro" });
            dt.Rows.Add(new string[] { "2", "Fevereiro" });
            dt.Rows.Add(new string[] { "3", "Março" });
            dt.Rows.Add(new string[] { "4", "Abril" });
            dt.Rows.Add(new string[] { "5", "Maio" });
            dt.Rows.Add(new string[] { "6", "Junho" });
            dt.Rows.Add(new string[] { "7", "Julho" });
            dt.Rows.Add(new string[] { "8", "Agosto" });
            dt.Rows.Add(new string[] { "9", "Setembro" });
            dt.Rows.Add(new string[] { "10", "Outubro" });
            dt.Rows.Add(new string[] { "11", "Novembro" });
            dt.Rows.Add(new string[] { "12", "Dezembro" });

            cmbMes.Properties.DataSource = dt;
            cmbMes.Properties.DisplayMember = "Mes";
            cmbMes.Properties.ValueMember = "ID";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColunaVendaAnual()
        {
            Series series = new Series("Venda", ViewType.Bar);

            GerarColunaProdutoVendaAnual(series);
        }

        private void GerarColunaProdutoVendaAnual(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartDataVendaAnual();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private DataTable CreateChartDataVendaAnual()
        {
            DataTable table = new DataTable("Table1");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunaVendaAnual(table);

            return table;
        }

        private void PreencherColunaVendaAnual(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaNFSaidaAnual)
            {
                string mes = item.mes;
                decimal valor = item.valor;

                row = table.NewRow();
                row["Argument"] = mes;
                row["Value"] = valor;
                table.Rows.Add(row);
            }
        }

        private void BuscarDadosNotaFiscalSaidaAnual()
        {
            try
            {
                SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context();

                var result = db.tb_nota_fiscal_saida.GroupBy(d => new { Month = d.nfs_data_emissao.Month, Year = d.nfs_data_emissao.Year })
                    .Where(x => x.Key.Year == anoAtual)
                                       .Select(g => new
                                       {
                                           Mes = g.Key.Month,
                                           Ano = g.Key.Year,
                                           Total = g.Sum(d => d.nfs_valor_pago)
                                       })
                                       .OrderBy(g => g.Mes).ToList();

                valorTotalAnual = 0;

                listaNFSaidaAnual.Clear();

                foreach (var item in result)
                {
                    if (item.Ano == anoAtual)
                    {
                        string mes = ConverterMesPorExtenso(item.Mes);

                        listaNFSaidaAnual.Add(new DadosAnual { mes = mes, valor = Convert.ToDecimal(item.Total) });

                        valorTotalAnual += item.Total;
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Valores Nota Fical Saida Anual - Visão Geral - Visão Geral | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarValoresNFSaidaAnual(x);
            }
        }

        private string ConverterMesPorExtenso(int _mes)
        {
            switch (_mes)
            {
                case 1:

                    return "Janeiro";

                case 2:

                    return "Fevereiro";

                case 3:

                    return "Março";

                case 4:

                    return "Abril";

                case 5:

                    return "Março";

                case 6:

                    return "Junho";

                case 7:

                    return "Julho";

                case 8:

                    return "Agosto";

                case 9:

                    return "Setembro";

                case 10:

                    return "Outubro";

                case 11:

                    return "Novembro";

                case 12:

                    return "Dezembro";
            }

            return string.Empty;
        }

        public struct DadosAnual
        {
            public decimal valor { get; set; }
            public string mes { get; set; }
        }

        public struct DadosSemanal
        {
            public decimal valor { get; set; }
            public string semana { get; set; }
        }

        private void ColunaDespesaAnual()
        {
            Series series = new Series("Despesa", ViewType.Bar);

            GerarColunaDespesaAnual(series);
        }

        private void GerarColunaDespesaAnual(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartDataDespesaAnual();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private DataTable CreateChartDataDespesaAnual()
        {
            DataTable table = new DataTable("Table1");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunaDespesaAnual(table);

            return table;
        }

        private void PreencherColunaDespesaAnual(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaDespesaAnual)
            {
                string mes = item.mes;
                decimal valor = item.valor;

                row = table.NewRow();
                row["Argument"] = mes;
                row["Value"] = valor;
                table.Rows.Add(row);
            }
        }

        private void BuscarDadosDespesaAnual()
        {
            try
            {
                SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context();

                var result = db.tb_despesa.GroupBy(d => new { Month = d.dp_vencimento.Value.Month, Year = d.dp_vencimento.Value.Year })
                    .Where(x => x.Key.Year == anoAtual)
                    .Select(g => new
                    {
                        Mes = g.Key.Month,
                        Ano = g.Key.Year,
                        Total = g.Sum(d => d.dp_sub_valor_total)
                    })
                                       .OrderBy(g => g.Mes).ToList();

                despesaTotalAnual = 0;

                listaDespesaAnual.Clear();

                foreach (var item in result)
                {
                    if (item.Ano == anoAtual)
                    {
                        string mes = ConverterMesPorExtenso(item.Mes);

                        listaDespesaAnual.Add(new DadosAnual { mes = mes, valor = Convert.ToDecimal(item.Total) });

                        despesaTotalAnual += item.Total;
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Valor de Despesas Anual - Visão Geral - Visão Geral | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarValoresDespesaAnual(x);
            }
        }

        private void ColunaDespesaSemanal()
        {
            Series series = new Series("Despesa", ViewType.Bar);

            GerarColunaDespesaSemanal(series);
        }

        private void GerarColunaDespesaSemanal(Series series)
        {
            chartControl2.Series.Add(series);
            series.DataSource = CreateChartDataDespesaSemanal();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private DataTable CreateChartDataDespesaSemanal()
        {
            DataTable table = new DataTable("Table1");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunaDespesaSemanal(table);

            return table;
        }

        private void PreencherColunaDespesaSemanal(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaDespesaSemanal)
            {
                decimal valor = item.valor;
                string semana = item.semana;

                row = table.NewRow();
                row["Argument"] = semana;
                row["Value"] = valor;
                table.Rows.Add(row);
            }
        }

        private void BuscarDadosDespesaSemanal()
        {
            try
            {
                var mes = cmbMes.Properties.GetKeyValueByDisplayValue(cmbMes.Text);

                SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context();

                var result = db.tb_despesa
                .Where(x => x.dp_vencimento.Value.Month == Convert.ToInt32(mes) && x.dp_vencimento.Value.Year == anoAtual)
                .GroupBy(x => x.dp_vencimento.Value.Year * 100 + x.dp_vencimento.Value.DayOfYear / 7)
                .Select(g => new
                {
                    Semana = g.Key,
                    ValorTotal = g.Sum(x => x.dp_sub_valor_total)
                })
                .OrderBy(x => x.Semana).ToList();

                despesaTotalSemanal = 0;

                listaDespesaSemanal.Clear();

                foreach (var item in result)
                {
                    int numeroSemana = item.Semana - (2023 * 100);

                    string semana = $"Semana: {numeroSemana}";

                    listaDespesaSemanal.Add(new DadosSemanal { semana = semana, valor = Convert.ToDecimal(item.ValorTotal) });

                    despesaTotalSemanal += item.ValorTotal;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());

                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Valor de Despesas Semanal - Visão Geral - Visão Geral | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarValoresNFSaidaSemanal(x);
            }
        }

        private void ColunaVendaSemanal()
        {
            Series series = new Series("Venda", ViewType.Bar);

            GerarColunaProdutoVendaSemanal(series);
        }

        private void GerarColunaProdutoVendaSemanal(Series series)
        {
            chartControl2.Series.Add(series);
            series.DataSource = CreateChartDataVendaSemanal();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private DataTable CreateChartDataVendaSemanal()
        {
            DataTable table = new DataTable("Table1");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunaVendaSemanal(table);

            return table;
        }

        private void PreencherColunaVendaSemanal(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaNFSaidaSemanal)
            {
                string semana = item.semana;
                decimal valor = item.valor;

                row = table.NewRow();
                row["Argument"] = semana;
                row["Value"] = valor;
                table.Rows.Add(row);
            }
        }

        private void BuscarDadosVendaSemanal()
        {
            try
            {
                var mes = cmbMes.Properties.GetKeyValueByDisplayValue(cmbMes.Text);

                SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context();

                var result = db.tb_nota_fiscal_saida
                .Where(x => x.nfs_data_emissao.Month == Convert.ToInt32(mes) && x.nfs_data_emissao.Year == anoAtual)
               .GroupBy(x => x.nfs_data_emissao.Year * 100 + x.nfs_data_emissao.DayOfYear / 7)
               .Select(g => new
               {
                   Semana = g.Key,
                   ValorTotal = g.Sum(x => x.nfs_valor_pago)
               })
            .OrderBy(x => x.Semana).ToList();

                valorTotalSemanal = 0;

                listaNFSaidaSemanal.Clear();

                foreach (var item in result)
                {
                    int numeroSemana = item.Semana - (2023 * 100);

                    string semana = $"Semana: {numeroSemana}";

                    listaNFSaidaSemanal.Add(new DadosSemanal { semana = semana, valor = Convert.ToDecimal(item.ValorTotal) });

                    valorTotalSemanal += item.ValorTotal;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());

                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Valor de Despesas Semanal - Visão Geral - Visão Geral | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarValoresDespesaSemanal(x);
            }
        }

        private void cmbAno_TextChanged(object sender, EventArgs e)
        {
            Anual();

            Mensal();
        }

        private void Anual()
        {
            if (chartControl1.Series.Count != 0)
            {
                DeletarColunaVendaAnual();
                DeletarColunaDespesaAnual();
            }

            anoAtual = Convert.ToInt32(cmbAno.Text);

            BuscarDadosNotaFiscalSaidaAnual();
            ColunaVendaAnual();

            BuscarDadosDespesaAnual();
            ColunaDespesaAnual();

            lblVendaAnual.Text = valorTotalAnual.ToString("C2");
            lblDespesaAnual.Text = despesaTotalAnual.ToString("C2");
        }

        private void DeletarColunaVendaAnual()
        {
            var indeceValorBruto = chartControl1.Series.First(x => x.Name == "Venda");
            chartControl1.Series.Remove((Series)indeceValorBruto);
        }

        private void DeletarColunaDespesaAnual()
        {
            var indeceValorBruto = chartControl1.Series.First(x => x.Name == "Despesa");
            chartControl1.Series.Remove((Series)indeceValorBruto);
        }

        private int cont = 0;

        private void cmbMes_TextChanged(object sender, EventArgs e)
        {
            if (cont != 0)
            {
                Mensal();
            }
            cont++;
        }

        private void Mensal()
        {
            if (chartControl2.Series.Count != 0)
            {
                DeletarColunaVendaSemanal();
                DeletarColunaDespesaSemanal();
            }

            BuscarDadosVendaSemanal();
            ColunaVendaSemanal();

            BuscarDadosDespesaSemanal();
            ColunaDespesaSemanal();

            lblVendaSemanal.Text = valorTotalSemanal.ToString("C2");
            lblDespesaSemanal.Text = despesaTotalSemanal.ToString("C2");
        }

        private void DeletarColunaVendaSemanal()
        {
            var indeceValorBruto = chartControl2.Series.First(x => x.Name == "Venda");
            chartControl2.Series.Remove((Series)indeceValorBruto);
        }

        private void DeletarColunaDespesaSemanal()
        {
            var indeceValorBruto = chartControl2.Series.First(x => x.Name == "Despesa");
            chartControl2.Series.Remove((Series)indeceValorBruto);
        }

        private void frmVisaoGeral_Shown(object sender, EventArgs e)
        {
            //ReloadData();

            DateTime mesAtual = DateTime.Today;

            cmbMes.Text = ConverterMesPorExtenso(mesAtual.Month);

            cmbAno.Text = anoAtual.ToString();
        }

        private void frmVisaoGeral_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmVisaoGeral_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmVisaoGeral_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }
    }
}