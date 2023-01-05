using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
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

        private void frmDespesas_Load(object sender, EventArgs e)
        {
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.MenuType == GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                // Delete existing menu items, if any.
                e.Menu.Items.Clear();
                // Add the Rows submenu with the 'Delete Row' command
                e.Menu.Items.Add(CreateSubMenuRows(view, rowHandle));
                // Add the 'Cell Merging' check menu item.
                DXMenuItem item = CreateMenuItemCellMerging(view, rowHandle);
                item.BeginGroup = true;
                e.Menu.Items.Add(item);
            }
        }

        private DXMenuItem CreateSubMenuRows(GridView view, int rowHandle)
        {
            DXSubMenuItem subMenu = new DXSubMenuItem("Propriedade");
            string deleteRowsCommandCaption;
            if (view.IsGroupRow(rowHandle))
            {
                deleteRowsCommandCaption = "&Delete rows in this group";
            }
            else
                deleteRowsCommandCaption = "&Modificar";
            DXMenuItem menuItemDeleteRow = new DXMenuItem(deleteRowsCommandCaption, new EventHandler(OnDeleteRowClick), Resources.update_left_rotation_20px);
            menuItemDeleteRow.Tag = new RowInfo(view, rowHandle);
            menuItemDeleteRow.Enabled = view.IsDataRow(rowHandle) || view.IsGroupRow(rowHandle);
            subMenu.Items.Add(menuItemDeleteRow);
            return subMenu;
        }

        private DXMenuCheckItem CreateMenuItemCellMerging(GridView view, int rowHandle)
        {
            DXMenuCheckItem checkItem = new DXMenuCheckItem("Juntar &Celulas",
              view.OptionsView.AllowCellMerge, null, new EventHandler(OnCellMergingClick));
            checkItem.Tag = new RowInfo(view, rowHandle);
            checkItem.ImageOptions.Image = Resources.agrupar_20;
            return checkItem;
        }

        private void OnDeleteRowClick(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            RowInfo ri = menuItem.Tag as RowInfo;
            if (ri != null)
            {
                string message = menuItem.Caption.Replace("&", string.Empty);
                if (XtraMessageBox.Show("Deseja Alterar Dados?", "Alterar Dados", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idDespesa = PegandoDadosDaLinha();

                    frmCadastroCategoriaDespesa frmCadastroCategoriaDespesa = new frmCadastroCategoriaDespesa(idDespesa, frmTelaPrincipal);
                    frmCadastroCategoriaDespesa.ShowDialog();
                }
                else
                {
                    return;
                }
                ri.View.DeleteRow(ri.RowHandle);
            }
        }

        private int PegandoDadosDaLinha()
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();

            int idConfiguracaoFinanceira = Convert.ToInt32(gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns[0]));

            return idConfiguracaoFinanceira;
        }

        private void OnCellMergingClick(object sender, EventArgs e)
        {
            DXMenuCheckItem item = sender as DXMenuCheckItem;
            RowInfo info = item.Tag as RowInfo;
            info.View.OptionsView.AllowCellMerge = item.Checked;
        }

        private class RowInfo
        {
            public RowInfo(GridView view, int rowHandle)
            {
                this.RowHandle = rowHandle;
                this.View = view;
            }

            public GridView View;
            public int RowHandle;
        }
    }
}