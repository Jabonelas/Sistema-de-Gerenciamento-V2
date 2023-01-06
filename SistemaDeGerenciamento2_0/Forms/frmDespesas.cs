using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Properties;
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
    public partial class frmDespesas : DevExpress.XtraEditors.XtraForm
    {
        private frmTelaPrincipal frmTelaPrincipal;

        public frmDespesas(frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;

            ReloadData();
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                AtualizarGrid();
            }
        }

        public void AtualizarGrid()
        {
            sqlDataSource1.Fill();
        }

        private void btnNovaDespesa_Click(object sender, EventArgs e)
        {
            frmCadastroCategoriaDespesa frmCadastroCategoriaDespesa = new frmCadastroCategoriaDespesa();
            frmCadastroCategoriaDespesa.ShowDialog();
        }

        private int rowHandle = 0;

        private GridColumn column;

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRowCell)
            {
                view.FocusedRowHandle = rowHandle = hitInfo.RowHandle;
                column = hitInfo.Column;
                popupMenu1.ShowPopup(barManager1, view.GridControl.PointToScreen(e.Point));
            }
        }

        //private class RowInfo
        //{
        //    public RowInfo(GridView view, int rowHandle)
        //    {
        //        this.RowHandle = rowHandle;
        //        this.View = view;
        //    }

        //    public GridView View;
        //    public int RowHandle;
        //}

        private int PegandoDadosDaLinha()
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();

            int idConfiguracaoFinanceira = Convert.ToInt32(gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns[0]));

            return idConfiguracaoFinanceira;
        }

        private void btnDeletar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Deseja Deletar Despesa?", "Deletar Despesa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ApagarDespesa();
            }
        }

        private void ApagarDespesa()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    int idDespesa = PegandoDadosDaLinha();

                    var dadosDespesa = db.tb_cadastro_despesa.Where(x => x.id_categoria_despesa == idDespesa).First();

                    db.Entry(dadosDespesa).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

                    db.tb_cadastro_despesa.Remove(dadosDespesa);
                    db.SaveChanges();

                    AtualizarGrid();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnAlterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Deseja Alterar Dados?", "Alterar Dados", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idDespesa = PegandoDadosDaLinha();

                frmCadastroCategoriaDespesa frmCadastroCategoriaDespesa = new frmCadastroCategoriaDespesa(idDespesa, frmTelaPrincipal);
                frmCadastroCategoriaDespesa.ShowDialog();

                AtualizarGrid();
            }
        }
    }
}