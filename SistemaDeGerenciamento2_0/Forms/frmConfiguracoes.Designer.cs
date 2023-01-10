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
            this.pnlConfiguracoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // pnlConfiguracoes
            // 
            this.pnlConfiguracoes.Location = new System.Drawing.Point(5, 30);
            this.pnlConfiguracoes.Name = "pnlConfiguracoes";
            this.pnlConfiguracoes.Size = new System.Drawing.Size(944, 570);
            this.pnlConfiguracoes.TabIndex = 128;
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
            this.btnFechar.Location = new System.Drawing.Point(927, 2);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfiguracoes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConfiguracoes_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmConfiguracoes_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmConfiguracoes_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnlConfiguracoes;
        public DevExpress.XtraEditors.SimpleButton btnFechar;
    }
}