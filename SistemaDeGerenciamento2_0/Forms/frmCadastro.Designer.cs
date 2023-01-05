namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdicionarCadastro = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colrg_tipo_cadastro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrg_categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrg_nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrg_sexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrg_cpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrg_nome_fantasia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrg_cnpj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colic_situacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colic_prioridade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colic_vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coled_locgradouro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coled_bairro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coled_cidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.labelControl3.Size = new System.Drawing.Size(133, 20);
            this.labelControl3.TabIndex = 101;
            this.labelControl3.Text = "Consultar Cadastro";
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
            this.btnFechar.Location = new System.Drawing.Point(1135, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 99;
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
            this.pictureBox6.TabIndex = 100;
            this.pictureBox6.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 15);
            this.labelControl1.TabIndex = 297;
            this.labelControl1.Text = "Adicionar Cadastro:";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(19, 136);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(104, 15);
            this.labelControl16.TabIndex = 295;
            this.labelControl16.Text = "Todos os Produtos:";
            // 
            // btnAdicionarCadastro
            // 
            this.btnAdicionarCadastro.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarCadastro.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarCadastro.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCadastro.Appearance.Options.UseBorderColor = true;
            this.btnAdicionarCadastro.Appearance.Options.UseFont = true;
            this.btnAdicionarCadastro.AppearanceDisabled.BackColor = System.Drawing.Color.Yellow;
            this.btnAdicionarCadastro.AppearanceDisabled.BackColor2 = System.Drawing.Color.Yellow;
            this.btnAdicionarCadastro.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAdicionarCadastro.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.btnAdicionarCadastro.AppearanceHovered.BackColor2 = System.Drawing.Color.Red;
            this.btnAdicionarCadastro.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdicionarCadastro.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarCadastro.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarCadastro.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarCadastro.AppearancePressed.Options.UseBackColor = true;
            this.btnAdicionarCadastro.AppearancePressed.Options.UseBorderColor = true;
            this.btnAdicionarCadastro.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.adcao9;
            this.btnAdicionarCadastro.ImageOptions.ImageIndex = 5;
            this.btnAdicionarCadastro.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnAdicionarCadastro.ImageOptions.ImageToTextIndent = 10;
            this.btnAdicionarCadastro.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdicionarCadastro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdicionarCadastro.Location = new System.Drawing.Point(19, 92);
            this.btnAdicionarCadastro.Name = "btnAdicionarCadastro";
            this.btnAdicionarCadastro.Size = new System.Drawing.Size(217, 30);
            this.btnAdicionarCadastro.TabIndex = 294;
            this.btnAdicionarCadastro.Text = "Adicionar Novo Cadastro";
            this.btnAdicionarCadastro.Click += new System.EventHandler(this.btnAdicionarCadastro_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox2.Location = new System.Drawing.Point(-184, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1517, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 298;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox1.Location = new System.Drawing.Point(-191, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1533, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 296;
            this.pictureBox1.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "tb_registro";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(19, 183);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1120, 282);
            this.gridControl1.TabIndex = 299;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SistemaDeGerenciamento2_0ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "tb_registro";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colrg_tipo_cadastro,
            this.colrg_categoria,
            this.colrg_nome,
            this.colrg_sexo,
            this.colrg_cpf,
            this.colrg_nome_fantasia,
            this.colrg_cnpj,
            this.colic_situacao,
            this.colic_prioridade,
            this.colic_vendedor,
            this.coled_locgradouro,
            this.coled_bairro,
            this.coled_cidade});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colrg_tipo_cadastro
            // 
            this.colrg_tipo_cadastro.AppearanceCell.Options.UseTextOptions = true;
            this.colrg_tipo_cadastro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_tipo_cadastro.AppearanceHeader.Options.UseTextOptions = true;
            this.colrg_tipo_cadastro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_tipo_cadastro.Caption = "Tipo Cadastro";
            this.colrg_tipo_cadastro.FieldName = "rg_tipo_cadastro";
            this.colrg_tipo_cadastro.Name = "colrg_tipo_cadastro";
            this.colrg_tipo_cadastro.Visible = true;
            this.colrg_tipo_cadastro.VisibleIndex = 0;
            // 
            // colrg_categoria
            // 
            this.colrg_categoria.AppearanceCell.Options.UseTextOptions = true;
            this.colrg_categoria.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_categoria.AppearanceHeader.Options.UseTextOptions = true;
            this.colrg_categoria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_categoria.Caption = "Pessoa";
            this.colrg_categoria.FieldName = "rg_categoria";
            this.colrg_categoria.Name = "colrg_categoria";
            this.colrg_categoria.Visible = true;
            this.colrg_categoria.VisibleIndex = 1;
            // 
            // colrg_nome
            // 
            this.colrg_nome.AppearanceCell.Options.UseTextOptions = true;
            this.colrg_nome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_nome.AppearanceHeader.Options.UseTextOptions = true;
            this.colrg_nome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_nome.Caption = "Nome";
            this.colrg_nome.FieldName = "rg_nome";
            this.colrg_nome.Name = "colrg_nome";
            this.colrg_nome.Visible = true;
            this.colrg_nome.VisibleIndex = 2;
            // 
            // colrg_sexo
            // 
            this.colrg_sexo.AppearanceCell.Options.UseTextOptions = true;
            this.colrg_sexo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_sexo.AppearanceHeader.Options.UseTextOptions = true;
            this.colrg_sexo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_sexo.Caption = "Sexo";
            this.colrg_sexo.FieldName = "rg_sexo";
            this.colrg_sexo.Name = "colrg_sexo";
            this.colrg_sexo.Visible = true;
            this.colrg_sexo.VisibleIndex = 3;
            // 
            // colrg_cpf
            // 
            this.colrg_cpf.AppearanceCell.Options.UseTextOptions = true;
            this.colrg_cpf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_cpf.AppearanceHeader.Options.UseTextOptions = true;
            this.colrg_cpf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_cpf.Caption = "CPF";
            this.colrg_cpf.FieldName = "rg_cpf";
            this.colrg_cpf.Name = "colrg_cpf";
            this.colrg_cpf.Visible = true;
            this.colrg_cpf.VisibleIndex = 4;
            // 
            // colrg_nome_fantasia
            // 
            this.colrg_nome_fantasia.AppearanceCell.Options.UseTextOptions = true;
            this.colrg_nome_fantasia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_nome_fantasia.AppearanceHeader.Options.UseTextOptions = true;
            this.colrg_nome_fantasia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_nome_fantasia.Caption = "Nome Fantasia";
            this.colrg_nome_fantasia.FieldName = "rg_nome_fantasia";
            this.colrg_nome_fantasia.Name = "colrg_nome_fantasia";
            this.colrg_nome_fantasia.Visible = true;
            this.colrg_nome_fantasia.VisibleIndex = 5;
            // 
            // colrg_cnpj
            // 
            this.colrg_cnpj.AppearanceCell.Options.UseTextOptions = true;
            this.colrg_cnpj.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_cnpj.AppearanceHeader.Options.UseTextOptions = true;
            this.colrg_cnpj.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrg_cnpj.Caption = "CNPJ";
            this.colrg_cnpj.FieldName = "rg_cnpj";
            this.colrg_cnpj.Name = "colrg_cnpj";
            this.colrg_cnpj.Visible = true;
            this.colrg_cnpj.VisibleIndex = 6;
            // 
            // colic_situacao
            // 
            this.colic_situacao.AppearanceCell.Options.UseTextOptions = true;
            this.colic_situacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colic_situacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colic_situacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colic_situacao.Caption = "Situação";
            this.colic_situacao.FieldName = "ic_situacao";
            this.colic_situacao.Name = "colic_situacao";
            this.colic_situacao.Visible = true;
            this.colic_situacao.VisibleIndex = 7;
            // 
            // colic_prioridade
            // 
            this.colic_prioridade.AppearanceCell.Options.UseTextOptions = true;
            this.colic_prioridade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colic_prioridade.AppearanceHeader.Options.UseTextOptions = true;
            this.colic_prioridade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colic_prioridade.Caption = "Prioridade";
            this.colic_prioridade.FieldName = "ic_prioridade";
            this.colic_prioridade.Name = "colic_prioridade";
            this.colic_prioridade.Visible = true;
            this.colic_prioridade.VisibleIndex = 8;
            // 
            // colic_vendedor
            // 
            this.colic_vendedor.AppearanceCell.Options.UseTextOptions = true;
            this.colic_vendedor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colic_vendedor.AppearanceHeader.Options.UseTextOptions = true;
            this.colic_vendedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colic_vendedor.Caption = "Vendedor";
            this.colic_vendedor.FieldName = "ic_vendedor";
            this.colic_vendedor.Name = "colic_vendedor";
            this.colic_vendedor.Visible = true;
            this.colic_vendedor.VisibleIndex = 9;
            // 
            // coled_locgradouro
            // 
            this.coled_locgradouro.AppearanceCell.Options.UseTextOptions = true;
            this.coled_locgradouro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coled_locgradouro.AppearanceHeader.Options.UseTextOptions = true;
            this.coled_locgradouro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coled_locgradouro.Caption = "Endereço";
            this.coled_locgradouro.FieldName = "ed_locgradouro";
            this.coled_locgradouro.Name = "coled_locgradouro";
            this.coled_locgradouro.Visible = true;
            this.coled_locgradouro.VisibleIndex = 10;
            // 
            // coled_bairro
            // 
            this.coled_bairro.AppearanceCell.Options.UseTextOptions = true;
            this.coled_bairro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coled_bairro.AppearanceHeader.Options.UseTextOptions = true;
            this.coled_bairro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coled_bairro.Caption = "Bairro";
            this.coled_bairro.FieldName = "ed_bairro";
            this.coled_bairro.Name = "coled_bairro";
            this.coled_bairro.Visible = true;
            this.coled_bairro.VisibleIndex = 11;
            // 
            // coled_cidade
            // 
            this.coled_cidade.AppearanceCell.Options.UseTextOptions = true;
            this.coled_cidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coled_cidade.AppearanceHeader.Options.UseTextOptions = true;
            this.coled_cidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coled_cidade.Caption = "Cidade";
            this.coled_cidade.FieldName = "ed_cidade";
            this.coled_cidade.Name = "coled_cidade";
            this.coled_cidade.Visible = true;
            this.coled_cidade.VisibleIndex = 12;
            // 
            // btnSair
            // 
            this.btnSair.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Appearance.Options.UseFont = true;
            this.btnSair.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.exit_20px;
            this.btnSair.ImageOptions.ImageIndex = 5;
            this.btnSair.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnSair.ImageOptions.ImageToTextIndent = 10;
            this.btnSair.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(1026, 479);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(113, 30);
            this.btnSair.TabIndex = 300;
            this.btnSair.Text = "Sair (Esc)";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 519);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.btnAdicionarCadastro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastro_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCadastro_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCadastro_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarCadastro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colrg_tipo_cadastro;
        private DevExpress.XtraGrid.Columns.GridColumn colrg_categoria;
        private DevExpress.XtraGrid.Columns.GridColumn colrg_nome;
        private DevExpress.XtraGrid.Columns.GridColumn colrg_sexo;
        private DevExpress.XtraGrid.Columns.GridColumn colrg_cpf;
        private DevExpress.XtraGrid.Columns.GridColumn colrg_nome_fantasia;
        private DevExpress.XtraGrid.Columns.GridColumn colrg_cnpj;
        private DevExpress.XtraGrid.Columns.GridColumn colic_situacao;
        private DevExpress.XtraGrid.Columns.GridColumn colic_prioridade;
        private DevExpress.XtraGrid.Columns.GridColumn colic_vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn coled_locgradouro;
        private DevExpress.XtraGrid.Columns.GridColumn coled_bairro;
        private DevExpress.XtraGrid.Columns.GridColumn coled_cidade;
        private DevExpress.XtraEditors.SimpleButton btnSair;
    }
}