using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Design;
using DevExpress.XtraGrid.Extensions;
using DevExpress.XtraLayout.Filtering.Templates;
using Microsoft.EntityFrameworkCore.Internal;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using SqlDataSource = DevExpress.DataAccess.Sql.SqlDataSource;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmFaturamentoPorDia : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        public bool IsPreencherGrid = false;

        public DateTime dataInicial = DateTime.Today;
        public DateTime dataFinal = DateTime.Today;

        private DataTable dt = new DataTable();

        private frmCalendario frmCalendario;

        public frmFaturamentoPorDia()
        {
            InitializeComponent();

            PreencherData();

            PreencherGrid();
        }

        private void PreencherData()
        {
            dataInicial = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

            dataFinal = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            txtCalendario.Text = $"{dataInicial.ToShortDateString()} - {dataFinal.ToShortDateString()}";
        }

        private void PreencherGrid()
        {
            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("Data");
            dt.Columns.Add("Dia Semana");
            dt.Columns.Add("Quantidade Total");
            dt.Columns.Add("Valor Total Produto");

            try
            {
                SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context();

                var result = db.tb_nota_fiscal_saida
                    .Where(x => x.nfs_data_emissao >= dataInicial && x.nfs_data_emissao <= dataFinal)
                    .GroupBy(x => x.nfs_data_emissao)
                    .OrderBy(x => x.Key)
                    .Select(g => new
                    {
                        DataEmissao = g.Key,
                        TotalQuantidade = g.Sum(x => x.nfs_quantidade),
                        TotalValorPago = g.Sum(x => x.nfs_valor_pago)
                    });

                decimal valorTotal = 0;
                decimal quantidadeTotal = 0;

                foreach (var item in result)
                {
                    string diaSemana = TraduzindoDiaDaSemana(item.DataEmissao.DayOfWeek.ToString());
                    string data = item.DataEmissao.ToShortDateString();
                    string quantidade = item.TotalQuantidade.ToString("N0");
                    string valor = item.TotalValorPago.ToString("C2");

                    dt.Rows.Add(data, diaSemana, quantidade, valor);

                    valorTotal += item.TotalQuantidade;
                    quantidadeTotal += item.TotalValorPago;
                }

                lblQuantidadeTotal.Text = valorTotal.ToString("N0");
                lblValorTotal.Text = quantidadeTotal.ToString("C2");

                gridControl1.DataSource = dt;
                gridControl1.Refresh();
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Dados Relatorio por dia - Relatorio - Faturamento por dia | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarDadosFaturamentoPorDia(x);
            }
        }

        private string TraduzindoDiaDaSemana(string _dia)
        {
            switch (_dia)
            {
                case "Monday":

                    return "Segunda-Feira";

                case "Tuesday":

                    return "Terça-Feira";

                case "Wednesday":

                    return "Quarta-Feira";

                case "Thursday":

                    return "Quinta-Feira";

                case "Friday":

                    return "Sexta-Feira";

                case "Saturday":

                    return "Sábado";

                case "Sunday":

                    return "Domingo";
            }

            return string.Empty;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFaturamentoPorDia_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmFaturamentoPorDia_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void txtCalendario_Enter(object sender, EventArgs e)
        {
            ExibirCalendario();
        }

        private void txtCalendario_Leave(object sender, EventArgs e)
        {
            FechandoTela();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            ExibirCalendario();
        }

        private void ExibirCalendario()
        {
            string localizacao = txtCalendario.Location.ToString();

            string a = localizacao.Replace("X=", "");
            a = localizacao.Replace("Y=", "");

            frmCalendario = new frmCalendario(this);
            frmCalendario.StartPosition = FormStartPosition.Manual;
            frmCalendario.Location = new Point(a);
            //frmCalendario.Location = new Point(480, 200);
            frmCalendario.Show();
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

        private void frmFaturamentoPorDia_Click(object sender, EventArgs e)
        {
            dataInicial = Convert.ToDateTime(frmCalendario.txtDataInicial.Text);
            dataFinal = Convert.ToDateTime(frmCalendario.txtDataFinal.Text);

            txtCalendario.Text = $"{dataInicial.ToShortDateString()} - {dataFinal.ToShortDateString()}";

            PreencherGrid();

            frmCalendario.Close();

            gridControl1.Focus();
        }
    }
}