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
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnGerarExecel = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscarProduto = new DevExpress.XtraEditors.SimpleButton();
            this.btnLimparFiltro = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdicionarGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.cmbFinalidade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtBuscarProduto = new DevExpress.XtraEditors.TextEdit();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cmbMaisOpacoes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Produto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_codigo_barras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgp_nome_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_tipo_unidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_custo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_margem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_preco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colep_quantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_estoque_minimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colep_data_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinalidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscarProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaisOpacoes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            this.gridSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 20);
            this.labelControl3.TabIndex = 98;
            this.labelControl3.Text = "Consultar Produtos";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(514, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 20);
            this.labelControl7.TabIndex = 99;
            this.labelControl7.Text = "Tipo Produto:";
            // 
            // btnGerarExecel
            // 
            this.btnGerarExecel.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnGerarExecel.Appearance.Options.UseBorderColor = true;
            this.btnGerarExecel.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnGerarExecel.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnGerarExecel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGerarExecel.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.tabela;
            this.btnGerarExecel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnGerarExecel.Location = new System.Drawing.Point(1098, 82);
            this.btnGerarExecel.Name = "btnGerarExecel";
            this.btnGerarExecel.Size = new System.Drawing.Size(26, 26);
            this.btnGerarExecel.TabIndex = 105;
            this.btnGerarExecel.ToolTip = "Exportar para Execel";
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnBuscarProduto.Appearance.Options.UseBorderColor = true;
            this.btnBuscarProduto.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnBuscarProduto.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnBuscarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarProduto.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.lupa_preta;
            this.btnBuscarProduto.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscarProduto.Location = new System.Drawing.Point(316, 130);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(26, 26);
            this.btnBuscarProduto.TabIndex = 104;
            this.btnBuscarProduto.ToolTip = "Pesquisar";
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnLimparFiltro.Appearance.Options.UseBorderColor = true;
            this.btnLimparFiltro.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnLimparFiltro.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnLimparFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparFiltro.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.limpar_preto;
            this.btnLimparFiltro.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLimparFiltro.Location = new System.Drawing.Point(348, 130);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(26, 26);
            this.btnLimparFiltro.TabIndex = 103;
            this.btnLimparFiltro.ToolTip = "Limpar Filtro";
            this.btnLimparFiltro.Click += new System.EventHandler(this.simpleButton2_Click);
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
            this.btnAdicionarGrupo.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.adcao9;
            this.btnAdicionarGrupo.ImageOptions.ImageIndex = 5;
            this.btnAdicionarGrupo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnAdicionarGrupo.ImageOptions.ImageToTextIndent = 10;
            this.btnAdicionarGrupo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdicionarGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdicionarGrupo.Location = new System.Drawing.Point(12, 77);
            this.btnAdicionarGrupo.Name = "btnAdicionarGrupo";
            this.btnAdicionarGrupo.Size = new System.Drawing.Size(217, 30);
            this.btnAdicionarGrupo.TabIndex = 100;
            this.btnAdicionarGrupo.Text = "Adicionar Novo Produto";
            // 
            // cmbFinalidade
            // 
            this.cmbFinalidade.Location = new System.Drawing.Point(432, 130);
            this.cmbFinalidade.Name = "cmbFinalidade";
            this.cmbFinalidade.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFinalidade.Properties.Appearance.Options.UseFont = true;
            this.cmbFinalidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFinalidade.Properties.Items.AddRange(new object[] {
            "Todos os produtos",
            "Estoque positivo",
            "Estoque baixo (menor que o mínimo)",
            "Estoque zaro ou negativo"});
            this.cmbFinalidade.Size = new System.Drawing.Size(259, 26);
            this.cmbFinalidade.TabIndex = 97;
            // 
            // txtBuscarProduto
            // 
            this.txtBuscarProduto.EditValue = "Buscar Produto";
            this.txtBuscarProduto.Location = new System.Drawing.Point(12, 130);
            this.txtBuscarProduto.Name = "txtBuscarProduto";
            this.txtBuscarProduto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProduto.Properties.Appearance.Options.UseFont = true;
            this.txtBuscarProduto.Properties.MaxLength = 20;
            this.txtBuscarProduto.Size = new System.Drawing.Size(298, 26);
            this.txtBuscarProduto.TabIndex = 96;
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
            this.btnFechar.Location = new System.Drawing.Point(1137, -2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 94;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-182, 38);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1517, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 95;
            this.pictureBox6.TabStop = false;
            // 
            // cmbMaisOpacoes
            // 
            this.cmbMaisOpacoes.EditValue = "Mais Opções";
            this.cmbMaisOpacoes.Location = new System.Drawing.Point(251, 74);
            this.cmbMaisOpacoes.Name = "cmbMaisOpacoes";
            this.cmbMaisOpacoes.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaisOpacoes.Properties.Appearance.Options.UseFont = true;
            this.cmbMaisOpacoes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMaisOpacoes.Properties.Items.AddRange(new object[] {
            "Todos os produtos",
            "Estoque positivo",
            "Estoque baixo (menor que o mínimo)",
            "Estoque zaro ou negativo"});
            this.cmbMaisOpacoes.Size = new System.Drawing.Size(247, 26);
            this.cmbMaisOpacoes.TabIndex = 106;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "tb_produto";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1137, 200);
            this.gridControl1.TabIndex = 107;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SistemaDeGerenciamento2_0.Properties.Settings.SistemaDeGerenciamento2_0Connection" +
    "String";
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
            columnExpression5.ColumnName = "pd_tipo_unidade";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "pd_custo";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "pd_margem";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "pd_preco";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "ep_quantidade";
            table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"223\" />";
            table3.Name = "tb_estoque";
            columnExpression9.Table = table3;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "pd_estoque_minimo";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "ep_data_entrada";
            columnExpression11.Table = table3;
            column11.Expression = columnExpression11;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Columns.Add(column10);
            selectQuery1.Columns.Add(column11);
            selectQuery1.Name = "tb_produto";
            relationColumnInfo1.NestedKeyColumn = "id_grupo";
            relationColumnInfo1.ParentKeyColumn = "fk_grupo";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            relationColumnInfo2.NestedKeyColumn = "fk_produto";
            relationColumnInfo2.ParentKeyColumn = "id_produto";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table3;
            join2.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table3);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Produto,
            this.colpd_codigo,
            this.colpd_codigo_barras,
            this.colgp_nome_grupo,
            this.colpd_tipo_unidade,
            this.colpd_custo,
            this.colpd_margem,
            this.colpd_preco,
            this.colep_quantidade,
            this.colpd_estoque_minimo,
            this.colep_data_entrada});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Produto
            // 
            this.Produto.FieldName = "pd_nome";
            this.Produto.Name = "Produto";
            this.Produto.Visible = true;
            this.Produto.VisibleIndex = 0;
            // 
            // colpd_codigo
            // 
            this.colpd_codigo.FieldName = "pd_codigo";
            this.colpd_codigo.Name = "colpd_codigo";
            this.colpd_codigo.Visible = true;
            this.colpd_codigo.VisibleIndex = 1;
            // 
            // colpd_codigo_barras
            // 
            this.colpd_codigo_barras.FieldName = "pd_codigo_barras";
            this.colpd_codigo_barras.Name = "colpd_codigo_barras";
            this.colpd_codigo_barras.Visible = true;
            this.colpd_codigo_barras.VisibleIndex = 2;
            // 
            // colgp_nome_grupo
            // 
            this.colgp_nome_grupo.FieldName = "gp_nome_grupo";
            this.colgp_nome_grupo.Name = "colgp_nome_grupo";
            this.colgp_nome_grupo.Visible = true;
            this.colgp_nome_grupo.VisibleIndex = 3;
            // 
            // colpd_tipo_unidade
            // 
            this.colpd_tipo_unidade.FieldName = "pd_tipo_unidade";
            this.colpd_tipo_unidade.Name = "colpd_tipo_unidade";
            this.colpd_tipo_unidade.Visible = true;
            this.colpd_tipo_unidade.VisibleIndex = 4;
            // 
            // colpd_custo
            // 
            this.colpd_custo.FieldName = "pd_custo";
            this.colpd_custo.Name = "colpd_custo";
            this.colpd_custo.Visible = true;
            this.colpd_custo.VisibleIndex = 5;
            // 
            // colpd_margem
            // 
            this.colpd_margem.FieldName = "pd_margem";
            this.colpd_margem.Name = "colpd_margem";
            this.colpd_margem.Visible = true;
            this.colpd_margem.VisibleIndex = 6;
            // 
            // colpd_preco
            // 
            this.colpd_preco.FieldName = "pd_preco";
            this.colpd_preco.Name = "colpd_preco";
            this.colpd_preco.Visible = true;
            this.colpd_preco.VisibleIndex = 7;
            // 
            // colep_quantidade
            // 
            this.colep_quantidade.FieldName = "ep_quantidade";
            this.colep_quantidade.Name = "colep_quantidade";
            this.colep_quantidade.Visible = true;
            this.colep_quantidade.VisibleIndex = 8;
            // 
            // colpd_estoque_minimo
            // 
            this.colpd_estoque_minimo.FieldName = "pd_estoque_minimo";
            this.colpd_estoque_minimo.Name = "colpd_estoque_minimo";
            this.colpd_estoque_minimo.Visible = true;
            this.colpd_estoque_minimo.VisibleIndex = 9;
            // 
            // colep_data_entrada
            // 
            this.colep_data_entrada.FieldName = "ep_data_entrada";
            this.colep_data_entrada.Name = "colep_data_entrada";
            this.colep_data_entrada.Visible = true;
            this.colep_data_entrada.VisibleIndex = 10;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(12, 186);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // gridSplitContainer1.Panel1
            // 
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1137, 200);
            this.gridSplitContainer1.TabIndex = 107;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 414);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.cmbMaisOpacoes);
            this.Controls.Add(this.btnGerarExecel);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.btnLimparFiltro);
            this.Controls.Add(this.btnAdicionarGrupo);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbFinalidade);
            this.Controls.Add(this.txtBuscarProduto);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProdutos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinalidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscarProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaisOpacoes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            this.gridSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFinalidade;
        private DevExpress.XtraEditors.TextEdit txtBuscarProduto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarGrupo;
        private DevExpress.XtraEditors.SimpleButton btnLimparFiltro;
        private DevExpress.XtraEditors.SimpleButton btnBuscarProduto;
        private DevExpress.XtraEditors.SimpleButton btnGerarExecel;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMaisOpacoes;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Produto;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_codigo_barras;
        private DevExpress.XtraGrid.Columns.GridColumn colgp_nome_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_tipo_unidade;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_custo;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_margem;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_preco;
        private DevExpress.XtraGrid.Columns.GridColumn colep_quantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_estoque_minimo;
        private DevExpress.XtraGrid.Columns.GridColumn colep_data_entrada;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_codigo;
    }
}