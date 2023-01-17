using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmConsultarEstoque : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;

        private int Y = 0;

        public frmConsultarEstoque()
        {
            InitializeComponent();

            sqlDataSource1.FillAsync();

            gridControl1.DoubleClick -= gridControl1_DoubleClick;
        }

        public frmConsultarEstoque(string _tela)
        {
            InitializeComponent();

            sqlDataSource1.FillAsync();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarEstoque_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmConsultarEstoque_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmConsultarEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private frmPDV frmPDV = new frmPDV();

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            string codigoDeBarras = PegandoIndiceDaLinhaDoGrid().ToString();

            frmPDV.passagemDeCodigoDeBarras = codigoDeBarras;

            this.Close();
        }

        private string PegandoIndiceDaLinhaDoGrid()
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();

            string idConfiguracaoFinanceira = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns[2]).ToString();

            return idConfiguracaoFinanceira;
        }
    }
}