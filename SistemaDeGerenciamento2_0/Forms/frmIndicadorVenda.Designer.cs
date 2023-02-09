namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmIndicadorVenda
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery9 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndicadorVenda));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery10 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.XtraCharts.Legend legend5 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.ChartTitle chartTitle9 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle10 = new DevExpress.XtraCharts.ChartTitle();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource4 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pd_margem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.btnCalendarioQtd = new DevExpress.XtraEditors.SimpleButton();
            this.txtCalendarioQtd = new DevExpress.XtraEditors.TextEdit();
            this.btnCalendarioVlr = new DevExpress.XtraEditors.SimpleButton();
            this.txtCalendarioVlr = new DevExpress.XtraEditors.TextEdit();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalendarioQtd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalendarioVlr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "Query";
            this.gridControl2.DataSource = this.sqlDataSource4;
            this.gridControl2.Location = new System.Drawing.Point(21, 431);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(602, 200);
            this.gridControl2.TabIndex = 298;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // sqlDataSource4
            // 
            this.sqlDataSource4.ConnectionName = "update";
            this.sqlDataSource4.Name = "sqlDataSource4";
            customSqlQuery9.Name = "Query";
            customSqlQuery9.Sql = "select top 5 pd_codigo, pd_nome,(pd_preco - pd_custo ) as \'valor\' from tb_produto" +
    "\r\n\t  group by pd_codigo, pd_nome, (pd_preco - pd_custo )\r\n\t   ORDER BY \r\n\t   \'va" +
    "lor\' DESC";
            this.sqlDataSource4.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery9});
            this.sqlDataSource4.ResultSchemaSerializable = resources.GetString("sqlDataSource4.ResultSchemaSerializable");
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn9});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Código Produto";
            this.gridColumn1.FieldName = "pd_codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Nome Produto";
            this.gridColumn2.FieldName = "pd_nome";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "Valor Lucro";
            this.gridColumn9.DisplayFormat.FormatString = "C2";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn9.FieldName = "valor";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridControl3
            // 
            this.gridControl3.DataMember = "Query";
            this.gridControl3.DataSource = this.sqlDataSource3;
            this.gridControl3.Location = new System.Drawing.Point(640, 431);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(602, 200);
            this.gridControl3.TabIndex = 299;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "update";
            this.sqlDataSource3.Name = "sqlDataSource3";
            customSqlQuery10.Name = "Query";
            customSqlQuery10.Sql = "select top 5 pd_codigo, pd_nome,pd_margem from tb_produto\r\n\t   group by pd_codigo" +
    ", pd_nome,pd_margem\r\n\t   ORDER BY \r\n\t   pd_margem DESC";
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery10});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn14,
            this.pd_margem});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.OptionsView.ShowIndicator = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.Caption = "Código Produto";
            this.gridColumn12.FieldName = "pd_codigo";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.Caption = "Nome Produto";
            this.gridColumn14.FieldName = "pd_nome";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            // 
            // pd_margem
            // 
            this.pd_margem.AppearanceCell.Options.UseTextOptions = true;
            this.pd_margem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pd_margem.AppearanceHeader.Options.UseTextOptions = true;
            this.pd_margem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pd_margem.Caption = "Margem de Lucro";
            this.pd_margem.DisplayFormat.FormatString = "{0:.00}%";
            this.pd_margem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.pd_margem.FieldName = "pd_margem";
            this.pd_margem.Name = "pd_margem";
            this.pd_margem.Visible = true;
            this.pd_margem.VisibleIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(350, 17);
            this.labelControl3.TabIndex = 301;
            this.labelControl3.Text = "PRODUTOS MAIS VENDIDOS (EM QUANTIDADE) - TOP 5";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-55, 63);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(513, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 302;
            this.pictureBox6.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(640, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(307, 17);
            this.labelControl1.TabIndex = 303;
            this.labelControl1.Text = "PRODUTOS MAIS VENDIDOS (EM VALOR) - TOP 5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox1.Location = new System.Drawing.Point(580, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 304;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(640, 398);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(301, 17);
            this.labelControl4.TabIndex = 305;
            this.labelControl4.Text = "PRODUTO COM MAIOR MARGEM MÉDIA - TOP 5";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox2.Location = new System.Drawing.Point(-55, 415);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(513, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 306;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox3.Location = new System.Drawing.Point(568, 415);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(478, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 308;
            this.pictureBox3.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 398);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(322, 17);
            this.labelControl2.TabIndex = 307;
            this.labelControl2.Text = "PRODUTO COM MAIOR MARGEM DE LUCRO - TOP 5";
            // 
            // btnFechar
            // 
            this.btnFechar.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnFechar.Appearance.Options.UseBorderColor = true;
            this.btnFechar.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnFechar.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.multiply1_20px;
            this.btnFechar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFechar.Location = new System.Drawing.Point(1234, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 309;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(21, 5);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(150, 20);
            this.labelControl13.TabIndex = 311;
            this.labelControl13.Text = "Indicadores de Venda";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox4.Location = new System.Drawing.Point(-42, 14);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(316, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 310;
            this.pictureBox4.TabStop = false;
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            legend5.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            legend5.Name = "Legend 1";
            legend5.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            legend5.Title.Visible = true;
            legend5.Title.WordWrap = true;
            this.chartControl1.Legends.AddRange(new DevExpress.XtraCharts.Legend[] {
            legend5});
            this.chartControl1.Location = new System.Drawing.Point(21, 80);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(602, 282);
            this.chartControl1.TabIndex = 312;
            chartTitle9.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Left;
            chartTitle9.Indent = 6;
            chartTitle9.Text = "Quantidade Produto";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle9});
            // 
            // btnCalendarioQtd
            // 
            this.btnCalendarioQtd.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarioQtd.Appearance.Options.UseFont = true;
            this.btnCalendarioQtd.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.calendar_plus_20px;
            this.btnCalendarioQtd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCalendarioQtd.Location = new System.Drawing.Point(395, 40);
            this.btnCalendarioQtd.Name = "btnCalendarioQtd";
            this.btnCalendarioQtd.Size = new System.Drawing.Size(35, 34);
            this.btnCalendarioQtd.TabIndex = 325;
            this.btnCalendarioQtd.Click += new System.EventHandler(this.btnCalendario_Click);
            this.btnCalendarioQtd.Leave += new System.EventHandler(this.btnCalendarioQtd_Leave);
            // 
            // txtCalendarioQtd
            // 
            this.txtCalendarioQtd.Location = new System.Drawing.Point(437, 40);
            this.txtCalendarioQtd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalendarioQtd.Name = "txtCalendarioQtd";
            this.txtCalendarioQtd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalendarioQtd.Properties.Appearance.Options.UseFont = true;
            this.txtCalendarioQtd.Properties.MaxLength = 14;
            this.txtCalendarioQtd.Properties.ReadOnly = true;
            this.txtCalendarioQtd.Size = new System.Drawing.Size(186, 34);
            this.txtCalendarioQtd.TabIndex = 324;
            this.txtCalendarioQtd.Click += new System.EventHandler(this.txtCalendario_Click);
            this.txtCalendarioQtd.Enter += new System.EventHandler(this.txtCalendario_Enter);
            this.txtCalendarioQtd.Leave += new System.EventHandler(this.txtCalendario_Leave);
            // 
            // btnCalendarioVlr
            // 
            this.btnCalendarioVlr.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarioVlr.Appearance.Options.UseFont = true;
            this.btnCalendarioVlr.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.calendar_plus_20px;
            this.btnCalendarioVlr.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCalendarioVlr.Location = new System.Drawing.Point(1014, 41);
            this.btnCalendarioVlr.Name = "btnCalendarioVlr";
            this.btnCalendarioVlr.Size = new System.Drawing.Size(35, 34);
            this.btnCalendarioVlr.TabIndex = 327;
            this.btnCalendarioVlr.Click += new System.EventHandler(this.btnCalendarioVlr_Click);
            this.btnCalendarioVlr.Leave += new System.EventHandler(this.btnCalendarioVlr_Leave);
            // 
            // txtCalendarioVlr
            // 
            this.txtCalendarioVlr.Location = new System.Drawing.Point(1056, 41);
            this.txtCalendarioVlr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalendarioVlr.Name = "txtCalendarioVlr";
            this.txtCalendarioVlr.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalendarioVlr.Properties.Appearance.Options.UseFont = true;
            this.txtCalendarioVlr.Properties.MaxLength = 14;
            this.txtCalendarioVlr.Properties.ReadOnly = true;
            this.txtCalendarioVlr.Size = new System.Drawing.Size(186, 34);
            this.txtCalendarioVlr.TabIndex = 326;
            this.txtCalendarioVlr.Click += new System.EventHandler(this.txtCalendarioVlr_Click);
            this.txtCalendarioVlr.Enter += new System.EventHandler(this.txtCalendarioVlr_Enter);
            this.txtCalendarioVlr.Leave += new System.EventHandler(this.txtCalendarioVlr_Leave);
            // 
            // chartControl2
            // 
            this.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl2.Location = new System.Drawing.Point(640, 80);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(602, 282);
            this.chartControl2.TabIndex = 328;
            chartTitle10.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Left;
            chartTitle10.Indent = 6;
            chartTitle10.Text = "Valores Venda R$";
            this.chartControl2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle10});
            // 
            // frmIndicadorVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 656);
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.btnCalendarioVlr);
            this.Controls.Add(this.txtCalendarioVlr);
            this.Controls.Add(this.btnCalendarioQtd);
            this.Controls.Add(this.txtCalendarioQtd);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmIndicadorVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.frmIndicadorVenda_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIndicadorVenda_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmIndicadorVenda_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmIndicadorVenda_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalendarioQtd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalendarioVlr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn pd_margem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.PictureBox pictureBox4;
        public DevExpress.XtraEditors.SimpleButton btnCalendarioQtd;
        public DevExpress.XtraEditors.TextEdit txtCalendarioQtd;
        public DevExpress.XtraCharts.ChartControl chartControl1;
        public DevExpress.XtraEditors.SimpleButton btnCalendarioVlr;
        public DevExpress.XtraEditors.TextEdit txtCalendarioVlr;
        public DevExpress.XtraCharts.ChartControl chartControl2;
    }
}