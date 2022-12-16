namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmCadastroUsuario
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pnlPermissoes = new System.Windows.Forms.FlowLayoutPanel();
            this.pcbExibirSenha = new DevExpress.XtraEditors.PictureEdit();
            this.pcbRequesitosCodigoDeBarras = new DevExpress.XtraEditors.PictureEdit();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.txtConfirmacaoSenha = new DevExpress.XtraEditors.TextEdit();
            this.txtNomeUsuario = new DevExpress.XtraEditors.TextEdit();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cmbFuncionario = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbFuncionario2 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExibirSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRequesitosCodigoDeBarras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmacaoSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFuncionario2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sqlDataSource2;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "SistemaDeGerenciamento2_0ConnectionString";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select \"tb_registro\".\"id_registro\",\r\n       \"tb_registro\".\"rg_nome\"\r\n  from \"dbo\"" +
    ".\"tb_registro\" \"tb_registro\"\r\nwhere \"tb_registro\".\"rg_tipo_cadastro\" = \'Funciona" +
    "rio\'";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTIiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0iaWRfcmVnaXN0cm8iIFR5cGU9IkludDMyIiAvPjxGaWVsZCBOYW1lPSJyZ19ub21lIiBUeXBlPSJTd" +
    "HJpbmciIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(167, 20);
            this.labelControl3.TabIndex = 83;
            this.labelControl3.Text = "Cadastrar Novo Usuário";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 20);
            this.labelControl1.TabIndex = 99;
            this.labelControl1.Text = "Funcionário:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 20);
            this.labelControl2.TabIndex = 106;
            this.labelControl2.Text = "Usuário:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(317, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 20);
            this.labelControl4.TabIndex = 107;
            this.labelControl4.Text = "Senha:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(586, 121);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(113, 20);
            this.labelControl5.TabIndex = 108;
            this.labelControl5.Text = "Confirmar Senha:";
            // 
            // pnlPermissoes
            // 
            this.pnlPermissoes.AutoScroll = true;
            this.pnlPermissoes.Location = new System.Drawing.Point(27, 194);
            this.pnlPermissoes.Name = "pnlPermissoes";
            this.pnlPermissoes.Size = new System.Drawing.Size(790, 371);
            this.pnlPermissoes.TabIndex = 113;
            // 
            // pcbExibirSenha
            // 
            this.pcbExibirSenha.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.olho_20;
            this.pcbExibirSenha.Location = new System.Drawing.Point(705, 121);
            this.pcbExibirSenha.Name = "pcbExibirSenha";
            this.pcbExibirSenha.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcbExibirSenha.Properties.Appearance.Options.UseBackColor = true;
            this.pcbExibirSenha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcbExibirSenha.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcbExibirSenha.Properties.ZoomAcceleration = 5D;
            this.pcbExibirSenha.Size = new System.Drawing.Size(26, 20);
            this.pcbExibirSenha.TabIndex = 115;
            this.pcbExibirSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbExibirSenha_MouseDown);
            this.pcbExibirSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbExibirSenha_MouseUp);
            // 
            // pcbRequesitosCodigoDeBarras
            // 
            this.pcbRequesitosCodigoDeBarras.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.informacao20;
            this.pcbRequesitosCodigoDeBarras.Location = new System.Drawing.Point(366, 121);
            this.pcbRequesitosCodigoDeBarras.Name = "pcbRequesitosCodigoDeBarras";
            this.pcbRequesitosCodigoDeBarras.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcbRequesitosCodigoDeBarras.Properties.Appearance.Options.UseBackColor = true;
            this.pcbRequesitosCodigoDeBarras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcbRequesitosCodigoDeBarras.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcbRequesitosCodigoDeBarras.Properties.ZoomAcceleration = 5D;
            this.pcbRequesitosCodigoDeBarras.Size = new System.Drawing.Size(23, 20);
            this.pcbRequesitosCodigoDeBarras.TabIndex = 114;
            this.pcbRequesitosCodigoDeBarras.ToolTip = "Password: Caracteres Permitidos \r\n(!,@,#,$,%,¨,& ,*,_ ,-,+,=)";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(317, 147);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Properties.Appearance.Options.UseFont = true;
            this.txtSenha.Size = new System.Drawing.Size(231, 26);
            this.txtSenha.TabIndex = 105;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // txtConfirmacaoSenha
            // 
            this.txtConfirmacaoSenha.Location = new System.Drawing.Point(586, 147);
            this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            this.txtConfirmacaoSenha.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacaoSenha.Properties.Appearance.Options.UseFont = true;
            this.txtConfirmacaoSenha.Size = new System.Drawing.Size(231, 26);
            this.txtConfirmacaoSenha.TabIndex = 104;
            this.txtConfirmacaoSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmacaoSenha_KeyPress);
            this.txtConfirmacaoSenha.Leave += new System.EventHandler(this.txtConfirmacaoSenha_Leave);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(27, 147);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtNomeUsuario.Size = new System.Drawing.Size(252, 26);
            this.txtNomeUsuario.TabIndex = 103;
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
            this.btnFechar.Location = new System.Drawing.Point(823, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 81;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-114, 37);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1082, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 82;
            this.pictureBox6.TabStop = false;
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.Location = new System.Drawing.Point(27, 89);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionario.Properties.Appearance.Options.UseFont = true;
            this.cmbFuncionario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFuncionario.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_registro", "ID", 60, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("rg_nome", "Nome Funcionário", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbFuncionario.Properties.DataSource = this.queryBindingSource;
            this.cmbFuncionario.Properties.DisplayMember = "rg_nome";
            this.cmbFuncionario.Properties.DropDownRows = 5;
            this.cmbFuncionario.Properties.MaxLength = 20;
            this.cmbFuncionario.Properties.NullText = "";
            this.cmbFuncionario.Properties.PopupSizeable = false;
            this.cmbFuncionario.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbFuncionario.Properties.ValueMember = "id_registro";
            this.cmbFuncionario.Size = new System.Drawing.Size(206, 26);
            this.cmbFuncionario.TabIndex = 116;
            this.cmbFuncionario.TextChanged += new System.EventHandler(this.cmbFuncionario_TextChanged_1);
            // 
            // cmbFuncionario2
            // 
            this.cmbFuncionario2.Location = new System.Drawing.Point(27, 89);
            this.cmbFuncionario2.Name = "cmbFuncionario2";
            this.cmbFuncionario2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionario2.Properties.Appearance.Options.UseFont = true;
            this.cmbFuncionario2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFuncionario2.Size = new System.Drawing.Size(206, 26);
            this.cmbFuncionario2.TabIndex = 117;
            this.cmbFuncionario2.Visible = false;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 577);
            this.Controls.Add(this.cmbFuncionario2);
            this.Controls.Add(this.cmbFuncionario);
            this.Controls.Add(this.pcbExibirSenha);
            this.Controls.Add(this.pcbRequesitosCodigoDeBarras);
            this.Controls.Add(this.pnlPermissoes);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtConfirmacaoSenha);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroUsuario";
            this.Shown += new System.EventHandler(this.frmCadastroUsuario_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExibirSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRequesitosCodigoDeBarras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmacaoSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFuncionario2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PictureEdit pcbRequesitosCodigoDeBarras;
        private DevExpress.XtraEditors.PictureEdit pcbExibirSenha;
        public DevExpress.XtraEditors.TextEdit txtConfirmacaoSenha;
        public DevExpress.XtraEditors.TextEdit txtSenha;
        public DevExpress.XtraEditors.TextEdit txtNomeUsuario;
        public System.Windows.Forms.FlowLayoutPanel pnlPermissoes;
        public DevExpress.XtraEditors.LookUpEdit cmbFuncionario;
        public DevExpress.XtraEditors.LookUpEdit cmbFuncionario2;
    }
}