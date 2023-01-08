namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmConfiguracaoFinanceira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracaoFinanceira));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.pcbRequesitosCodigoDeBarras = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit33 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbQtdParcelas = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtPorcentagemJuros = new DevExpress.XtraEditors.TextEdit();
            this.txtPorcentagemDesconto = new DevExpress.XtraEditors.TextEdit();
            this.txtPorcentagemDescontoGrupo = new DevExpress.XtraEditors.TextEdit();
            this.cmbGrupoAgrupador = new DevExpress.XtraEditors.LookUpEdit();
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gdvGruposAgrupadores = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_configuracao_financeira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cf_desconto_grupo_produto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgp_nome_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgp_nome_agrupador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AlertaSalvar = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRequesitosCodigoDeBarras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit33.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQtdParcelas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagemJuros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagemDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagemDescontoGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGrupoAgrupador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGruposAgrupadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseBackColor = true;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(69, 64);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(89, 40);
            this.labelControl7.TabIndex = 300;
            this.labelControl7.Text = "Porcentagem\r\nJuros Por Dia:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Appearance.Options.UseFont = true;
            this.btnSalvar.ImageOptions.ImageIndex = 5;
            this.btnSalvar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnSalvar.ImageOptions.ImageToTextIndent = 10;
            this.btnSalvar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(650, 546);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 30);
            this.btnSalvar.TabIndex = 302;
            this.btnSalvar.Text = "Salvar (F10)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pcbRequesitosCodigoDeBarras
            // 
            this.pcbRequesitosCodigoDeBarras.EditValue = ((object)(resources.GetObject("pcbRequesitosCodigoDeBarras.EditValue")));
            this.pcbRequesitosCodigoDeBarras.Location = new System.Drawing.Point(164, 84);
            this.pcbRequesitosCodigoDeBarras.Name = "pcbRequesitosCodigoDeBarras";
            this.pcbRequesitosCodigoDeBarras.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pcbRequesitosCodigoDeBarras.Properties.Appearance.Options.UseBackColor = true;
            this.pcbRequesitosCodigoDeBarras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcbRequesitosCodigoDeBarras.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcbRequesitosCodigoDeBarras.Properties.ZoomAcceleration = 5D;
            this.pcbRequesitosCodigoDeBarras.Size = new System.Drawing.Size(23, 20);
            this.pcbRequesitosCodigoDeBarras.TabIndex = 303;
            this.pcbRequesitosCodigoDeBarras.ToolTip = "Informar a porcentagem do juros por dia de atraso.";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(30, 11);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(182, 20);
            this.labelControl13.TabIndex = 307;
            this.labelControl13.Text = "Configurações Financeiras";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-11, 25);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(265, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 306;
            this.pictureBox6.TabStop = false;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(820, 84);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.ZoomAcceleration = 5D;
            this.pictureEdit3.Size = new System.Drawing.Size(23, 20);
            this.pictureEdit3.TabIndex = 316;
            this.pictureEdit3.ToolTip = "Porcentagem de desconto para pagamento Avista.";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(740, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 40);
            this.labelControl3.TabIndex = 315;
            this.labelControl3.Text = "Porcentagem \r\nDesconto:";
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(500, 84);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.ZoomAcceleration = 5D;
            this.pictureEdit4.Size = new System.Drawing.Size(23, 20);
            this.pictureEdit4.TabIndex = 319;
            this.pictureEdit4.ToolTip = "Quantidade de parcelas para ser gerado juros.";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(400, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 40);
            this.labelControl4.TabIndex = 318;
            this.labelControl4.Text = "Qtd. Parcelas \r\nP/ Gerar Juros:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(198, 198);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAcceleration = 5D;
            this.pictureEdit1.Size = new System.Drawing.Size(23, 20);
            this.pictureEdit1.TabIndex = 322;
            this.pictureEdit1.ToolTip = "Porcentagem de desconto por grupo.";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(54, 178);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(138, 40);
            this.labelControl1.TabIndex = 321;
            this.labelControl1.Text = "Procentagem\r\nDesconto por Grupo:";
            // 
            // pictureEdit33
            // 
            this.pictureEdit33.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.acesso_20px;
            this.pictureEdit33.Enabled = false;
            this.pictureEdit33.Location = new System.Drawing.Point(30, 56);
            this.pictureEdit33.Name = "pictureEdit33";
            this.pictureEdit33.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit33.Properties.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.pictureEdit33.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit33.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit33.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pictureEdit33.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit33.Properties.ShowMenu = false;
            this.pictureEdit33.Size = new System.Drawing.Size(190, 99);
            this.pictureEdit33.TabIndex = 324;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Enabled = false;
            this.pictureEdit6.Location = new System.Drawing.Point(366, 56);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit6.Properties.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit6.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pictureEdit6.Properties.ReadOnly = true;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Size = new System.Drawing.Size(190, 99);
            this.pictureEdit6.TabIndex = 330;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Enabled = false;
            this.pictureEdit7.Location = new System.Drawing.Point(702, 56);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit7.Properties.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit7.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Properties.ShowMenu = false;
            this.pictureEdit7.Size = new System.Drawing.Size(190, 99);
            this.pictureEdit7.TabIndex = 333;
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
            this.pictureEdit8.Enabled = false;
            this.pictureEdit8.Location = new System.Drawing.Point(30, 165);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit8.Properties.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit8.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit8.Properties.ShowMenu = false;
            this.pictureEdit8.Size = new System.Drawing.Size(862, 361);
            this.pictureEdit8.TabIndex = 336;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(306, 198);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(122, 20);
            this.labelControl5.TabIndex = 339;
            this.labelControl5.Text = "Grupo/Agrupador:";
            // 
            // cmbQtdParcelas
            // 
            this.cmbQtdParcelas.Location = new System.Drawing.Point(390, 110);
            this.cmbQtdParcelas.Name = "cmbQtdParcelas";
            this.cmbQtdParcelas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQtdParcelas.Properties.Appearance.Options.UseFont = true;
            this.cmbQtdParcelas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbQtdParcelas.Properties.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x",
            "11x",
            "12x"});
            this.cmbQtdParcelas.Properties.MaxLength = 20;
            this.cmbQtdParcelas.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbQtdParcelas.Size = new System.Drawing.Size(141, 26);
            this.cmbQtdParcelas.TabIndex = 341;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseBackColor = true;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(54, 267);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(187, 15);
            this.labelControl16.TabIndex = 342;
            this.labelControl16.Text = "Todos os Produtos com Desconto:";
            // 
            // separatorControl4
            // 
            this.separatorControl4.BackColor = System.Drawing.Color.Silver;
            this.separatorControl4.LineColor = System.Drawing.Color.Black;
            this.separatorControl4.Location = new System.Drawing.Point(46, 273);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Size = new System.Drawing.Size(827, 23);
            this.separatorControl4.TabIndex = 345;
            // 
            // txtPorcentagemJuros
            // 
            this.txtPorcentagemJuros.Location = new System.Drawing.Point(55, 110);
            this.txtPorcentagemJuros.Name = "txtPorcentagemJuros";
            this.txtPorcentagemJuros.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentagemJuros.Properties.Appearance.Options.UseFont = true;
            this.txtPorcentagemJuros.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPorcentagemJuros.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPorcentagemJuros.Properties.MaskSettings.Set("mask", "P");
            this.txtPorcentagemJuros.Properties.MaxLength = 20;
            this.txtPorcentagemJuros.Properties.NullText = "0,00%";
            this.txtPorcentagemJuros.Properties.UseMaskAsDisplayFormat = true;
            this.txtPorcentagemJuros.Size = new System.Drawing.Size(141, 26);
            this.txtPorcentagemJuros.TabIndex = 346;
            // 
            // txtPorcentagemDesconto
            // 
            this.txtPorcentagemDesconto.Location = new System.Drawing.Point(726, 110);
            this.txtPorcentagemDesconto.Name = "txtPorcentagemDesconto";
            this.txtPorcentagemDesconto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentagemDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtPorcentagemDesconto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPorcentagemDesconto.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPorcentagemDesconto.Properties.MaskSettings.Set("mask", "P");
            this.txtPorcentagemDesconto.Properties.MaxLength = 20;
            this.txtPorcentagemDesconto.Properties.NullText = "0,00%";
            this.txtPorcentagemDesconto.Properties.UseMaskAsDisplayFormat = true;
            this.txtPorcentagemDesconto.Size = new System.Drawing.Size(141, 26);
            this.txtPorcentagemDesconto.TabIndex = 347;
            // 
            // txtPorcentagemDescontoGrupo
            // 
            this.txtPorcentagemDescontoGrupo.Location = new System.Drawing.Point(55, 224);
            this.txtPorcentagemDescontoGrupo.Name = "txtPorcentagemDescontoGrupo";
            this.txtPorcentagemDescontoGrupo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentagemDescontoGrupo.Properties.Appearance.Options.UseFont = true;
            this.txtPorcentagemDescontoGrupo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPorcentagemDescontoGrupo.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPorcentagemDescontoGrupo.Properties.MaskSettings.Set("mask", "P");
            this.txtPorcentagemDescontoGrupo.Properties.MaxLength = 20;
            this.txtPorcentagemDescontoGrupo.Properties.NullText = "0,00%";
            this.txtPorcentagemDescontoGrupo.Properties.UseMaskAsDisplayFormat = true;
            this.txtPorcentagemDescontoGrupo.Size = new System.Drawing.Size(141, 26);
            this.txtPorcentagemDescontoGrupo.TabIndex = 348;
            // 
            // cmbGrupoAgrupador
            // 
            this.cmbGrupoAgrupador.Location = new System.Drawing.Point(306, 224);
            this.cmbGrupoAgrupador.Name = "cmbGrupoAgrupador";
            this.cmbGrupoAgrupador.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrupoAgrupador.Properties.Appearance.Options.UseFont = true;
            this.cmbGrupoAgrupador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGrupoAgrupador.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_grupo", "ID", 25, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gp_nome_grupo", "Nome Grupo", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gp_nome_agrupador", "Nome Agrupador", 109, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbGrupoAgrupador.Properties.DataSource = this.queryBindingSource;
            this.cmbGrupoAgrupador.Properties.DisplayMember = "gp_nome_grupo";
            this.cmbGrupoAgrupador.Properties.DropDownRows = 5;
            this.cmbGrupoAgrupador.Properties.MaxLength = 20;
            this.cmbGrupoAgrupador.Properties.NullText = "";
            this.cmbGrupoAgrupador.Properties.PopupSizeable = false;
            this.cmbGrupoAgrupador.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbGrupoAgrupador.Properties.ValueMember = "id_grupo";
            this.cmbGrupoAgrupador.Size = new System.Drawing.Size(250, 26);
            this.cmbGrupoAgrupador.TabIndex = 349;
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
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select \"tb_grupo\".\"id_grupo\",\r\n       \"tb_grupo\".\"gp_nome_grupo\",\r\n       \"tb_gru" +
    "po\".\"gp_nome_agrupador\"\r\n  from \"dbo\".\"tb_grupo\" \"tb_grupo\"\r\nwhere \"tb_grupo\".\"g" +
    "p_nome_grupo\" is not null";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gdvGruposAgrupadores
            // 
            this.gdvGruposAgrupadores.DataMember = "tb_configuracao_financeira";
            this.gdvGruposAgrupadores.DataSource = this.sqlDataSource2;
            this.gdvGruposAgrupadores.Location = new System.Drawing.Point(55, 302);
            this.gdvGruposAgrupadores.MainView = this.gridView1;
            this.gdvGruposAgrupadores.Name = "gdvGruposAgrupadores";
            this.gdvGruposAgrupadores.Size = new System.Drawing.Size(812, 208);
            this.gdvGruposAgrupadores.TabIndex = 350;
            this.gdvGruposAgrupadores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "SistemaDeGerenciamento2_0ConnectionString";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression1.ColumnName = "id_configuracao_financeira";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"183\" />";
            table1.Name = "tb_configuracao_financeira";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "cf_desconto_grupo_produto";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "gp_nome_grupo";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"123\" />";
            table2.Name = "tb_grupo";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "gp_nome_agrupador";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Name = "tb_configuracao_financeira";
            relationColumnInfo1.NestedKeyColumn = "id_grupo";
            relationColumnInfo1.ParentKeyColumn = "fk_grupo";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_configuracao_financeira,
            this.cf_desconto_grupo_produto,
            this.colgp_nome_grupo,
            this.colgp_nome_agrupador});
            this.gridView1.GridControl = this.gdvGruposAgrupadores;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // id_configuracao_financeira
            // 
            this.id_configuracao_financeira.AppearanceCell.Options.UseTextOptions = true;
            this.id_configuracao_financeira.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id_configuracao_financeira.AppearanceHeader.Options.UseTextOptions = true;
            this.id_configuracao_financeira.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id_configuracao_financeira.Caption = "ID";
            this.id_configuracao_financeira.FieldName = "id_configuracao_financeira";
            this.id_configuracao_financeira.Name = "id_configuracao_financeira";
            this.id_configuracao_financeira.Visible = true;
            this.id_configuracao_financeira.VisibleIndex = 0;
            // 
            // cf_desconto_grupo_produto
            // 
            this.cf_desconto_grupo_produto.AppearanceCell.Options.UseTextOptions = true;
            this.cf_desconto_grupo_produto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cf_desconto_grupo_produto.AppearanceHeader.Options.UseTextOptions = true;
            this.cf_desconto_grupo_produto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cf_desconto_grupo_produto.Caption = "Porcentagem Desconto";
            this.cf_desconto_grupo_produto.DisplayFormat.FormatString = "{0:.00}%";
            this.cf_desconto_grupo_produto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cf_desconto_grupo_produto.FieldName = "cf_desconto_grupo_produto";
            this.cf_desconto_grupo_produto.Name = "cf_desconto_grupo_produto";
            this.cf_desconto_grupo_produto.Visible = true;
            this.cf_desconto_grupo_produto.VisibleIndex = 1;
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
            this.colgp_nome_grupo.VisibleIndex = 2;
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
            this.colgp_nome_agrupador.VisibleIndex = 3;
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
            // btnFechar
            // 
            this.btnFechar.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnFechar.Appearance.Options.UseBorderColor = true;
            this.btnFechar.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnFechar.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.ImageOptions.Image")));
            this.btnFechar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFechar.Location = new System.Drawing.Point(897, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 351;
            this.btnFechar.Visible = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.cancelar;
            this.btnCancelar.ImageOptions.ImageIndex = 5;
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnCancelar.ImageOptions.ImageToTextIndent = 10;
            this.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(779, 546);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 30);
            this.btnCancelar.TabIndex = 352;
            this.btnCancelar.Text = "Cancelar (Esc)";
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmConfiguracaoFinanceira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 599);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gdvGruposAgrupadores);
            this.Controls.Add(this.cmbGrupoAgrupador);
            this.Controls.Add(this.txtPorcentagemDescontoGrupo);
            this.Controls.Add(this.txtPorcentagemDesconto);
            this.Controls.Add(this.txtPorcentagemJuros);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.cmbQtdParcelas);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pcbRequesitosCodigoDeBarras);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.pictureEdit33);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.pictureEdit7);
            this.Controls.Add(this.separatorControl4);
            this.Controls.Add(this.pictureEdit8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmConfiguracaoFinanceira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfiguracaoFinanceira";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConfiguracaoFinanceira_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRequesitosCodigoDeBarras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit33.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQtdParcelas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagemJuros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagemDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagemDescontoGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGrupoAgrupador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGruposAgrupadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PictureEdit pcbRequesitosCodigoDeBarras;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit33;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbQtdParcelas;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private DevExpress.XtraEditors.TextEdit txtPorcentagemJuros;
        private DevExpress.XtraEditors.TextEdit txtPorcentagemDesconto;
        private DevExpress.XtraEditors.TextEdit txtPorcentagemDescontoGrupo;
        private DevExpress.XtraEditors.LookUpEdit cmbGrupoAgrupador;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl gdvGruposAgrupadores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colgp_nome_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn colgp_nome_agrupador;
        private DevExpress.XtraGrid.Columns.GridColumn cf_desconto_grupo_produto;
        private DevExpress.XtraBars.Alerter.AlertControl AlertaSalvar;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.Columns.GridColumn id_configuracao_financeira;
        public DevExpress.XtraEditors.SimpleButton btnFechar;
        public DevExpress.XtraEditors.SimpleButton btnSalvar;
        public DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}