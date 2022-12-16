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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracoes));
            this.btnPerfil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEmpresa = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovoUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.pnlConfiguracoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
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
            this.btnPerfil.ToolTip = "Dados do Perfil Logado";
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
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
            this.btnEmpresa.ToolTip = "Cadastrar Dados da Empresa";
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.cadastro_20;
            this.btnNovoUsuario.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnNovoUsuario.Location = new System.Drawing.Point(334, 12);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(80, 43);
            this.btnNovoUsuario.TabIndex = 124;
            this.btnNovoUsuario.Text = "Novo Usuário";
            this.btnNovoUsuario.ToolTip = "Cadastrar Novo Usuário";
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // pnlConfiguracoes
            // 
            this.pnlConfiguracoes.Location = new System.Drawing.Point(5, 80);
            this.pnlConfiguracoes.Name = "pnlConfiguracoes";
            this.pnlConfiguracoes.Size = new System.Drawing.Size(944, 542);
            this.pnlConfiguracoes.TabIndex = 128;
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
            this.btnFechar.Location = new System.Drawing.Point(929, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 129;
            this.btnFechar.Visible = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 622);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlConfiguracoes);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnNovoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfiguracoes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConfiguracoes_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmConfiguracoes_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmConfiguracoes_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnPerfil;
        private DevExpress.XtraEditors.SimpleButton btnEmpresa;
        private DevExpress.XtraEditors.SimpleButton btnNovoUsuario;
        private System.Windows.Forms.FlowLayoutPanel pnlConfiguracoes;
        public DevExpress.XtraEditors.SimpleButton btnFechar;
    }
}