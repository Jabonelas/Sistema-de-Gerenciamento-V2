namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmConfiguracoes
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
            this.btnPerfil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEmpresa = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovoUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.pnlConfiguracoes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnPerfil
            // 
            this.btnPerfil.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Appearance.Options.UseFont = true;
            this.btnPerfil.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.perfil;
            this.btnPerfil.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPerfil.Location = new System.Drawing.Point(534, 12);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(80, 43);
            this.btnPerfil.TabIndex = 126;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.ToolTip = "Funcionário";
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.Appearance.Options.UseFont = true;
            this.btnEmpresa.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.empresa_20;
            this.btnEmpresa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnEmpresa.Location = new System.Drawing.Point(435, 12);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(80, 43);
            this.btnEmpresa.TabIndex = 125;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.ToolTip = "Forncedor";
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.cadastro_20;
            this.btnNovoUsuario.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnNovoUsuario.Location = new System.Drawing.Point(334, 12);
            this.btnNovoUsuario.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(80, 43);
            this.btnNovoUsuario.TabIndex = 124;
            this.btnNovoUsuario.Text = "Novo Usuário";
            this.btnNovoUsuario.ToolTip = "Cliente";
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // pnlConfiguracoes
            // 
            this.pnlConfiguracoes.Location = new System.Drawing.Point(5, 80);
            this.pnlConfiguracoes.Name = "pnlConfiguracoes";
            this.pnlConfiguracoes.Size = new System.Drawing.Size(944, 477);
            this.pnlConfiguracoes.TabIndex = 128;
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 563);
            this.Controls.Add(this.pnlConfiguracoes);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnNovoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfiguracoes";
            this.Text = "frmConfiguracoes";
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnPerfil;
        private DevExpress.XtraEditors.SimpleButton btnEmpresa;
        private DevExpress.XtraEditors.SimpleButton btnNovoUsuario;
        private System.Windows.Forms.FlowLayoutPanel pnlConfiguracoes;
    }
}