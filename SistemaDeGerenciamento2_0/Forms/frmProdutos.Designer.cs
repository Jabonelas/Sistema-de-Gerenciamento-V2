namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
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
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdicionarGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpd_nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_codigo_barras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgp_nome_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_custo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_margem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_preco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnAlterar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeletar = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.AlertaSalvar = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(225, 20);
            this.labelControl3.TabIndex = 98;
            this.labelControl3.Text = "Consultar Produtos Cadastrados";
            // 
            // btnAdicionarGrupo
            // 
            this.btnAdicionarGrupo.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarGrupo.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarGrupo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarGrupo.Appearance.Options.UseBorderColor = true;
            this.btnAdicionarGrupo.Appearance.Options.UseFont = true;
            this.btnAdicionarGrupo.AppearanceDisabled.BackColor = System.Drawing.Color.Yellow;
            this.btnAdicionarGrupo.AppearanceDisabled.BackColor2 = System.Drawing.Color.Yellow;
            this.btnAdicionarGrupo.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAdicionarGrupo.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.btnAdicionarGrupo.AppearanceHovered.BackColor2 = System.Drawing.Color.Red;
            this.btnAdicionarGrupo.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdicionarGrupo.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarGrupo.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarGrupo.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarGrupo.AppearancePressed.Options.UseBackColor = true;
            this.btnAdicionarGrupo.AppearancePressed.Options.UseBorderColor = true;
            this.btnAdicionarGrupo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarGrupo.ImageOptions.Image")));
            this.btnAdicionarGrupo.ImageOptions.ImageIndex = 5;
            this.btnAdicionarGrupo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnAdicionarGrupo.ImageOptions.ImageToTextIndent = 10;
            this.btnAdicionarGrupo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdicionarGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdicionarGrupo.Location = new System.Drawing.Point(19, 93);
            this.btnAdicionarGrupo.Name = "btnAdicionarGrupo";
            this.btnAdicionarGrupo.Size = new System.Drawing.Size(217, 30);
            this.btnAdicionarGrupo.TabIndex = 100;
            this.btnAdicionarGrupo.Text = "Adicionar Novo Produto";
            this.btnAdicionarGrupo.Click += new System.EventHandler(this.btnAdicionarGrupo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnFechar.Appearance.Options.UseBorderColor = true;
            this.btnFechar.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnFechar.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.ImageOptions.Image")));
            this.btnFechar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFechar.Location = new System.Drawing.Point(1121, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 94;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-14, 28);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(215, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 95;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-184, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1512, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 291;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 15);
            this.labelControl1.TabIndex = 292;
            this.labelControl1.Text = "Adicionar Produto:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-184, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1517, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 293;
            this.pictureBox2.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.queryBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(25, 172);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1101, 324);
            this.gridControl1.TabIndex = 294;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SistemaDeGerenciamento2_0ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "pd_nome";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"363\" />";
            table1.Name = "tb_produto";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "pd_codigo";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "pd_codigo_barras";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "gp_nome_grupo";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"123\" />";
            table2.Name = "tb_grupo";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "pd_custo";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "pd_margem";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "pd_preco";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Name = "Query";
            relationColumnInfo1.NestedKeyColumn = "id_grupo";
            relationColumnInfo1.ParentKeyColumn = "fk_grupo";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpd_nome,
            this.colpd_codigo,
            this.colpd_codigo_barras,
            this.colgp_nome_grupo,
            this.colpd_custo,
            this.colpd_margem,
            this.colpd_preco});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            // 
            // colpd_nome
            // 
            this.colpd_nome.AppearanceCell.Options.UseTextOptions = true;
            this.colpd_nome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_nome.AppearanceHeader.Options.UseTextOptions = true;
            this.colpd_nome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_nome.Caption = "Nome";
            this.colpd_nome.FieldName = "pd_nome";
            this.colpd_nome.Name = "colpd_nome";
            this.colpd_nome.Visible = true;
            this.colpd_nome.VisibleIndex = 0;
            // 
            // colpd_codigo
            // 
            this.colpd_codigo.AppearanceCell.Options.UseTextOptions = true;
            this.colpd_codigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_codigo.AppearanceHeader.Options.UseTextOptions = true;
            this.colpd_codigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_codigo.Caption = "Código Produto";
            this.colpd_codigo.FieldName = "pd_codigo";
            this.colpd_codigo.Name = "colpd_codigo";
            this.colpd_codigo.Visible = true;
            this.colpd_codigo.VisibleIndex = 1;
            // 
            // colpd_codigo_barras
            // 
            this.colpd_codigo_barras.AppearanceCell.Options.UseTextOptions = true;
            this.colpd_codigo_barras.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_codigo_barras.AppearanceHeader.Options.UseTextOptions = true;
            this.colpd_codigo_barras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_codigo_barras.Caption = "Código de Barras";
            this.colpd_codigo_barras.FieldName = "pd_codigo_barras";
            this.colpd_codigo_barras.Name = "colpd_codigo_barras";
            this.colpd_codigo_barras.Visible = true;
            this.colpd_codigo_barras.VisibleIndex = 2;
            // 
            // colgp_nome_grupo
            // 
            this.colgp_nome_grupo.AppearanceCell.Options.UseTextOptions = true;
            this.colgp_nome_grupo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgp_nome_grupo.AppearanceHeader.Options.UseTextOptions = true;
            this.colgp_nome_grupo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgp_nome_grupo.Caption = "Grupo";
            this.colgp_nome_grupo.FieldName = "gp_nome_grupo";
            this.colgp_nome_grupo.Name = "colgp_nome_grupo";
            this.colgp_nome_grupo.Visible = true;
            this.colgp_nome_grupo.VisibleIndex = 3;
            // 
            // colpd_custo
            // 
            this.colpd_custo.AppearanceCell.Options.UseTextOptions = true;
            this.colpd_custo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_custo.AppearanceHeader.Options.UseTextOptions = true;
            this.colpd_custo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_custo.Caption = "Custo Produto";
            this.colpd_custo.DisplayFormat.FormatString = "C2";
            this.colpd_custo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpd_custo.FieldName = "pd_custo";
            this.colpd_custo.Name = "colpd_custo";
            this.colpd_custo.Visible = true;
            this.colpd_custo.VisibleIndex = 4;
            // 
            // colpd_margem
            // 
            this.colpd_margem.AppearanceCell.Options.UseTextOptions = true;
            this.colpd_margem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_margem.AppearanceHeader.Options.UseTextOptions = true;
            this.colpd_margem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_margem.Caption = "Margem de Lucro";
            this.colpd_margem.DisplayFormat.FormatString = "{0:.00}%";
            this.colpd_margem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colpd_margem.FieldName = "pd_margem";
            this.colpd_margem.Name = "colpd_margem";
            this.colpd_margem.Visible = true;
            this.colpd_margem.VisibleIndex = 5;
            // 
            // colpd_preco
            // 
            this.colpd_preco.AppearanceCell.Options.UseTextOptions = true;
            this.colpd_preco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_preco.AppearanceHeader.Options.UseTextOptions = true;
            this.colpd_preco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_preco.Caption = "Preço";
            this.colpd_preco.DisplayFormat.FormatString = "C2";
            this.colpd_preco.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpd_preco.FieldName = "pd_preco";
            this.colpd_preco.Name = "colpd_preco";
            this.colpd_preco.Visible = true;
            this.colpd_preco.VisibleIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Appearance.Options.UseFont = true;
            this.btnSair.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.ImageOptions.Image")));
            this.btnSair.ImageOptions.ImageIndex = 5;
            this.btnSair.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnSair.ImageOptions.ImageToTextIndent = 10;
            this.btnSair.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(1013, 506);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(113, 30);
            this.btnSair.TabIndex = 295;
            this.btnSair.Text = "Sair (Esc)";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAlterar,
            this.btnDeletar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1147, 67);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 519);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1147, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 67);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 452);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1147, 67);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 452);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Caption = "Alterar";
            this.btnAlterar.Id = 0;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAlterar_ItemClick);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Caption = "Deletar";
            this.btnDeletar.Id = 1;
            this.btnDeletar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.ImageOptions.Image")));
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeletar_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAlterar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeletar)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(19, 137);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(173, 15);
            this.labelControl16.TabIndex = 290;
            this.labelControl16.Text = "Todos os Produtos Cadastrados:";
            // 
            // AlertaSalvar
            // 
            this.AlertaSalvar.AppearanceCaption.BackColor = System.Drawing.Color.Red;
            this.AlertaSalvar.AppearanceCaption.BackColor2 = System.Drawing.Color.Yellow;
            this.AlertaSalvar.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertaSalvar.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.AlertaSalvar.AppearanceCaption.Options.UseBackColor = true;
            this.AlertaSalvar.AppearanceCaption.Options.UseFont = true;
            this.AlertaSalvar.AppearanceCaption.Options.UseForeColor = true;
            this.AlertaSalvar.AppearanceHotTrackedText.BackColor = System.Drawing.Color.Lime;
            this.AlertaSalvar.AppearanceHotTrackedText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertaSalvar.AppearanceHotTrackedText.Options.UseBackColor = true;
            this.AlertaSalvar.AppearanceHotTrackedText.Options.UseFont = true;
            this.AlertaSalvar.AppearanceText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertaSalvar.AppearanceText.Options.UseFont = true;
            this.AlertaSalvar.AutoFormDelay = 2000;
            this.AlertaSalvar.ShowCloseButton = false;
            this.AlertaSalvar.ShowPinButton = false;
            this.AlertaSalvar.ShowToolTips = false;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 546);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.btnAdicionarGrupo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProdutos_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmProdutos_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProdutos_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarGrupo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_nome;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_codigo_barras;
        private DevExpress.XtraGrid.Columns.GridColumn colgp_nome_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_custo;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_margem;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_preco;
        private DevExpress.XtraEditors.SimpleButton btnSair;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAlterar;
        private DevExpress.XtraBars.BarButtonItem btnDeletar;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraBars.Alerter.AlertControl AlertaSalvar;
    }
}