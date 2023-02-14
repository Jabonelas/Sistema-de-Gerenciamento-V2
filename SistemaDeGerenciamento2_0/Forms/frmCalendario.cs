using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
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
    public partial class frmCalendario : DevExpress.XtraEditors.XtraForm
    {
        private frmFaturamentoPorDia frmFaturamentoPorDia;

        private Dictionary<string, string> Datas = new Dictionary<string, string>();

        public frmCalendario(frmFaturamentoPorDia _frmFaturamentoPorDia)
        {
            InitializeComponent();

            frmFaturamentoPorDia = _frmFaturamentoPorDia;

            PreencherEsteMes();

            Datas.ForEach(x => { txtDataInicial.Text = x.Key; txtDataFinal.Text = x.Value; });

            frmFaturamentoPorDia.IsCalendarioAberto = true;
        }

        private frmHistoricoVenda frmHistoricoVenda;

        public frmCalendario(frmHistoricoVenda _frmHistoricoVenda)
        {
            InitializeComponent();

            frmHistoricoVenda = _frmHistoricoVenda;

            PreencherEsteMes();

            Datas.ForEach(x => { txtDataInicial.Text = x.Key; txtDataFinal.Text = x.Value; });

            //frmHistoricoVenda.IsCalendarioAberto = true;
        }

        private frmIndicadorVenda frmIndicadorVenda;

        public frmCalendario(frmIndicadorVenda _frmIndicadorVenda)
        {
            InitializeComponent();

            frmIndicadorVenda = _frmIndicadorVenda;

            PreencherEsteMes();

            Datas.ForEach(x => { txtDataInicial.Text = x.Key; txtDataFinal.Text = x.Value; });

            //frmHistoricoVenda.IsCalendarioAberto = true;
        }

        private frmFaturamentoPorVendedor frmFaturamentoPorVendedor;

        public frmCalendario(frmFaturamentoPorVendedor _frmFaturamentoPorVendedor)
        {
            InitializeComponent();

            frmFaturamentoPorVendedor = _frmFaturamentoPorVendedor;

            PreencherEsteMes();

            Datas.ForEach(x => { txtDataInicial.Text = x.Key; txtDataFinal.Text = x.Value; });

            frmFaturamentoPorVendedor.IsCalendarioAberto = true;
        }

        private void PreencherHoje()
        {
            Datas.Clear();

            DateTime hoje = DateTime.Today;

            Datas.Add(hoje.ToShortDateString(), hoje.ToShortDateString());
        }

        private void PreencherOntem()
        {
            Datas.Clear();

            DateTime ontem = DateTime.Today.AddDays(-1);

            Datas.Add(ontem.ToShortDateString(), ontem.ToShortDateString());
        }

        private void PreencherUltimos7Dias()
        {
            Datas.Clear();

            DateTime inicio7Dias = DateTime.Today.AddDays(-7);
            DateTime final7Dias = DateTime.Today;

            Datas.Add(inicio7Dias.ToShortDateString(), final7Dias.ToShortDateString());
        }

        private void PreencherUltimos30Dias()
        {
            Datas.Clear();

            DateTime inicio30Dias = DateTime.Today.AddDays(-30);
            DateTime final30Dias = DateTime.Today;

            Datas.Add(inicio30Dias.ToShortDateString(), final30Dias.ToShortDateString());
        }

        private void PreencherEsteMes()
        {
            Datas.Clear();

            DateTime inicioDoMes = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime finalDoMes = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            Datas.Add(inicioDoMes.ToShortDateString(), finalDoMes.ToShortDateString());

            dtDataInicial.EditValue = inicioDoMes;
            dtDataFinal.EditValue = finalDoMes;
        }

        private void PreencherProximoMes()
        {
            Datas.Clear();

            DateTime hoje = DateTime.Today;

            DateTime InicioDoMes = new DateTime(hoje.Year, hoje.Month, 1).AddMonths(1);
            DateTime FinalDoMes = new DateTime(InicioDoMes.Year, InicioDoMes.Month, DateTime.DaysInMonth(InicioDoMes.Year, InicioDoMes.Month));

            Datas.Add(InicioDoMes.ToShortDateString(), FinalDoMes.ToShortDateString());
        }

        private void AplicarBusca()
        {
            try
            {
                if (frmFaturamentoPorDia != null)
                {
                    frmFaturamentoPorDia.dataInicial = Convert.ToDateTime(txtDataInicial.Text);
                    frmFaturamentoPorDia.dataFinal = Convert.ToDateTime(txtDataFinal.Text);

                    frmFaturamentoPorDia.IsPreencherGrid = true;

                    frmFaturamentoPorDia.txtCalendario.Text = $"{txtDataInicial.Text} - {txtDataFinal.Text}";
                    frmFaturamentoPorDia.btnCalendario.Focus();

                    Datas.ForEach(x => { frmFaturamentoPorDia.txtCalendario.Text = $"{x.Key} - {x.Value}"; });

                    this.Close();
                }
                else if (frmHistoricoVenda != null)
                {
                    frmHistoricoVenda.dataInicial = Convert.ToDateTime(txtDataInicial.Text);
                    frmHistoricoVenda.dataFinal = Convert.ToDateTime(txtDataFinal.Text);

                    frmHistoricoVenda.IsPreencherGrid = true;

                    frmHistoricoVenda.txtCalendario.Text = $"{txtDataInicial.Text} - {txtDataFinal.Text}";
                    frmHistoricoVenda.btnCalendario.Focus();

                    Datas.ForEach(x => { frmHistoricoVenda.txtCalendario.Text = $"{x.Key} - {x.Value}"; });

                    this.Close();
                }
                else if (frmIndicadorVenda != null && frmIndicadorVenda.solicitacao == "Qtd")
                {
                    //Datas.ForEach(x => { frmIndicadorVenda.txtCalendario.Text = $"{x.Key} - {x.Value}"; });
                    frmIndicadorVenda.txtCalendarioQtd.Text = ($"{txtDataInicial.Text} - {txtDataFinal.Text}");

                    frmIndicadorVenda.dataInicial = Convert.ToDateTime(txtDataInicial.Text);
                    frmIndicadorVenda.dataFinal = Convert.ToDateTime(txtDataFinal.Text);
                    frmIndicadorVenda.chartControl1.Focus();

                    this.Close();
                }
                else if (frmIndicadorVenda != null && frmIndicadorVenda.solicitacao == "Vlr")
                {
                    //Datas.ForEach(x => { frmIndicadorVenda.txtCalendario.Text = $"{x.Key} - {x.Value}"; });
                    frmIndicadorVenda.txtCalendarioVlr.Text = ($"{txtDataInicial.Text} - {txtDataFinal.Text}");

                    frmIndicadorVenda.dataInicial = Convert.ToDateTime(txtDataInicial.Text);
                    frmIndicadorVenda.dataFinal = Convert.ToDateTime(txtDataFinal.Text);
                    frmIndicadorVenda.chartControl2.Focus();

                    this.Close();
                }
                else if (frmFaturamentoPorVendedor != null)
                {
                    frmFaturamentoPorVendedor.dataInicial = Convert.ToDateTime(txtDataInicial.Text);
                    frmFaturamentoPorVendedor.dataFinal = Convert.ToDateTime(txtDataFinal.Text);

                    frmFaturamentoPorVendedor.IsPreencherGrid = true;

                    frmFaturamentoPorVendedor.txtCalendario.Text = $"{txtDataInicial.Text} - {txtDataFinal.Text}";
                    frmFaturamentoPorVendedor.btnCalendario.Focus();

                    Datas.ForEach(x => { frmFaturamentoPorVendedor.txtCalendario.Text = $"{x.Key} - {x.Value}"; });

                    this.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnHoje_Click_1(object sender, EventArgs e)
        {
            PreencherHoje();

            AplicarBusca();
        }

        private void btnHoje_MouseEnter_1(object sender, EventArgs e)
        {
            PreencherHoje();

            Datas.ForEach(x => { txtDataInicial.Text = x.Key; txtDataFinal.Text = x.Value; });
        }

        private void btnOntem_Click_1(object sender, EventArgs e)
        {
            PreencherOntem();

            AplicarBusca();
        }

        private void btnOntem_MouseEnter_1(object sender, EventArgs e)
        {
            PreencherOntem();

            Datas.ForEach(x => { txtDataInicial.Text = x.Key; txtDataFinal.Text = x.Value; });
        }

        private void btnUltimos7Dias_Click_1(object sender, EventArgs e)
        {
            PreencherUltimos7Dias();

            AplicarBusca();
        }

        private void btnUltimos7Dias_MouseEnter_1(object sender, EventArgs e)
        {
            PreencherUltimos7Dias();

            Datas.ForEach(x => { txtDataInicial.Text = x.Key; txtDataFinal.Text = x.Value; });
        }

        private void btnUltimos30Dias_Click_1(object sender, EventArgs e)
        {
            PreencherUltimos30Dias();

            AplicarBusca();
        }

        private void btnUltimos30Dias_MouseEnter_1(object sender, EventArgs e)
        {
            PreencherUltimos30Dias();

            Datas.ForEach(x => { txtDataInicial.Text = x.Key; txtDataFinal.Text = x.Value; });
        }

        private void btnEsteMes_Click_1(object sender, EventArgs e)
        {
            PreencherEsteMes();

            AplicarBusca();
        }

        private void btnEsteMes_MouseEnter_1(object sender, EventArgs e)
        {
            PreencherEsteMes();

            Datas.ForEach(x => { txtDataInicial.Text = x.Key; txtDataFinal.Text = x.Value; });
        }

        private void btnProximoMes_Click_1(object sender, EventArgs e)
        {
            PreencherProximoMes();

            AplicarBusca();
        }

        private void btnProximoMes_MouseEnter_1(object sender, EventArgs e)
        {
            PreencherProximoMes();

            Datas.ForEach(x => { txtDataInicial.Text = x.Key; txtDataFinal.Text = x.Value; });
        }

        private void btnAplicar_Click_1(object sender, EventArgs e)
        {
            AplicarBusca();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private DateTime dataInicalSelecionada = DateTime.Today;
        private DateTime dataFinalSelecionada = DateTime.Today;

        private void dtDataInicial_Click(object sender, EventArgs e)
        {
            dataInicalSelecionada = dtDataInicial.SelectionStart;

            txtDataInicial.Text = dataInicalSelecionada.ToShortDateString();
        }

        private void dtDataFinal_Click(object sender, EventArgs e)
        {
            dataFinalSelecionada = dtDataFinal.SelectionStart;

            txtDataFinal.Text = dataFinalSelecionada.ToShortDateString();

            if (dataFinalSelecionada > dataInicalSelecionada)
            {
                MensagemAtencao.MensagemDataFinalMaiorQueDataInicial();

                dtDataFinal.Focus();
            }
        }
    }
}