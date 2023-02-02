namespace SistemaDeGerenciamento2_0.Forms
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bandedGridView2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.id_nota_fiscal_saida = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nfs_numero_nf_saida = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nfs_quantidade = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nfs_valor_pago = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nfs_valor_desconto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nfs_valor_total_pago = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl3
            // 
            this.gridControl3.DataMember = "Query";
            this.gridControl3.DataSource = this.sqlDataSource1;
            this.gridControl3.Location = new System.Drawing.Point(28, 16);
            this.gridControl3.MainView = this.bandedGridView2;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(827, 327);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView2});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "update";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "id_nota_fiscal_saida";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"323\" />";
            table1.Name = "tb_nota_fiscal_saida";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "nfs_numero_nf_saida";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "nfs_quantidade";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "nfs_valor_pago";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "nfs_valor_desconto";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "nfs_valor_total_pago";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Name = "Query";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // bandedGridView2
            // 
            this.bandedGridView2.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2});
            this.bandedGridView2.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.id_nota_fiscal_saida,
            this.nfs_numero_nf_saida,
            this.nfs_quantidade,
            this.nfs_valor_pago,
            this.nfs_valor_desconto,
            this.nfs_valor_total_pago});
            this.bandedGridView2.GridControl = this.gridControl3;
            this.bandedGridView2.Name = "bandedGridView2";
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "gridBand2";
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 0;
            // 
            // id_nota_fiscal_saida
            // 
            this.id_nota_fiscal_saida.Caption = "id_nota_fiscal_saida";
            this.id_nota_fiscal_saida.FieldName = "id_nota_fiscal_saida";
            this.id_nota_fiscal_saida.Name = "id_nota_fiscal_saida";
            this.id_nota_fiscal_saida.Visible = true;
            // 
            // nfs_numero_nf_saida
            // 
            this.nfs_numero_nf_saida.Caption = "nfs_numero_nf_saida";
            this.nfs_numero_nf_saida.FieldName = "nfs_numero_nf_saida";
            this.nfs_numero_nf_saida.Name = "nfs_numero_nf_saida";
            this.nfs_numero_nf_saida.Visible = true;
            // 
            // nfs_quantidade
            // 
            this.nfs_quantidade.Caption = "nfs_quantidade";
            this.nfs_quantidade.FieldName = "nfs_quantidade";
            this.nfs_quantidade.Name = "nfs_quantidade";
            this.nfs_quantidade.Visible = true;
            // 
            // nfs_valor_pago
            // 
            this.nfs_valor_pago.Caption = "nfs_valor_pago";
            this.nfs_valor_pago.FieldName = "nfs_valor_pago";
            this.nfs_valor_pago.Name = "nfs_valor_pago";
            this.nfs_valor_pago.Visible = true;
            // 
            // nfs_valor_desconto
            // 
            this.nfs_valor_desconto.Caption = "nfs_valor_desconto";
            this.nfs_valor_desconto.FieldName = "nfs_valor_desconto";
            this.nfs_valor_desconto.Name = "nfs_valor_desconto";
            this.nfs_valor_desconto.Visible = true;
            // 
            // nfs_valor_total_pago
            // 
            this.nfs_valor_total_pago.Caption = "nfs_valor_total_pago";
            this.nfs_valor_total_pago.FieldName = "nfs_valor_total_pago";
            this.nfs_valor_total_pago.Name = "nfs_valor_total_pago";
            this.nfs_valor_total_pago.Visible = true;
            // 
            // XtraForm1
            // 
            this.ClientSize = new System.Drawing.Size(884, 364);
            this.Controls.Add(this.gridControl3);
            this.Name = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn id_nota_fiscal_saida;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nfs_numero_nf_saida;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nfs_quantidade;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nfs_valor_total_pago;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nfs_valor_pago;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nfs_valor_desconto;
    }
}