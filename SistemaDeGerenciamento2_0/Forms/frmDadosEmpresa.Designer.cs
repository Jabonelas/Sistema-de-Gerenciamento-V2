namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmDadosEmpresa
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
            this.txtInscricaoMunicipal = new DevExpress.XtraEditors.TextEdit();
            this.txtInscricaoEstadual = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRazaoSocial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCNPJ = new DevExpress.XtraEditors.TextEdit();
            this.cmbEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtCidade = new DevExpress.XtraEditors.TextEdit();
            this.txtBairro = new DevExpress.XtraEditors.TextEdit();
            this.txtComplemento = new DevExpress.XtraEditors.TextEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtLogradouro = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscarPorCEP = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtCEP = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefoneFixo = new DevExpress.XtraEditors.TextEdit();
            this.txtCelular = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.txtNomeFantasia = new DevExpress.XtraEditors.TextEdit();
            this.AlertaSalvar = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtInscricaoMunicipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInscricaoEstadual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazaoSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCNPJ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogradouro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCEP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefoneFixo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFantasia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInscricaoMunicipal
            // 
            this.txtInscricaoMunicipal.Location = new System.Drawing.Point(668, 58);
            this.txtInscricaoMunicipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInscricaoMunicipal.Name = "txtInscricaoMunicipal";
            this.txtInscricaoMunicipal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscricaoMunicipal.Properties.Appearance.Options.UseFont = true;
            this.txtInscricaoMunicipal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtInscricaoMunicipal.Properties.MaskSettings.Set("mask", "d");
            this.txtInscricaoMunicipal.Properties.MaxLength = 14;
            this.txtInscricaoMunicipal.Size = new System.Drawing.Size(255, 26);
            this.txtInscricaoMunicipal.TabIndex = 251;
            this.txtInscricaoMunicipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInscricaoMunicipal_KeyPress);
            // 
            // txtInscricaoEstadual
            // 
            this.txtInscricaoEstadual.Location = new System.Drawing.Point(341, 58);
            this.txtInscricaoEstadual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            this.txtInscricaoEstadual.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscricaoEstadual.Properties.Appearance.Options.UseFont = true;
            this.txtInscricaoEstadual.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtInscricaoEstadual.Properties.MaskSettings.Set("mask", "d");
            this.txtInscricaoEstadual.Properties.MaxLength = 14;
            this.txtInscricaoEstadual.Size = new System.Drawing.Size(255, 26);
            this.txtInscricaoEstadual.TabIndex = 250;
            this.txtInscricaoEstadual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInscricaoEstadual_KeyPress);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.informacao20;
            this.pictureEdit2.Location = new System.Drawing.Point(804, 30);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.ZoomAcceleration = 5D;
            this.pictureEdit2.Size = new System.Drawing.Size(23, 20);
            this.pictureEdit2.TabIndex = 259;
            this.pictureEdit2.ToolTip = "Caso seja Isento, não preencha \r\neste campo.";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.informacao20;
            this.pictureEdit1.Location = new System.Drawing.Point(468, 30);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAcceleration = 5D;
            this.pictureEdit1.Size = new System.Drawing.Size(23, 20);
            this.pictureEdit1.TabIndex = 258;
            this.pictureEdit1.ToolTip = "Caso seja Isento, não preencha \r\neste campo.";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(668, 30);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(130, 20);
            this.labelControl6.TabIndex = 257;
            this.labelControl6.Text = "Inscrição Municipal:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(341, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(121, 20);
            this.labelControl4.TabIndex = 255;
            this.labelControl4.Text = "Inscrição Estadual:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(532, 118);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Properties.Appearance.Options.UseFont = true;
            this.txtRazaoSocial.Properties.MaxLength = 100;
            this.txtRazaoSocial.Size = new System.Drawing.Size(391, 26);
            this.txtRazaoSocial.TabIndex = 248;
            this.txtRazaoSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(532, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 20);
            this.labelControl3.TabIndex = 254;
            this.labelControl3.Text = "Razão Social:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 92);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 20);
            this.labelControl1.TabIndex = 253;
            this.labelControl1.Text = "Nome Fantasia:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 20);
            this.labelControl2.TabIndex = 252;
            this.labelControl2.Text = "CNPJ:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(6, 58);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Properties.Appearance.Options.UseFont = true;
            this.txtCNPJ.Size = new System.Drawing.Size(256, 26);
            this.txtCNPJ.TabIndex = 246;
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJ_KeyPress);
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(242, 325);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.Properties.Appearance.Options.UseFont = true;
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.DropDownRows = 5;
            this.cmbEstado.Properties.MaxLength = 20;
            this.cmbEstado.Properties.NullText = "";
            this.cmbEstado.Properties.PopupSizeable = false;
            this.cmbEstado.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbEstado.Size = new System.Drawing.Size(91, 26);
            this.cmbEstado.TabIndex = 263;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Location = new System.Drawing.Point(242, 297);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(48, 20);
            this.labelControl23.TabIndex = 278;
            this.labelControl23.Text = "Estado:";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(11, 271);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(55, 15);
            this.labelControl20.TabIndex = 276;
            this.labelControl20.Text = "Endereço:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(398, 297);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(50, 20);
            this.labelControl15.TabIndex = 275;
            this.labelControl15.Text = "Cidade:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(700, 297);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(43, 20);
            this.labelControl14.TabIndex = 274;
            this.labelControl14.Text = "Bairro:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(631, 355);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(98, 20);
            this.labelControl13.TabIndex = 273;
            this.labelControl13.Text = "Complemento:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(455, 357);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(57, 20);
            this.labelControl12.TabIndex = 272;
            this.labelControl12.Text = "Número:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(6, 355);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(81, 20);
            this.labelControl11.TabIndex = 271;
            this.labelControl11.Text = "Logradouro:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(398, 325);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Properties.Appearance.Options.UseFont = true;
            this.txtCidade.Size = new System.Drawing.Size(223, 26);
            this.txtCidade.TabIndex = 264;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidade_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(700, 325);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Properties.Appearance.Options.UseFont = true;
            this.txtBairro.Size = new System.Drawing.Size(223, 26);
            this.txtBairro.TabIndex = 265;
            this.txtBairro.EditValueChanged += new System.EventHandler(this.txtBairro_EditValueChanged);
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(631, 383);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Properties.Appearance.Options.UseFont = true;
            this.txtComplemento.Properties.MaxLength = 100;
            this.txtComplemento.Size = new System.Drawing.Size(292, 26);
            this.txtComplemento.TabIndex = 268;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(455, 383);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Properties.Appearance.Options.UseFont = true;
            this.txtNumero.Size = new System.Drawing.Size(124, 26);
            this.txtNumero.TabIndex = 267;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(6, 383);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Properties.Appearance.Options.UseFont = true;
            this.txtLogradouro.Properties.MaxLength = 100;
            this.txtLogradouro.Size = new System.Drawing.Size(398, 26);
            this.txtLogradouro.TabIndex = 266;
            // 
            // btnBuscarPorCEP
            // 
            this.btnBuscarPorCEP.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.lupa_preta;
            this.btnBuscarPorCEP.Location = new System.Drawing.Point(151, 325);
            this.btnBuscarPorCEP.Name = "btnBuscarPorCEP";
            this.btnBuscarPorCEP.Size = new System.Drawing.Size(31, 26);
            this.btnBuscarPorCEP.TabIndex = 262;
            this.btnBuscarPorCEP.ToolTip = "Consultar\r\n    CEP";
            this.btnBuscarPorCEP.Click += new System.EventHandler(this.btnBuscarPorCEP_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(6, 297);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(28, 20);
            this.labelControl10.TabIndex = 270;
            this.labelControl10.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(6, 325);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Properties.Appearance.Options.UseFont = true;
            this.txtCEP.Size = new System.Drawing.Size(138, 26);
            this.txtCEP.TabIndex = 261;
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox1.Location = new System.Drawing.Point(-160, 269);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1238, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 277;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(11, 172);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(52, 15);
            this.labelControl19.TabIndex = 286;
            this.labelControl19.Text = "Contatos:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(688, 197);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(92, 20);
            this.labelControl8.TabIndex = 284;
            this.labelControl8.Text = "Telefone Fixo:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(379, 197);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 20);
            this.labelControl7.TabIndex = 283;
            this.labelControl7.Text = "Celular:";
            // 
            // txtTelefoneFixo
            // 
            this.txtTelefoneFixo.Location = new System.Drawing.Point(688, 225);
            this.txtTelefoneFixo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefoneFixo.Name = "txtTelefoneFixo";
            this.txtTelefoneFixo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneFixo.Properties.Appearance.Options.UseFont = true;
            this.txtTelefoneFixo.Size = new System.Drawing.Size(235, 26);
            this.txtTelefoneFixo.TabIndex = 281;
            this.txtTelefoneFixo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneFixo_KeyPress);
            this.txtTelefoneFixo.Leave += new System.EventHandler(this.txtTelefoneResidencial_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(379, 225);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Properties.Appearance.Options.UseFont = true;
            this.txtCelular.Size = new System.Drawing.Size(235, 26);
            this.txtCelular.TabIndex = 280;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(6, 197);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 20);
            this.labelControl5.TabIndex = 282;
            this.labelControl5.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 225);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(293, 26);
            this.txtEmail.TabIndex = 279;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-160, 170);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1238, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 285;
            this.pictureBox6.TabStop = false;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.informacao20;
            this.pictureEdit3.Location = new System.Drawing.Point(735, 355);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.ZoomAcceleration = 5D;
            this.pictureEdit3.Size = new System.Drawing.Size(23, 20);
            this.pictureEdit3.TabIndex = 287;
            this.pictureEdit3.ToolTip = "O Complemento é um campo opcional.";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(11, 2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(87, 15);
            this.labelControl16.TabIndex = 289;
            this.labelControl16.Text = "Dados Empresa:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox2.Location = new System.Drawing.Point(-160, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1238, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 288;
            this.pictureBox2.TabStop = false;
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
            this.btnSalvar.Location = new System.Drawing.Point(791, 432);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 30);
            this.btnSalvar.TabIndex = 290;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(6, 118);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Properties.Appearance.Options.UseFont = true;
            this.txtNomeFantasia.Properties.MaxLength = 100;
            this.txtNomeFantasia.Size = new System.Drawing.Size(446, 26);
            this.txtNomeFantasia.TabIndex = 247;
            this.txtNomeFantasia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFantasia_KeyPress);
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
            // frmDadosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 477);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtTelefoneFixo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.labelControl23);
            this.Controls.Add(this.labelControl20);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.btnBuscarPorCEP);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtInscricaoMunicipal);
            this.Controls.Add(this.txtInscricaoEstadual);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDadosEmpresa";
            this.Text = "frmNovoUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.txtInscricaoMunicipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInscricaoEstadual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazaoSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCNPJ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogradouro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCEP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefoneFixo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFantasia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtInscricaoMunicipal;
        private DevExpress.XtraEditors.TextEdit txtInscricaoEstadual;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtRazaoSocial;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCNPJ;
        private DevExpress.XtraEditors.LookUpEdit cmbEstado;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtCidade;
        private DevExpress.XtraEditors.TextEdit txtBairro;
        private DevExpress.XtraEditors.TextEdit txtComplemento;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.TextEdit txtLogradouro;
        private DevExpress.XtraEditors.SimpleButton btnBuscarPorCEP;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtCEP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTelefoneFixo;
        private DevExpress.XtraEditors.TextEdit txtCelular;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.TextEdit txtNomeFantasia;
        private DevExpress.XtraBars.Alerter.AlertControl AlertaSalvar;
    }
}