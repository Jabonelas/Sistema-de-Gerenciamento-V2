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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdicionarGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 20);
            this.labelControl3.TabIndex = 98;
            this.labelControl3.Text = "Consultar Produtos";
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
            this.pictureBox6.Location = new System.Drawing.Point(-14, 28);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(215, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 95;
            this.pictureBox6.TabStop = false;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(19, 137);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(104, 15);
            this.labelControl16.TabIndex = 290;
            this.labelControl16.Text = "Todos os Produtos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox1.Location = new System.Drawing.Point(-191, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1533, 25);
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
            this.pictureBox2.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox2.Location = new System.Drawing.Point(-184, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1517, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 293;
            this.pictureBox2.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(25, 172);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1109, 324);
            this.gridControl1.TabIndex = 294;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SistemaDeGerenciamento2_0.Properties.Settings.SistemaDeGerenciamento2_0Connection" +
    "String";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
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
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
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
            // colep_quantidade
            // 
            this.colep_quantidade.AppearanceCell.Options.UseTextOptions = true;
            this.colep_quantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colep_quantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colep_quantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colep_quantidade.Caption = "Qtd. Estoque";
            this.colep_quantidade.FieldName = "ep_quantidade";
            this.colep_quantidade.Name = "colep_quantidade";
            this.colep_quantidade.Visible = true;
            this.colep_quantidade.VisibleIndex = 7;
            // 
            // colpd_tipo_unidade
            // 
            this.colpd_tipo_unidade.AppearanceCell.Options.UseTextOptions = true;
            this.colpd_tipo_unidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_tipo_unidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colpd_tipo_unidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpd_tipo_unidade.Caption = "Unidade";
            this.colpd_tipo_unidade.FieldName = "pd_tipo_unidade";
            this.colpd_tipo_unidade.Name = "colpd_tipo_unidade";
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
            this.colep_data_entrada.Visible = true;
            this.colep_data_entrada.VisibleIndex = 10;
            // 
            // colnfe_quantidade
            // 
            this.colnfe_quantidade.AppearanceCell.Options.UseTextOptions = true;
            this.colnfe_quantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnfe_quantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colnfe_quantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnfe_quantidade.Caption = "Qtd. NF Entrada";
            this.colnfe_quantidade.FieldName = "nfe_quantidade";
            this.colnfe_quantidade.Name = "colnfe_quantidade";
            this.colnfe_quantidade.Visible = true;
            this.colnfe_quantidade.VisibleIndex = 11;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 521);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.btnAdicionarGrupo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl16;
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
        private DevExpress.XtraGrid.Columns.GridColumn colep_quantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_tipo_unidade;
        private DevExpress.XtraGrid.Columns.GridColumn colpd_estoque_minimo;
        private DevExpress.XtraGrid.Columns.GridColumn colep_data_entrada;
        private DevExpress.XtraGrid.Columns.GridColumn colnfe_quantidade;
    }
}