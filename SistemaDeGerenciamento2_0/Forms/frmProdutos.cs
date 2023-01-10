using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmProdutos : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;
        public string codigoProduto = string.Empty;

        private frmTelaPrincipal frmTelaPrincipal;

        private PermissoesUsuario permissoesUsuario = new PermissoesUsuario();

        public frmProdutos(frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            frmTelaPrincipal = _frmTelaPrincipal;
            sqlDataSource1.FillAsync();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarGrupo_Click(object sender, EventArgs e)
        {
            permissoesUsuario.ReloadData(frmTelaPrincipal);
            permissoesUsuario.VerificarAcessoCadastroProduto();
        }

        private void frmProdutos_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmProdutos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmProdutos_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReloadDataAlterar();
        }

        private void btnDeletar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Deletar");
        }

        private void ReloadDataAlterar()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(this))
            {
                permissoesUsuario.BuscarPermissoesUsuario();

                PegandoDadosDaLinha();

                permissoesUsuario.VerificarAcessoEditarProduto(codigoProduto);
            }
        }

        private void PegandoDadosDaLinha()
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();

            codigoProduto = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns[1]).ToString();
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
    }
}