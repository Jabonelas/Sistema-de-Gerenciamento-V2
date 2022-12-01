namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmCadastroGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroGrupo));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.cmbAgrupador = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNomeGrupo = new DevExpress.XtraEditors.TextEdit();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.AlertaSalvar = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmbAgrupador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(168, 20);
            this.labelControl3.TabIndex = 80;
            this.labelControl3.Text = "Novo Grupo de Produto";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 75);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 20);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "Nome do Grupo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.cancelar;
            this.btnCancelar.ImageOptions.ImageIndex = 5;
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnCancelar.ImageOptions.ImageToTextIndent = 10;
            this.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(373, 183);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 30);
            this.btnCancelar.TabIndex = 105;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnSalvar.Location = new System.Drawing.Point(243, 183);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 30);
            this.btnSalvar.TabIndex = 104;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbAgrupador
            // 
            this.cmbAgrupador.Location = new System.Drawing.Point(286, 101);
            this.cmbAgrupador.Name = "cmbAgrupador";
            this.cmbAgrupador.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgrupador.Properties.Appearance.Options.UseFont = true;
            this.cmbAgrupador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAgrupador.Size = new System.Drawing.Size(200, 26);
            this.cmbAgrupador.TabIndex = 97;
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Location = new System.Drawing.Point(29, 101);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGrupo.Properties.Appearance.Options.UseFont = true;
            this.txtNomeGrupo.Size = new System.Drawing.Size(200, 26);
            this.txtNomeGrupo.TabIndex = 96;
            this.txtNomeGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeGrupo_KeyPress);
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
            this.btnFechar.Location = new System.Drawing.Point(489, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 94;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-64, 35);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(634, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 95;
            this.pictureBox6.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(286, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 20);
            this.labelControl2.TabIndex = 99;
            this.labelControl2.Text = "Nome Agrupador:";
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
            // frmAdicionarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 225);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbAgrupador);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmAdicionarGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdicionarGrupo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAdicionarGrupo_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAdicionarGrupo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAdicionarGrupo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.cmbAgrupador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.TextEdit txtNomeGrupo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAgrupador;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.Alerter.AlertControl AlertaSalvar;
    }
}