﻿using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
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
        private DataTable dt = new DataTable();

        public frmFaturamentoPorDia()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();

            PreencherDatePicker();

            PreencherGrid();
        }

        private void PreencherDatePicker()
        {
            dtpDataInicial.Text = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).ToShortDateString();

            dtpDataFinal.Text = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month)).ToShortDateString();
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

                DateTime dataInicial = Convert.ToDateTime(dtpDataInicial.Text);
                DateTime dataFinal = Convert.ToDateTime(dtpDataFinal.Text);

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dtpDataFinal.Text != string.Empty && dtpDataInicial.Text != string.Empty)
            {
                PreencherGrid();
            }
        }
    }
}