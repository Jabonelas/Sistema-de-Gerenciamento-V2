namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmConexaoBanco
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
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtNomeServidor = new DevExpress.XtraEditors.TextEdit();
            this.btnConectar = new DevExpress.XtraEditors.SimpleButton();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.txtBanco = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeServidor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(26, 36);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(103, 20);
            this.labelControl9.TabIndex = 132;
            this.labelControl9.Text = "Nome Servidor:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.delete_database_20px;
            this.btnCancelar.ImageOptions.ImageIndex = 5;
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnCancelar.ImageOptions.ImageToTextIndent = 10;
            this.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(267, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(179, 30);
            this.btnCancelar.TabIndex = 133;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNomeServidor
            // 
            this.txtNomeServidor.EditValue = "ISRAEL\\\\SQLEXPRESS";
            this.txtNomeServidor.Location = new System.Drawing.Point(26, 64);
            this.txtNomeServidor.Name = "txtNomeServidor";
            this.txtNomeServidor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeServidor.Properties.Appearance.Options.UseFont = true;
            this.txtNomeServidor.Properties.MaxLength = 20;
            this.txtNomeServidor.Size = new System.Drawing.Size(205, 34);
            this.txtNomeServidor.TabIndex = 131;
            // 
            // btnConectar
            // 
            this.btnConectar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Appearance.Options.UseFont = true;
            this.btnConectar.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.database_view_20px;
            this.btnConectar.ImageOptions.ImageIndex = 5;
            this.btnConectar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnConectar.ImageOptions.ImageToTextIndent = 10;
            this.btnConectar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnConectar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConectar.Location = new System.Drawing.Point(52, 255);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(179, 30);
            this.btnConectar.TabIndex = 130;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
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
            this.btnFechar.Location = new System.Drawing.Point(469, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 129;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtBanco
            // 
            this.txtBanco.EditValue = "SistemaDeGerenciamento2_0";
            this.txtBanco.Location = new System.Drawing.Point(267, 64);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanco.Properties.Appearance.Options.UseFont = true;
            this.txtBanco.Properties.MaxLength = 20;
            this.txtBanco.Size = new System.Drawing.Size(203, 34);
            this.txtBanco.TabIndex = 134;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(267, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 20);
            this.labelControl1.TabIndex = 135;
            this.labelControl1.Text = "Banco:";
            // 
            // txtLogin
            // 
            this.txtLogin.EditValue = "sa";
            this.txtLogin.Location = new System.Drawing.Point(26, 164);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Properties.Appearance.Options.UseFont = true;
            this.txtLogin.Properties.MaxLength = 20;
            this.txtLogin.Size = new System.Drawing.Size(205, 34);
            this.txtLogin.TabIndex = 136;
            // 
            // txtSenha
            // 
            this.txtSenha.EditValue = "12345";
            this.txtSenha.Location = new System.Drawing.Point(267, 164);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Properties.Appearance.Options.UseFont = true;
            this.txtSenha.Properties.MaxLength = 20;
            this.txtSenha.Size = new System.Drawing.Size(203, 34);
            this.txtSenha.TabIndex = 137;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 20);
            this.labelControl2.TabIndex = 138;
            this.labelControl2.Text = "Login:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(268, 138);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 20);
            this.labelControl3.TabIndex = 139;
            this.labelControl3.Text = "Senha:";
            // 
            // frmConexaoBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 320);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNomeServidor);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmConexaoBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConexaoBanco";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConexaoBanco_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmConexaoBanco_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmConexaoBanco_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeServidor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.SimpleButton btnConectar;
        private DevExpress.XtraEditors.TextEdit txtNomeServidor;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.TextEdit txtBanco;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}