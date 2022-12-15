namespace SistemaDeGerenciamento2_0.Forms
{
    partial class uscUsuarios
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeFuncionario = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.btnDetalhes = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Appearance.Options.UseFont = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(125, 47);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(123, 30);
            this.lblNomeFuncionario.TabIndex = 1;
            this.lblNomeFuncionario.Text = "labelControl1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Appearance.Options.UseFont = true;
            this.lblUsuario.Location = new System.Drawing.Point(137, 83);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(94, 21);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "labelControl2";
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhes.Appearance.Options.UseFont = true;
            this.btnDetalhes.Appearance.Options.UseTextOptions = true;
            this.btnDetalhes.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnDetalhes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDetalhes.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.lapis_20;
            this.btnDetalhes.ImageOptions.ImageIndex = 5;
            this.btnDetalhes.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDetalhes.ImageOptions.ImageToTextIndent = 10;
            this.btnDetalhes.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDetalhes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDetalhes.Location = new System.Drawing.Point(-4, 136);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(415, 30);
            this.btnDetalhes.TabIndex = 16;
            this.btnDetalhes.Text = "Detalhes                                                                         " +
    "                           ";
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.usuario_100;
            this.pictureEdit1.Location = new System.Drawing.Point(3, 25);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 0;
            // 
            // uscUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "uscUsuarios";
            this.Size = new System.Drawing.Size(401, 165);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblNomeFuncionario;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.SimpleButton btnDetalhes;
    }
}
