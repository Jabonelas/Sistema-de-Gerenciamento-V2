namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmCadastroGrupoAgrupador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroGrupoAgrupador));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.btnAdicionarSubGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdicionarGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gdvGruposAgrupadores = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colgp_nome_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgp_nome_agrupador = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGruposAgrupadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // btnAdicionarSubGrupo
            // 
            this.btnAdicionarSubGrupo.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarSubGrupo.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarSubGrupo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarSubGrupo.Appearance.Options.UseBorderColor = true;
            this.btnAdicionarSubGrupo.Appearance.Options.UseFont = true;
            this.btnAdicionarSubGrupo.AppearanceDisabled.BackColor = System.Drawing.Color.Yellow;
            this.btnAdicionarSubGrupo.AppearanceDisabled.BackColor2 = System.Drawing.Color.Yellow;
            this.btnAdicionarSubGrupo.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAdicionarSubGrupo.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.btnAdicionarSubGrupo.AppearanceHovered.BackColor2 = System.Drawing.Color.Red;
            this.btnAdicionarSubGrupo.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdicionarSubGrupo.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarSubGrupo.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarSubGrupo.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarSubGrupo.AppearancePressed.Options.UseBackColor = true;
            this.btnAdicionarSubGrupo.AppearancePressed.Options.UseBorderColor = true;
            this.btnAdicionarSubGrupo.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.adcao9;
            this.btnAdicionarSubGrupo.ImageOptions.ImageIndex = 5;
            this.btnAdicionarSubGrupo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnAdicionarSubGrupo.ImageOptions.ImageToTextIndent = 10;
            this.btnAdicionarSubGrupo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdicionarSubGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdicionarSubGrupo.Location = new System.Drawing.Point(325, 66);
            this.btnAdicionarSubGrupo.Name = "btnAdicionarSubGrupo";
            this.btnAdicionarSubGrupo.Size = new System.Drawing.Size(217, 30);
            this.btnAdicionarSubGrupo.TabIndex = 73;
            this.btnAdicionarSubGrupo.Text = "Adicionar Agrupador de Produto";
            this.btnAdicionarSubGrupo.Click += new System.EventHandler(this.btnAdicionarSubGrupo_Click);
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
            this.btnAdicionarGrupo.Location = new System.Drawing.Point(47, 66);
            this.btnAdicionarGrupo.Name = "btnAdicionarGrupo";
            this.btnAdicionarGrupo.Size = new System.Drawing.Size(217, 30);
            this.btnAdicionarGrupo.TabIndex = 72;
            this.btnAdicionarGrupo.Text = "Adicionar Grupo de Produto";
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
            this.btnFechar.Location = new System.Drawing.Point(564, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 71;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-75, 35);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(730, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 74;
            this.pictureBox6.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 20);
            this.labelControl3.TabIndex = 80;
            this.labelControl3.Text = "Grupo de Produto";
            // 
            // gdvGruposAgrupadores
            // 
            this.gdvGruposAgrupadores.DataMember = "Query";
            this.gdvGruposAgrupadores.DataSource = this.sqlDataSource1;
            this.gdvGruposAgrupadores.Location = new System.Drawing.Point(30, 119);
            this.gdvGruposAgrupadores.MainView = this.gridView1;
            this.gdvGruposAgrupadores.Name = "gdvGruposAgrupadores";
            this.gdvGruposAgrupadores.Size = new System.Drawing.Size(527, 217);
            this.gdvGruposAgrupadores.TabIndex = 295;
            this.gdvGruposAgrupadores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SistemaDeGerenciamento2_0.Properties.Settings.SistemaDeGerenciamento2_0Connection" +
    "String";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select \"tb_grupo\".\"gp_nome_grupo\",\r\n       \"tb_grupo\".\"gp_nome_agrupador\"\r\n  from" +
    " \"dbo\".\"tb_grupo\" \"tb_grupo\"\r\nwhere \"tb_grupo\".\"gp_nome_grupo\" is not null";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colgp_nome_grupo,
            this.colgp_nome_agrupador});
            this.gridView1.GridControl = this.gdvGruposAgrupadores;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
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
            this.colgp_nome_grupo.VisibleIndex = 0;
            // 
            // colgp_nome_agrupador
            // 
            this.colgp_nome_agrupador.AppearanceCell.Options.UseTextOptions = true;
            this.colgp_nome_agrupador.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgp_nome_agrupador.AppearanceHeader.Options.UseTextOptions = true;
            this.colgp_nome_agrupador.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgp_nome_agrupador.Caption = "Agrupador";
            this.colgp_nome_agrupador.FieldName = "gp_nome_agrupador";
            this.colgp_nome_agrupador.Name = "colgp_nome_agrupador";
            this.colgp_nome_agrupador.Visible = true;
            this.colgp_nome_agrupador.VisibleIndex = 1;
            // 
            // frmCadastroGrupoAgrupador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 348);
            this.Controls.Add(this.gdvGruposAgrupadores);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnAdicionarSubGrupo);
            this.Controls.Add(this.btnAdicionarGrupo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCadastroGrupoAgrupador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraForm1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroGrupoSubGrupo_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCadastroGrupoSubGrupo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCadastroGrupoSubGrupo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGruposAgrupadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAdicionarSubGrupo;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarGrupo;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gdvGruposAgrupadores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colgp_nome_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn colgp_nome_agrupador;
    }
}