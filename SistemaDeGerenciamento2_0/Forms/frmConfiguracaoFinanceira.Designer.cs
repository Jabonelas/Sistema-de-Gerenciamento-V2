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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPorcentagemJuros = new DevExpress.XtraEditors.TextEdit();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.pcbRequesitosCodigoDeBarras = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit33 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            this.cmbEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.queryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbFinalidade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagemJuros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRequesitosCodigoDeBarras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit33.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinalidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
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
            // txtPorcentagemJuros
            // 
            this.txtPorcentagemJuros.Location = new System.Drawing.Point(54, 110);
            this.txtPorcentagemJuros.Name = "txtPorcentagemJuros";
            this.txtPorcentagemJuros.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentagemJuros.Properties.Appearance.Options.UseFont = true;
            this.txtPorcentagemJuros.Properties.MaxLength = 20;
            this.txtPorcentagemJuros.Size = new System.Drawing.Size(141, 26);
            this.txtPorcentagemJuros.TabIndex = 299;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Appearance.Options.UseFont = true;
            this.btnSalvar.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.salvar;
            this.btnSalvar.ImageOptions.ImageIndex = 5;
            this.btnSalvar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnSalvar.ImageOptions.ImageToTextIndent = 10;
            this.btnSalvar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(779, 474);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 30);
            this.btnSalvar.TabIndex = 302;
            this.btnSalvar.Text = "Salvar (F10)";
            // 
            // pcbRequesitosCodigoDeBarras
            // 
            this.pcbRequesitosCodigoDeBarras.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.informacao20;
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
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-11, 25);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(265, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 306;
            this.pictureBox6.TabStop = false;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.informacao20;
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
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(726, 110);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Properties.MaxLength = 20;
            this.textEdit3.Size = new System.Drawing.Size(141, 26);
            this.textEdit3.TabIndex = 314;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.informacao20;
            this.pictureEdit4.Location = new System.Drawing.Point(620, 84);
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
            this.labelControl4.Location = new System.Drawing.Point(520, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 40);
            this.labelControl4.TabIndex = 318;
            this.labelControl4.Text = "Qtd. Parcelas \r\nP/ Gerar Juros:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.informacao20;
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
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(54, 224);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.MaxLength = 20;
            this.textEdit1.Size = new System.Drawing.Size(141, 26);
            this.textEdit1.TabIndex = 320;
            // 
            // pictureEdit33
            // 
            this.pictureEdit33.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.acesso_20px;
            this.pictureEdit33.Location = new System.Drawing.Point(30, 56);
            this.pictureEdit33.Name = "pictureEdit33";
            this.pictureEdit33.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit33.Properties.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.pictureEdit33.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit33.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit33.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pictureEdit33.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit33.Size = new System.Drawing.Size(190, 99);
            this.pictureEdit33.TabIndex = 324;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.acesso_20px;
            this.pictureEdit6.Location = new System.Drawing.Point(478, 56);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit6.Properties.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit6.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Size = new System.Drawing.Size(190, 99);
            this.pictureEdit6.TabIndex = 330;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.acesso_20px;
            this.pictureEdit7.Location = new System.Drawing.Point(702, 56);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit7.Properties.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit7.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Size = new System.Drawing.Size(190, 99);
            this.pictureEdit7.TabIndex = 333;
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.acesso_20px;
            this.pictureEdit8.Location = new System.Drawing.Point(30, 165);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit8.Properties.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit8.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit8.Size = new System.Drawing.Size(862, 290);
            this.pictureEdit8.TabIndex = 336;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(271, 221);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.Properties.Appearance.Options.UseFont = true;
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gp_nome_grupo", "Grupo", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbEstado.Properties.DataSource = this.queryBindingSource;
            this.cmbEstado.Properties.DisplayMember = "gp_nome_grupo";
            this.cmbEstado.Properties.DropDownRows = 5;
            this.cmbEstado.Properties.MaxLength = 20;
            this.cmbEstado.Properties.NullText = "";
            this.cmbEstado.Properties.PopupSizeable = false;
            this.cmbEstado.Properties.ValueMember = "gp_nome_grupo";
            this.cmbEstado.Size = new System.Drawing.Size(260, 26);
            this.cmbEstado.TabIndex = 337;
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SistemaDeGerenciamento2_0.Properties.Settings.SistemaDeGerenciamento2_0Connection" +
    "String";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select \"tb_grupo\".\"gp_nome_grupo\"\r\n  from \"dbo\".\"tb_grupo\" \"tb_grupo\"\r\nwhere \"tb_" +
    "grupo\".\"gp_nome_grupo\" is not null";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0iZ3Bfbm9tZV9ncnVwbyIgVHlwZT0iU3RyaW5nIiAvPjwvVmlldz48L0RhdGFTZXQ+";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(607, 224);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gp_nome_agrupador", "Agrupador", 109, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DataSource = this.queryBindingSource1;
            this.lookUpEdit1.Properties.DisplayMember = "gp_nome_agrupador";
            this.lookUpEdit1.Properties.DropDownRows = 5;
            this.lookUpEdit1.Properties.MaxLength = 20;
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.PopupSizeable = false;
            this.lookUpEdit1.Properties.ValueMember = "gp_nome_agrupador";
            this.lookUpEdit1.Size = new System.Drawing.Size(260, 26);
            this.lookUpEdit1.TabIndex = 338;
            // 
            // queryBindingSource1
            // 
            this.queryBindingSource1.DataMember = "Query";
            this.queryBindingSource1.DataSource = this.sqlDataSource2;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "SistemaDeGerenciamento2_0.Properties.Settings.SistemaDeGerenciamento2_0Connection" +
    "String";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = "select distinct \"tb_grupo\".\"gp_nome_agrupador\"\r\n  from \"dbo\".\"tb_grupo\" \"tb_grupo" +
    "\"";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTIiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0iZ3Bfbm9tZV9hZ3J1cGFkb3IiIFR5cGU9IlN0cmluZyIgLz48L1ZpZXc+PC9EYXRhU2V0Pg==";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(271, 195);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 20);
            this.labelControl5.TabIndex = 339;
            this.labelControl5.Text = "Grupo:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseBackColor = true;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(607, 198);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 20);
            this.labelControl6.TabIndex = 340;
            this.labelControl6.Text = "Agrupador:";
            // 
            // cmbFinalidade
            // 
            this.cmbFinalidade.Location = new System.Drawing.Point(502, 110);
            this.cmbFinalidade.Name = "cmbFinalidade";
            this.cmbFinalidade.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFinalidade.Properties.Appearance.Options.UseFont = true;
            this.cmbFinalidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFinalidade.Properties.Items.AddRange(new object[] {
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
            this.cmbFinalidade.Properties.MaxLength = 20;
            this.cmbFinalidade.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbFinalidade.Size = new System.Drawing.Size(141, 26);
            this.cmbFinalidade.TabIndex = 341;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.Location = new System.Drawing.Point(54, 294);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(813, 147);
            this.gridControl1.TabIndex = 344;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
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
            // frmConfiguracaoFinanceira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 516);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.cmbFinalidade);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pcbRequesitosCodigoDeBarras);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtPorcentagemJuros);
            this.Controls.Add(this.pictureEdit33);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.pictureEdit7);
            this.Controls.Add(this.separatorControl4);
            this.Controls.Add(this.pictureEdit8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmConfiguracaoFinanceira";
            this.Text = "frmConfiguracaoFinanceira";
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagemJuros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRequesitosCodigoDeBarras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit33.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinalidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPorcentagemJuros;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.PictureEdit pcbRequesitosCodigoDeBarras;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit33;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private DevExpress.XtraEditors.LookUpEdit cmbEstado;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFinalidade;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private System.Windows.Forms.BindingSource queryBindingSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
    }
}