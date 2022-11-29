namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmFinanceiro
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
            this.btnAdicionarXML = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarXML
            // 
            this.btnAdicionarXML.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarXML.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarXML.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarXML.Appearance.Options.UseBorderColor = true;
            this.btnAdicionarXML.Appearance.Options.UseFont = true;
            this.btnAdicionarXML.AppearanceDisabled.BackColor = System.Drawing.Color.Yellow;
            this.btnAdicionarXML.AppearanceDisabled.BackColor2 = System.Drawing.Color.Yellow;
            this.btnAdicionarXML.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAdicionarXML.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.btnAdicionarXML.AppearanceHovered.BackColor2 = System.Drawing.Color.Red;
            this.btnAdicionarXML.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdicionarXML.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarXML.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarXML.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarXML.AppearancePressed.Options.UseBackColor = true;
            this.btnAdicionarXML.AppearancePressed.Options.UseBorderColor = true;
            this.btnAdicionarXML.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.adcao9;
            this.btnAdicionarXML.ImageOptions.ImageIndex = 5;
            this.btnAdicionarXML.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnAdicionarXML.ImageOptions.ImageToTextIndent = 10;
            this.btnAdicionarXML.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdicionarXML.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdicionarXML.Location = new System.Drawing.Point(320, 30);
            this.btnAdicionarXML.Name = "btnAdicionarXML";
            this.btnAdicionarXML.Size = new System.Drawing.Size(217, 30);
            this.btnAdicionarXML.TabIndex = 74;
            this.btnAdicionarXML.Text = "Adicionar XML";
            this.btnAdicionarXML.Click += new System.EventHandler(this.btnAdicionarXML_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(41, 274);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.MaxLength = 20;
            this.txtCodigo.Size = new System.Drawing.Size(243, 26);
            this.txtCodigo.TabIndex = 77;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 248);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 20);
            this.labelControl1.TabIndex = 78;
            this.labelControl1.Text = "Código:";
            // 
            // frmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 347);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnAdicionarXML);
            this.Name = "frmFinanceiro";
            this.Text = "frmFinanceiro";
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdicionarXML;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}