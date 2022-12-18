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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column34 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression34 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table10 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column35 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression35 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column36 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression36 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column37 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression37 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table11 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column38 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression38 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column39 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression39 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column40 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression40 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column41 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression41 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column42 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression42 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table12 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column43 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression43 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column44 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression44 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join7 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo7 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join8 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo8 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnGerarExecel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdicionarGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            // btnGerarExecel
            // 
            this.btnGerarExecel.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnGerarExecel.Appearance.Options.UseBorderColor = true;
            this.btnGerarExecel.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnGerarExecel.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnGerarExecel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGerarExecel.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.tabela;
            this.btnGerarExecel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnGerarExecel.Location = new System.Drawing.Point(1105, 73);
            this.btnGerarExecel.Name = "btnGerarExecel";
            this.btnGerarExecel.Size = new System.Drawing.Size(26, 26);
            this.btnGerarExecel.TabIndex = 105;
            this.btnGerarExecel.ToolTip = "Exportar para Execel";
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
            this.btnAdicionarGrupo.Location = new System.Drawing.Point(12, 68);
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
            // gridControl1
            // 
            this.gridControl1.DataMember = "tb_produto";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1137, 288);
            this.gridControl1.TabIndex = 107;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SistemaDeGerenciamento2_0.Properties.Settings.SistemaDeGerenciamento2_0Connection" +
    "String";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression34.ColumnName = "pd_nome";
            table10.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"363\" />";
            table10.Name = "tb_produto";
            columnExpression34.Table = table10;
            column34.Expression = columnExpression34;
            columnExpression35.ColumnName = "pd_codigo";
            columnExpression35.Table = table10;
            column35.Expression = columnExpression35;
            columnExpression36.ColumnName = "pd_codigo_barras";
            columnExpression36.Table = table10;
            column36.Expression = columnExpression36;
            columnExpression37.ColumnName = "gp_nome_grupo";
            table11.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"123\" />";
            table11.Name = "tb_grupo";
            columnExpression37.Table = table11;
            column37.Expression = columnExpression37;
            columnExpression38.ColumnName = "pd_tipo_unidade";
            columnExpression38.Table = table10;
            column38.Expression = columnExpression38;
            columnExpression39.ColumnName = "pd_custo";
            columnExpression39.Table = table10;
            column39.Expression = columnExpression39;
            columnExpression40.ColumnName = "pd_margem";
            columnExpression40.Table = table10;
            column40.Expression = columnExpression40;
            columnExpression41.ColumnName = "pd_preco";
            columnExpression41.Table = table10;
            column41.Expression = columnExpression41;
            columnExpression42.ColumnName = "ep_quantidade";
            table12.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"223\" />";
            table12.Name = "tb_estoque";
            columnExpression42.Table = table12;
            column42.Expression = columnExpression42;
            columnExpression43.ColumnName = "pd_estoque_minimo";
            columnExpression43.Table = table10;
            column43.Expression = columnExpression43;
            columnExpression44.ColumnName = "ep_data_entrada";
            columnExpression44.Table = table12;
            column44.Expression = columnExpression44;
            selectQuery4.Columns.Add(column34);
            selectQuery4.Columns.Add(column35);
            selectQuery4.Columns.Add(column36);
            selectQuery4.Columns.Add(column37);
            selectQuery4.Columns.Add(column38);
            selectQuery4.Columns.Add(column39);
            selectQuery4.Columns.Add(column40);
            selectQuery4.Columns.Add(column41);
            selectQuery4.Columns.Add(column42);
            selectQuery4.Columns.Add(column43);
            selectQuery4.Columns.Add(column44);
            selectQuery4.Name = "tb_produto";
            relationColumnInfo7.NestedKeyColumn = "id_grupo";
            relationColumnInfo7.ParentKeyColumn = "fk_grupo";
            join7.KeyColumns.Add(relationColumnInfo7);
            join7.Nested = table11;
            join7.Parent = table10;
            relationColumnInfo8.NestedKeyColumn = "fk_produto";
            relationColumnInfo8.ParentKeyColumn = "id_produto";
            join8.KeyColumns.Add(relationColumnInfo8);
            join8.Nested = table12;
            join8.Parent = table10;
            selectQuery4.Relations.Add(join7);
            selectQuery4.Relations.Add(join8);
            selectQuery4.Tables.Add(table10);
            selectQuery4.Tables.Add(table11);
            selectQuery4.Tables.Add(table12);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery4});
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
            this.gridSplitContainer1.Location = new System.Drawing.Point(12, 114);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // gridSplitContainer1.Panel1
            // 
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1137, 288);
            this.gridSplitContainer1.TabIndex = 107;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 414);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.btnGerarExecel);
            this.Controls.Add(this.btnAdicionarGrupo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProdutos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarGrupo;
        private DevExpress.XtraEditors.SimpleButton btnGerarExecel;
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