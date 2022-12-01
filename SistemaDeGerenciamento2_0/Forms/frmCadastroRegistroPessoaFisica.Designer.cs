namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmCadastroRegistroPessoaFisica
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLocalArquivo = new DevExpress.XtraEditors.TextEdit();
            this.cmbTipoPessoa = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pcbRequesitosCodigo = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalArquivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRequesitosCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 20);
            this.labelControl2.TabIndex = 138;
            this.labelControl2.Text = "CPF:";
            // 
            // txtLocalArquivo
            // 
            this.txtLocalArquivo.Location = new System.Drawing.Point(13, 40);
            this.txtLocalArquivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocalArquivo.Name = "txtLocalArquivo";
            this.txtLocalArquivo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalArquivo.Properties.Appearance.Options.UseFont = true;
            this.txtLocalArquivo.Size = new System.Drawing.Size(256, 26);
            this.txtLocalArquivo.TabIndex = 137;
            // 
            // cmbTipoPessoa
            // 
            this.cmbTipoPessoa.Location = new System.Drawing.Point(462, 107);
            this.cmbTipoPessoa.Name = "cmbTipoPessoa";
            this.cmbTipoPessoa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPessoa.Properties.Appearance.Options.UseFont = true;
            this.cmbTipoPessoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoPessoa.Properties.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Não Binario"});
            this.cmbTipoPessoa.Size = new System.Drawing.Size(194, 26);
            this.cmbTipoPessoa.TabIndex = 139;
            // 
            // pcbRequesitosCodigo
            // 
            this.pcbRequesitosCodigo.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.informacao20;
            this.pcbRequesitosCodigo.Location = new System.Drawing.Point(557, 46);
            this.pcbRequesitosCodigo.Name = "pcbRequesitosCodigo";
            this.pcbRequesitosCodigo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcbRequesitosCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.pcbRequesitosCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcbRequesitosCodigo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcbRequesitosCodigo.Properties.ZoomAcceleration = 5D;
            this.pcbRequesitosCodigo.Size = new System.Drawing.Size(23, 20);
            this.pcbRequesitosCodigo.TabIndex = 140;
            this.pcbRequesitosCodigo.ToolTip = "De 1 até 20 caracteres\r\ncom letras e números, \r\nsem caracteres especiais \r\ncomo e" +
    "spaço e símbolos.";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 20);
            this.labelControl1.TabIndex = 141;
            this.labelControl1.Text = "Nome:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(13, 107);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(393, 26);
            this.textEdit1.TabIndex = 142;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(433, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 20);
            this.labelControl3.TabIndex = 143;
            this.labelControl3.Text = "Sexo:";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(712, 107);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(293, 26);
            this.textEdit2.TabIndex = 144;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(688, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(22, 20);
            this.labelControl4.TabIndex = 145;
            this.labelControl4.Text = "RG:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 151);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(118, 20);
            this.labelControl5.TabIndex = 146;
            this.labelControl5.Text = "Data Nascimento:";
            // 
            // frmCadastroRegistroPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 533);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pcbRequesitosCodigo);
            this.Controls.Add(this.cmbTipoPessoa);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtLocalArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroRegistroPessoaFisica";
            this.Text = "frmCadastroRegistroPessoaFisica";
            this.Load += new System.EventHandler(this.frmCadastroRegistroPessoaFisica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalArquivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRequesitosCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLocalArquivo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoPessoa;
        private DevExpress.XtraEditors.PictureEdit pcbRequesitosCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}