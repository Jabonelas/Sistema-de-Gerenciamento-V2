using DevExpress.Utils.Extensions;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
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

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmVisaoGeral : DevExpress.XtraEditors.XtraForm
    {
        private string codigoProduto1Qtd = string.Empty;
        private string codigoProduto2Qtd = string.Empty;
        private string codigoProduto3Qtd = string.Empty;
        private string codigoProduto4Qtd = string.Empty;
        private string codigoProduto5Qtd = string.Empty;

        private DateTime dataInicial = DateTime.Today;
        private DateTime dataFinal = DateTime.Today;
        private DateTime anoAtual = DateTime.Today;

        private List<DadosNFSaida> listaNFSaida = new List<DadosNFSaida>();
        private List<DadosDespesa> listaDespesa = new List<DadosDespesa>();

        public frmVisaoGeral()
        {
            InitializeComponent();

            BuscarDadosNotaFiscalSaida();
            ColunaVenda();

            BuscarDadosDespesa();
            ColunaDespesa();

            BuscarDadosDespesa1();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColunaVenda()
        {
            if (codigoProduto1Qtd != null)
            {
                Series series = new Series("Venda", ViewType.Bar);

                GerarColunaProdutoVenda(series);
            }
        }

        private void GerarColunaProdutoVenda(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartDataVenda();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private DataTable CreateChartDataVenda()
        {
            DataTable table = new DataTable("Table1");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunaVenda(table);

            return table;
        }

        private void PreencherColunaVenda(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaNFSaida)
            {
                string mes = item.mes;
                decimal valor = item.valor;

                row = table.NewRow();
                row["Argument"] = mes;
                row["Value"] = valor;
                table.Rows.Add(row);
            }
        }

        private void BuscarDadosNotaFiscalSaida()
        {
            try
            {
                SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context();

                var result = db.tb_nota_fiscal_saida.GroupBy(d => new { Month = d.nfs_data_emissao.Month, Year = d.nfs_data_emissao.Year })
                                       .Select(g => new
                                       {
                                           Mes = g.Key.Month,
                                           Ano = g.Key.Year,
                                           Total = g.Sum(d => d.nfs_valor_pago)
                                       })
                                       .OrderBy(g => g.Mes).ToList();

                listaNFSaida.Clear();

                foreach (var item in result)
                {
                    if (item.Ano == anoAtual.Year)
                    {
                        string mes = ConverterMes(item.Mes);

                        listaNFSaida.Add(new DadosNFSaida { mes = mes, valor = Convert.ToDecimal(item.Total) });
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Valores Nota Fical Saida - Visão Geral - Visão Geral | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarValoresNFSaida(x);
            }
        }

        private string ConverterMes(int _mes)
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

        public struct DadosNFSaida
        {
            public decimal valor { get; set; }
            public string mes { get; set; }
        }

        public struct DadosDespesa
        {
            public decimal valor { get; set; }
            public string mes { get; set; }
        }

        private void ColunaDespesa()
        {
            if (codigoProduto1Qtd != null)
            {
                Series series = new Series("Despesa", ViewType.Bar);

                GerarColunaDespesa(series);
            }
        }

        private void GerarColunaDespesa(Series series)
        {
            chartControl1.Series.Add(series);
            series.DataSource = CreateChartDataDespesa();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private DataTable CreateChartDataDespesa()
        {
            DataTable table = new DataTable("Table1");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PreencherColunaDespesa(table);

            return table;
        }

        private void PreencherColunaDespesa(DataTable table)
        {
            DataRow row = null;

            foreach (var item in listaDespesa)
            {
                decimal valor = item.valor;
                string mes = item.mes;

                row = table.NewRow();
                row["Argument"] = mes;
                row["Value"] = valor;
                table.Rows.Add(row);
            }
        }

        private void BuscarDadosDespesa()
        {
            try
            {
                SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context();

                var result = db.tb_despesa.GroupBy(d => new { Month = d.dp_vencimento.Month, Year = d.dp_vencimento.Year })
                                       .Select(g => new
                                       {
                                           Mes = g.Key.Month,
                                           Ano = g.Key.Year,
                                           Total = g.Sum(d => d.dp_sub_valor_total)
                                       })
                                       .OrderBy(g => g.Mes).ToList();

                listaDespesa.Clear();

                foreach (var item in result)
                {
                    if (item.Ano == anoAtual.Year)
                    {
                        string mes = ConverterMes(item.Mes);
                        listaDespesa.Add(new DadosDespesa { mes = mes, valor = Convert.ToDecimal(item.Total) });
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Valor de Despesas - Visão Geral - Visão Geral | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarValoresDespesa(x);
            }
        }

        private void BuscarDadosDespesa1()
        {
            try
            {
                SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context();

                var result = db.tb_despesa.GroupBy(x => x.dp_vencimento.Date.AddDays(-(int)x.dp_vencimento.DayOfWeek))
                              .Select(g => new
                              {
                                  Semana = g.Key,
                                  Total = g.Sum(x => x.dp_sub_valor_total)
                              }).ToList();

                //var result = db.tb_despesa.GroupBy(d => new { Month = d.dp_vencimento.Month, Year = d.dp_vencimento.Year, Week = d.dp_vencimento.we })
                //                       .Select(g => new
                //                       {
                //                           Mes = g.Key.Month,
                //                           Ano = g.Key.Year,
                //                           Total = g.Sum(d => d.dp_sub_valor_total)
                //                       })
                //                       .OrderBy(g => g.Mes).ToList();

                listaDespesa.Clear();

                foreach (var item in result)
                {
                    //if (item.Ano == anoAtual.Year)
                    //{
                    string mes = ConverterMes(Convert.ToInt32(item.Semana));
                    listaDespesa.Add(new DadosDespesa { mes = mes, valor = Convert.ToDecimal(item.Total) });
                    //}
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Valor de Despesas - Visão Geral - Visão Geral | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarValoresDespesa(x);
            }
        }
    }
}