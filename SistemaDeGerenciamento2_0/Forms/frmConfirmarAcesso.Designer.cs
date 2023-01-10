namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmConfirmarAcesso
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.pcbExibirSenha = new DevExpress.XtraEditors.PictureEdit();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExibirSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(113, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 21);
            this.labelControl2.TabIndex = 134;
            this.labelControl2.Text = "Acesso Restrito";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-29, 148);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(379, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 133;
            this.pictureBox6.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(48, 243);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 20);
            this.labelControl1.TabIndex = 132;
            this.labelControl1.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.EditValue = "123456";
            this.txtSenha.Location = new System.Drawing.Point(48, 269);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Properties.Appearance.Options.UseFont = true;
            this.txtSenha.Properties.MaxLength = 20;
            this.txtSenha.Properties.UseSystemPasswordChar = true;
            this.txtSenha.Size = new System.Drawing.Size(231, 34);
            this.txtSenha.TabIndex = 126;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.exit_20px;
            this.btnCancelar.ImageOptions.ImageIndex = 5;
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnCancelar.ImageOptions.ImageToTextIndent = 10;
            this.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(176, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 30);
            this.btnCancelar.TabIndex = 128;
            this.btnCancelar.Text = "Cancelar (Esc)";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.Appearance.Options.UseFont = true;
            this.btnLogar.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.enter_20px;
            this.btnLogar.ImageOptions.ImageIndex = 5;
            this.btnLogar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnLogar.ImageOptions.ImageToTextIndent = 10;
            this.btnLogar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnLogar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogar.Location = new System.Drawing.Point(36, 325);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(113, 30);
            this.btnLogar.TabIndex = 127;
            this.btnLogar.Text = "Logar (F10)";
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(48, 175);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 20);
            this.labelControl5.TabIndex = 131;
            this.labelControl5.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.EditValue = "israel";
            this.txtUsuario.Location = new System.Drawing.Point(48, 201);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Size = new System.Drawing.Size(231, 34);
            this.txtUsuario.TabIndex = 125;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // pcbExibirSenha
            // 
            this.pcbExibirSenha.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.olho_20;
            this.pcbExibirSenha.Location = new System.Drawing.Point(101, 243);
            this.pcbExibirSenha.Name = "pcbExibirSenha";
            this.pcbExibirSenha.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcbExibirSenha.Properties.Appearance.Options.UseBackColor = true;
            this.pcbExibirSenha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcbExibirSenha.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcbExibirSenha.Properties.ZoomAcceleration = 5D;
            this.pcbExibirSenha.Size = new System.Drawing.Size(26, 20);
            this.pcbExibirSenha.TabIndex = 130;
            this.pcbExibirSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbExibirSenha_MouseDown);
            this.pcbExibirSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbExibirSenha_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.lock_error_200px;
            this.pictureBox2.Location = new System.Drawing.Point(100, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 129;
            this.pictureBox2.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnFechar.Appearance.Options.UseBorderColor = true;
            this.btnFechar.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnFechar.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.multiply1_20px;
            this.btnFechar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFechar.Location = new System.Drawing.Point(304, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 294;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmConfirmarAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 376);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pcbExibirSenha);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmConfirmarAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfirmarAcesso";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConfirmarAcesso_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmConfirmarAcesso_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmConfirmarAcesso_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExibirSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnLogar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.PictureEdit pcbExibirSenha;
        private System.Windows.Forms.PictureBox pictureBox2;
        public DevExpress.XtraEditors.SimpleButton btnFechar;
    }
}