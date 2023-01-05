namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmDespesas
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesas));
            this.btnNovaDespesa = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_categoria_despesa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cd_categoria_agrupadora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cd_categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cd_tipo_custo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // btnNovaDespesa
            // 
            this.btnNovaDespesa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaDespesa.Appearance.Options.UseFont = true;
            this.btnNovaDespesa.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.reserve_15px;
            this.btnNovaDespesa.ImageOptions.ImageIndex = 5;
            this.btnNovaDespesa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnNovaDespesa.ImageOptions.ImageToTextIndent = 10;
            this.btnNovaDespesa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNovaDespesa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNovaDespesa.Location = new System.Drawing.Point(19, 93);
            this.btnNovaDespesa.Name = "btnNovaDespesa";
            this.btnNovaDespesa.Size = new System.Drawing.Size(179, 30);
            this.btnNovaDespesa.TabIndex = 20;
            this.btnNovaDespesa.Text = "Nova Despesa";
            this.btnNovaDespesa.Click += new System.EventHandler(this.btnNovaDespesa_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "tb_cadastro_despesa";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(23, 174);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(920, 364);
            this.gridControl1.TabIndex = 295;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SistemaDeGerenciamento2_0ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "id_categoria_despesa";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"143\" />";
            table1.Name = "tb_cadastro_despesa";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "cd_categoria_agrupadora";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "cd_tipo_custo";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "cd_categoria";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Name = "tb_cadastro_despesa";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_categoria_despesa,
            this.cd_categoria_agrupadora,
            this.cd_categoria,
            this.cd_tipo_custo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            // 
            // id_categoria_despesa
            // 
            this.id_categoria_despesa.AppearanceCell.Options.UseTextOptions = true;
            this.id_categoria_despesa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id_categoria_despesa.AppearanceHeader.Options.UseTextOptions = true;
            this.id_categoria_despesa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id_categoria_despesa.Caption = "ID";
            this.id_categoria_despesa.FieldName = "id_categoria_despesa";
            this.id_categoria_despesa.Name = "id_categoria_despesa";
            this.id_categoria_despesa.Visible = true;
            this.id_categoria_despesa.VisibleIndex = 0;
            // 
            // cd_categoria_agrupadora
            // 
            this.cd_categoria_agrupadora.AppearanceCell.Options.UseTextOptions = true;
            this.cd_categoria_agrupadora.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cd_categoria_agrupadora.AppearanceHeader.Options.UseTextOptions = true;
            this.cd_categoria_agrupadora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cd_categoria_agrupadora.Caption = "Categoria Agrupadora";
            this.cd_categoria_agrupadora.FieldName = "cd_categoria_agrupadora";
            this.cd_categoria_agrupadora.Name = "cd_categoria_agrupadora";
            this.cd_categoria_agrupadora.Visible = true;
            this.cd_categoria_agrupadora.VisibleIndex = 1;
            // 
            // cd_categoria
            // 
            this.cd_categoria.AppearanceCell.Options.UseTextOptions = true;
            this.cd_categoria.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cd_categoria.AppearanceHeader.Options.UseTextOptions = true;
            this.cd_categoria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cd_categoria.Caption = "Categoria";
            this.cd_categoria.FieldName = "cd_categoria";
            this.cd_categoria.Name = "cd_categoria";
            this.cd_categoria.Visible = true;
            this.cd_categoria.VisibleIndex = 2;
            // 
            // cd_tipo_custo
            // 
            this.cd_tipo_custo.AppearanceCell.Options.UseTextOptions = true;
            this.cd_tipo_custo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cd_tipo_custo.AppearanceHeader.Options.UseTextOptions = true;
            this.cd_tipo_custo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cd_tipo_custo.Caption = "Custo";
            this.cd_tipo_custo.FieldName = "cd_tipo_custo";
            this.cd_tipo_custo.Name = "cd_tipo_custo";
            this.cd_tipo_custo.Visible = true;
            this.cd_tipo_custo.VisibleIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 20);
            this.labelControl3.TabIndex = 297;
            this.labelControl3.Text = "Consultar Produtos";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-14, 28);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(215, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 296;
            this.pictureBox6.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 15);
            this.labelControl1.TabIndex = 298;
            this.labelControl1.Text = "Adicionar Produto:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox2.Location = new System.Drawing.Point(-155, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1270, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 299;
            this.pictureBox2.TabStop = false;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(19, 137);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(104, 15);
            this.labelControl16.TabIndex = 300;
            this.labelControl16.Text = "Todos os Produtos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox1.Location = new System.Drawing.Point(-156, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1277, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 301;
            this.pictureBox1.TabStop = false;
            // 
            // frmDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 563);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnNovaDespesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDespesas";
            this.Text = "frmDespesas";
            this.Load += new System.EventHandler(this.frmDespesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNovaDespesa;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn id_categoria_despesa;
        private DevExpress.XtraGrid.Columns.GridColumn cd_categoria_agrupadora;
        private DevExpress.XtraGrid.Columns.GridColumn cd_categoria;
        private DevExpress.XtraGrid.Columns.GridColumn cd_tipo_custo;
    }
}