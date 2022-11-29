namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmCadastroGrupoSubGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroGrupoSubGrupo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarSubGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdicionarGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grupo,
            this.SubGrupo});
            this.dataGridView1.Location = new System.Drawing.Point(30, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 187);
            this.dataGridView1.TabIndex = 75;
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.Width = 220;
            // 
            // SubGrupo
            // 
            this.SubGrupo.HeaderText = "SubGrupo";
            this.SubGrupo.Name = "SubGrupo";
            this.SubGrupo.Width = 220;
            // 
            // btnAdicionarSubGrupo
            // 
            this.btnAdicionarSubGrupo.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarSubGrupo.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarSubGrupo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarSubGrupo.Appearance.Options.UseBorderColor = true;
            this.btnAdicionarSubGrupo.Appearance.Options.UseFont = true;
            this.btnAdicionarSubGrupo.AppearanceDisabled.BackColor = System.Drawing.Color.Yellow;
            this.btnAdicionarSubGrupo.AppearanceDisabled.BackColor2 = System.Drawing.Color.Yellow;
            this.btnAdicionarSubGrupo.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAdicionarSubGrupo.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.btnAdicionarSubGrupo.AppearanceHovered.BackColor2 = System.Drawing.Color.Red;
            this.btnAdicionarSubGrupo.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdicionarSubGrupo.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarSubGrupo.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarSubGrupo.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarSubGrupo.AppearancePressed.Options.UseBackColor = true;
            this.btnAdicionarSubGrupo.AppearancePressed.Options.UseBorderColor = true;
            this.btnAdicionarSubGrupo.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.adcao9;
            this.btnAdicionarSubGrupo.ImageOptions.ImageIndex = 5;
            this.btnAdicionarSubGrupo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnAdicionarSubGrupo.ImageOptions.ImageToTextIndent = 10;
            this.btnAdicionarSubGrupo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdicionarSubGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdicionarSubGrupo.Location = new System.Drawing.Point(292, 62);
            this.btnAdicionarSubGrupo.Name = "btnAdicionarSubGrupo";
            this.btnAdicionarSubGrupo.Size = new System.Drawing.Size(217, 30);
            this.btnAdicionarSubGrupo.TabIndex = 73;
            this.btnAdicionarSubGrupo.Text = "Adicionar Sub-Grupo de Produto";
            this.btnAdicionarSubGrupo.Click += new System.EventHandler(this.btnAdicionarSubGrupo_Click);
            // 
            // btnAdicionarGrupo
            // 
            this.btnAdicionarGrupo.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarGrupo.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarGrupo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarGrupo.Appearance.Options.UseBorderColor = true;
            this.btnAdicionarGrupo.Appearance.Options.UseFont = true;
            this.btnAdicionarGrupo.AppearanceDisabled.BackColor = System.Drawing.Color.Yellow;
            this.btnAdicionarGrupo.AppearanceDisabled.BackColor2 = System.Drawing.Color.Yellow;
            this.btnAdicionarGrupo.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAdicionarGrupo.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.btnAdicionarGrupo.AppearanceHovered.BackColor2 = System.Drawing.Color.Red;
            this.btnAdicionarGrupo.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdicionarGrupo.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarGrupo.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarGrupo.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnAdicionarGrupo.AppearancePressed.Options.UseBackColor = true;
            this.btnAdicionarGrupo.AppearancePressed.Options.UseBorderColor = true;
            this.btnAdicionarGrupo.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.adcao9;
            this.btnAdicionarGrupo.ImageOptions.ImageIndex = 5;
            this.btnAdicionarGrupo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnAdicionarGrupo.ImageOptions.ImageToTextIndent = 10;
            this.btnAdicionarGrupo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdicionarGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdicionarGrupo.Location = new System.Drawing.Point(49, 62);
            this.btnAdicionarGrupo.Name = "btnAdicionarGrupo";
            this.btnAdicionarGrupo.Size = new System.Drawing.Size(217, 30);
            this.btnAdicionarGrupo.TabIndex = 72;
            this.btnAdicionarGrupo.Text = "Adicionar Grupo de Produto";
            this.btnAdicionarGrupo.Click += new System.EventHandler(this.btnAdicionarGrupo_Click);
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
            this.btnFechar.Location = new System.Drawing.Point(564, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 71;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-75, 35);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(730, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 74;
            this.pictureBox6.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 20);
            this.labelControl3.TabIndex = 80;
            this.labelControl3.Text = "Grupo de Produto";
            // 
            // frmCadastroGrupoSubGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 348);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdicionarSubGrupo);
            this.Controls.Add(this.btnAdicionarGrupo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCadastroGrupoSubGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraForm1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroGrupoSubGrupo_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCadastroGrupoSubGrupo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCadastroGrupoSubGrupo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubGrupo;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarSubGrupo;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarGrupo;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}