namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmConsultarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarEstoque));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpd_nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_codigo_barras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgp_nome_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_custo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_margem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_preco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colep_quantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_tipo_unidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpd_estoque_minimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colep_data_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnfe_quantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(199, 20);
            this.labelControl3.TabIndex = 101;
            this.labelControl3.Text = "Consultar Estoque Produtos ";
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
            this.btnFechar.Location = new System.Drawing.Point(1121, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 99;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-10, 28);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(215, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 100;
            this.pictureBox6.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(23, 76);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1101, 384);
            this.gridControl1.TabIndex = 102;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "update";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
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
            this.colpd_preco,
            this.colep_quantidade,
            this.colpd_tipo_unidade,
            this.colpd_estoque_minimo,
            this.colep_data_entrada,
            this.colnfe_quantidade});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colpd_nome
            // 
            this.colpd_nome.AppearanceCell.Options.UseTextOptions = true;
            this.colpd_nome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_nome.AppearanceHeader.Options.UseTextOptions = true;
            this.colpd_nome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_nome.Caption = "Nome Produto";
            this.colpd_nome.FieldName = "pd_nome";
            this.colpd_nome.Name = "colpd_nome";
            this.colpd_nome.OptionsColumn.AllowEdit = false;
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
            this.colpd_codigo.OptionsColumn.AllowEdit = false;
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
            this.colpd_codigo_barras.OptionsColumn.AllowEdit = false;
            this.colpd_codigo_barras.Visible = true;
            this.colpd_codigo_barras.VisibleIndex = 2;
            // 
            // colgp_nome_grupo
            // 
            this.colgp_nome_grupo.AppearanceCell.Options.UseTextOptions = true;
            this.colgp_nome_grupo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgp_nome_grupo.AppearanceHeader.Options.UseTextOptions = true;
            this.colgp_nome_grupo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgp_nome_grupo.Caption = "Grupo Produto";
            this.colgp_nome_grupo.FieldName = "gp_nome_grupo";
            this.colgp_nome_grupo.Name = "colgp_nome_grupo";
            this.colgp_nome_grupo.OptionsColumn.AllowEdit = false;
            this.colgp_nome_grupo.Visible = true;
            this.colgp_nome_grupo.VisibleIndex = 3;
            // 
            // colpd_custo
            // 
            this.colpd_custo.AppearanceCell.Options.UseTextOptions = true;
            this.colpd_custo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_custo.AppearanceHeader.Options.UseTextOptions = true;
            this.colpd_custo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_custo.Caption = "Custo";
            this.colpd_custo.DisplayFormat.FormatString = "c2";
            this.colpd_custo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpd_custo.FieldName = "pd_custo";
            this.colpd_custo.Name = "colpd_custo";
            this.colpd_custo.OptionsColumn.AllowEdit = false;
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
            this.colpd_margem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpd_margem.FieldName = "pd_margem";
            this.colpd_margem.Name = "colpd_margem";
            this.colpd_margem.OptionsColumn.AllowEdit = false;
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
            this.colpd_preco.DisplayFormat.FormatString = "c2";
            this.colpd_preco.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpd_preco.FieldName = "pd_preco";
            this.colpd_preco.Name = "colpd_preco";
            this.colpd_preco.OptionsColumn.AllowEdit = false;
            this.colpd_preco.Visible = true;
            this.colpd_preco.VisibleIndex = 6;
            // 
            // colep_quantidade
            // 
            this.colep_quantidade.AppearanceCell.Options.UseTextOptions = true;
            this.colep_quantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colep_quantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colep_quantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colep_quantidade.Caption = "Qtd.";
            this.colep_quantidade.DisplayFormat.FormatString = "N";
            this.colep_quantidade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colep_quantidade.FieldName = "ep_quantidade";
            this.colep_quantidade.Name = "colep_quantidade";
            this.colep_quantidade.OptionsColumn.AllowEdit = false;
            this.colep_quantidade.Visible = true;
            this.colep_quantidade.VisibleIndex = 7;
            // 
            // colpd_tipo_unidade
            // 
            this.colpd_tipo_unidade.AppearanceCell.Options.UseTextOptions = true;
            this.colpd_tipo_unidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_tipo_unidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colpd_tipo_unidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_tipo_unidade.Caption = "Und.";
            this.colpd_tipo_unidade.FieldName = "pd_tipo_unidade";
            this.colpd_tipo_unidade.Name = "colpd_tipo_unidade";
            this.colpd_tipo_unidade.OptionsColumn.AllowEdit = false;
            this.colpd_tipo_unidade.Visible = true;
            this.colpd_tipo_unidade.VisibleIndex = 8;
            // 
            // colpd_estoque_minimo
            // 
            this.colpd_estoque_minimo.AppearanceCell.Options.UseTextOptions = true;
            this.colpd_estoque_minimo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_estoque_minimo.AppearanceHeader.Options.UseTextOptions = true;
            this.colpd_estoque_minimo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_estoque_minimo.Caption = "Estoque Mínimo";
            this.colpd_estoque_minimo.FieldName = "pd_estoque_minimo";
            this.colpd_estoque_minimo.Name = "colpd_estoque_minimo";
            this.colpd_estoque_minimo.OptionsColumn.AllowEdit = false;
            this.colpd_estoque_minimo.Visible = true;
            this.colpd_estoque_minimo.VisibleIndex = 9;
            // 
            // colep_data_entrada
            // 
            this.colep_data_entrada.AppearanceCell.Options.UseTextOptions = true;
            this.colep_data_entrada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colep_data_entrada.AppearanceHeader.Options.UseTextOptions = true;
            this.colep_data_entrada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colep_data_entrada.Caption = "Data Entrada";
            this.colep_data_entrada.FieldName = "ep_data_entrada";
            this.colep_data_entrada.Name = "colep_data_entrada";
            this.colep_data_entrada.OptionsColumn.AllowEdit = false;
            this.colep_data_entrada.Visible = true;
            this.colep_data_entrada.VisibleIndex = 10;
            // 
            // colnfe_quantidade
            // 
            this.colnfe_quantidade.AppearanceCell.Options.UseTextOptions = true;
            this.colnfe_quantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnfe_quantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colnfe_quantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnfe_quantidade.Caption = "Qtd. NF";
            this.colnfe_quantidade.FieldName = "nfe_quantidade";
            this.colnfe_quantidade.Name = "colnfe_quantidade";
            this.colnfe_quantidade.OptionsColumn.AllowEdit = false;
            this.colnfe_quantidade.Visible = true;
            this.colnfe_quantidade.VisibleIndex = 11;
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
            this.btnSair.Location = new System.Drawing.Point(1011, 477);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(113, 30);
            this.btnSair.TabIndex = 296;
            this.btnSair.Text = "Sair (Esc)";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmConsultarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 522);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmConsultarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarEstoque";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultarEstoque_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmConsultarEstoque_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmConsultarEstoque_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private System.Windows.Forms.PictureBox pictureBox6;
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
        private DevExpress.XtraGrid.Columns.GridColumn colep_quantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_tipo_unidade;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_estoque_minimo;
        private DevExpress.XtraGrid.Columns.GridColumn colep_data_entrada;
        private DevExpress.XtraGrid.Columns.GridColumn colnfe_quantidade;
        private DevExpress.XtraEditors.SimpleButton btnSair;
    }
}