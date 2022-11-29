namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnGerarExecel = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscarProduto = new DevExpress.XtraEditors.SimpleButton();
            this.btnLimparFiltro = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdicionarGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.cmbFinalidade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtBuscarProduto = new DevExpress.XtraEditors.TextEdit();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cmbMaisOpacoes = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinalidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscarProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaisOpacoes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 20);
            this.labelControl3.TabIndex = 98;
            this.labelControl3.Text = "Consultar Produtos";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(442, 197);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 20);
            this.labelControl7.TabIndex = 99;
            this.labelControl7.Text = "Tipo Produto:";
            // 
            // btnGerarExecel
            // 
            this.btnGerarExecel.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnGerarExecel.Appearance.Options.UseBorderColor = true;
            this.btnGerarExecel.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnGerarExecel.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnGerarExecel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGerarExecel.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.tabela;
            this.btnGerarExecel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnGerarExecel.Location = new System.Drawing.Point(1098, 82);
            this.btnGerarExecel.Name = "btnGerarExecel";
            this.btnGerarExecel.Size = new System.Drawing.Size(26, 26);
            this.btnGerarExecel.TabIndex = 105;
            this.btnGerarExecel.ToolTip = "Exportar para Execel";
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnBuscarProduto.Appearance.Options.UseBorderColor = true;
            this.btnBuscarProduto.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnBuscarProduto.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnBuscarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarProduto.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.lupa_preta;
            this.btnBuscarProduto.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscarProduto.Location = new System.Drawing.Point(316, 130);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(26, 26);
            this.btnBuscarProduto.TabIndex = 104;
            this.btnBuscarProduto.ToolTip = "Pesquisar";
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnLimparFiltro.Appearance.Options.UseBorderColor = true;
            this.btnLimparFiltro.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnLimparFiltro.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnLimparFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparFiltro.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.limpar_preto;
            this.btnLimparFiltro.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLimparFiltro.Location = new System.Drawing.Point(348, 130);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(26, 26);
            this.btnLimparFiltro.TabIndex = 103;
            this.btnLimparFiltro.ToolTip = "Limpar Filtro";
            this.btnLimparFiltro.Click += new System.EventHandler(this.simpleButton2_Click);
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
            this.btnAdicionarGrupo.Location = new System.Drawing.Point(12, 77);
            this.btnAdicionarGrupo.Name = "btnAdicionarGrupo";
            this.btnAdicionarGrupo.Size = new System.Drawing.Size(217, 30);
            this.btnAdicionarGrupo.TabIndex = 100;
            this.btnAdicionarGrupo.Text = "Adicionar Novo Produto";
            // 
            // cmbFinalidade
            // 
            this.cmbFinalidade.Location = new System.Drawing.Point(432, 130);
            this.cmbFinalidade.Name = "cmbFinalidade";
            this.cmbFinalidade.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFinalidade.Properties.Appearance.Options.UseFont = true;
            this.cmbFinalidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFinalidade.Properties.Items.AddRange(new object[] {
            "Todos os produtos",
            "Estoque positivo",
            "Estoque baixo (menor que o mínimo)",
            "Estoque zaro ou negativo"});
            this.cmbFinalidade.Size = new System.Drawing.Size(259, 26);
            this.cmbFinalidade.TabIndex = 97;
            // 
            // txtBuscarProduto
            // 
            this.txtBuscarProduto.EditValue = "Buscar Produto";
            this.txtBuscarProduto.Location = new System.Drawing.Point(12, 130);
            this.txtBuscarProduto.Name = "txtBuscarProduto";
            this.txtBuscarProduto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProduto.Properties.Appearance.Options.UseFont = true;
            this.txtBuscarProduto.Properties.MaxLength = 20;
            this.txtBuscarProduto.Size = new System.Drawing.Size(298, 26);
            this.txtBuscarProduto.TabIndex = 96;
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
            this.btnFechar.Location = new System.Drawing.Point(1137, -2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 94;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-182, 38);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1517, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 95;
            this.pictureBox6.TabStop = false;
            // 
            // cmbMaisOpacoes
            // 
            this.cmbMaisOpacoes.EditValue = "Mais Opções";
            this.cmbMaisOpacoes.Location = new System.Drawing.Point(251, 74);
            this.cmbMaisOpacoes.Name = "cmbMaisOpacoes";
            this.cmbMaisOpacoes.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaisOpacoes.Properties.Appearance.Options.UseFont = true;
            this.cmbMaisOpacoes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMaisOpacoes.Properties.Items.AddRange(new object[] {
            "Todos os produtos",
            "Estoque positivo",
            "Estoque baixo (menor que o mínimo)",
            "Estoque zaro ou negativo"});
            this.cmbMaisOpacoes.Size = new System.Drawing.Size(247, 26);
            this.cmbMaisOpacoes.TabIndex = 106;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 414);
            this.Controls.Add(this.cmbMaisOpacoes);
            this.Controls.Add(this.btnGerarExecel);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.btnLimparFiltro);
            this.Controls.Add(this.btnAdicionarGrupo);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbFinalidade);
            this.Controls.Add(this.txtBuscarProduto);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdutos";
            this.Text = "frmProdutos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinalidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscarProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaisOpacoes.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFinalidade;
        private DevExpress.XtraEditors.TextEdit txtBuscarProduto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarGrupo;
        private DevExpress.XtraEditors.SimpleButton btnLimparFiltro;
        private DevExpress.XtraEditors.SimpleButton btnBuscarProduto;
        private DevExpress.XtraEditors.SimpleButton btnGerarExecel;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMaisOpacoes;
    }
}