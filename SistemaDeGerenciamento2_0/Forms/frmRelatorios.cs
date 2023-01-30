using DevExpress.XtraBars;
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

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmRelatorios : DevExpress.XtraEditors.XtraForm
    {
        private frmTelaPrincipal frmTelaPrincipal;

        public frmRelatorios(frmTelaPrincipal _frmTelaPrincipal)
        {
            frmTelaPrincipal = _frmTelaPrincipal;
            InitializeComponent();
        }

        private void btnIndicadoresVendas_Click(object sender, EventArgs e)
        {
            frmIndicadorVenda frmIndicadorVenda = new frmIndicadorVenda(frmTelaPrincipal);
            frmIndicadorVenda.ShowDialog();
        }

        private void btnFaturamentoPorVendedor_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void TeladeFaturamentoPorDia()
        {
            pnlRelotorios.Controls.Clear();
            frmFaturamentoPorDia frmFaturamentoPorDia = new frmFaturamentoPorDia();
            frmFaturamentoPorDia.TopLevel = false;
            pnlRelotorios.Controls.Add(frmFaturamentoPorDia);
            pnlRelotorios.Tag = frmFaturamentoPorDia;
            frmFaturamentoPorDia.Show();
        }

        private void btnFaturamentoPorDia_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmFaturamentoPorDia frmFaturamentoPorDia = new frmFaturamentoPorDia();
            frmFaturamentoPorDia.ShowDialog();

            //TeladeFaturamentoPorDia();
        }
    }
}