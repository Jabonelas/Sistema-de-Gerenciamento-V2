namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmCadastroCategoriaDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCategoriaDespesa));
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.AlertaSalvar = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.cmbCategoriaAgrupadora = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbCusto = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtCategoria = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategoriaAgrupadora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCusto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(30, 11);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(241, 20);
            this.labelControl13.TabIndex = 104;
            this.labelControl13.Text = "Cadastrar Nova Categoria Despesa";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(30, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(152, 20);
            this.labelControl2.TabIndex = 106;
            this.labelControl2.Text = "Categoria Agrupadora:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 141);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 20);
            this.labelControl1.TabIndex = 109;
            this.labelControl1.Text = "Categoria:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(30, 212);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 20);
            this.labelControl4.TabIndex = 110;
            this.labelControl4.Text = "Custo:";
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
            // cmbCategoriaAgrupadora
            // 
            this.cmbCategoriaAgrupadora.Location = new System.Drawing.Point(30, 94);
            this.cmbCategoriaAgrupadora.Name = "cmbCategoriaAgrupadora";
            this.cmbCategoriaAgrupadora.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaAgrupadora.Properties.Appearance.Options.UseFont = true;
            this.cmbCategoriaAgrupadora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategoriaAgrupadora.Properties.Items.AddRange(new object[] {
            "Sem Categoria Agrupadora",
            "Impostos"});
            this.cmbCategoriaAgrupadora.Properties.MaxLength = 20;
            this.cmbCategoriaAgrupadora.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbCategoriaAgrupadora.Size = new System.Drawing.Size(243, 26);
            this.cmbCategoriaAgrupadora.TabIndex = 113;
            // 
            // cmbCusto
            // 
            this.cmbCusto.Location = new System.Drawing.Point(30, 238);
            this.cmbCusto.Name = "cmbCusto";
            this.cmbCusto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCusto.Properties.Appearance.Options.UseFont = true;
            this.cmbCusto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCusto.Properties.Items.AddRange(new object[] {
            "Fixo",
            "Variavel",
            "Imobilizado"});
            this.cmbCusto.Properties.MaxLength = 20;
            this.cmbCusto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbCusto.Size = new System.Drawing.Size(243, 26);
            this.cmbCusto.TabIndex = 112;
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
            this.btnCancelar.Location = new System.Drawing.Point(160, 296);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 30);
            this.btnCancelar.TabIndex = 107;
            this.btnCancelar.Text = "Cancelar (Esc)";
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
            this.btnSalvar.Location = new System.Drawing.Point(30, 296);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 30);
            this.btnSalvar.TabIndex = 108;
            this.btnSalvar.Text = "Salvar (F10)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.btnFechar.Location = new System.Drawing.Point(297, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 102;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-31, 37);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(382, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 103;
            this.pictureBox6.TabStop = false;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(30, 167);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Properties.Appearance.Options.UseFont = true;
            this.txtCategoria.Size = new System.Drawing.Size(243, 26);
            this.txtCategoria.TabIndex = 114;
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress_1);
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // frmCadastroCategoriaDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 342);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.cmbCategoriaAgrupadora);
            this.Controls.Add(this.cmbCusto);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroCategoriaDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroCategoriaDespesa";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCadastroCategoriaDespesa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCadastroCategoriaDespesa_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategoriaAgrupadora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCusto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCusto;
        private DevExpress.XtraBars.Alerter.AlertControl AlertaSalvar;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCategoriaAgrupadora;
        private DevExpress.XtraEditors.TextEdit txtCategoria;
    }
}