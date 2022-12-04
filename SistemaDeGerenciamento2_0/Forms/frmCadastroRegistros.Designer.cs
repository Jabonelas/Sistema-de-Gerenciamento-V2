namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmCadastroRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroRegistros));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.pnlCadastroRegistro = new DevExpress.XtraEditors.PanelControl();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnFuncionario = new DevExpress.XtraEditors.SimpleButton();
            this.bntFornecedor = new DevExpress.XtraEditors.SimpleButton();
            this.btnCliente = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTipoPessoa = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCadastroRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoPessoa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(41, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 20);
            this.labelControl3.TabIndex = 87;
            this.labelControl3.Text = "Tipo Pessoa:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(767, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(181, 20);
            this.labelControl1.TabIndex = 88;
            this.labelControl1.Text = "Marque os tipos desejados:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(29, 3);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(167, 20);
            this.labelControl13.TabIndex = 122;
            this.labelControl13.Text = "Cadastro Novo Registro";
            // 
            // pnlCadastroRegistro
            // 
            this.pnlCadastroRegistro.Location = new System.Drawing.Point(29, 126);
            this.pnlCadastroRegistro.Name = "pnlCadastroRegistro";
            this.pnlCadastroRegistro.Size = new System.Drawing.Size(1018, 593);
            this.pnlCadastroRegistro.TabIndex = 137;
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
            this.btnFechar.Location = new System.Drawing.Point(1048, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 121;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-158, 18);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1389, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 119;
            this.pictureBox6.TabStop = false;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Appearance.Options.UseFont = true;
            this.btnFuncionario.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.funcionario_20;
            this.btnFuncionario.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnFuncionario.Location = new System.Drawing.Point(967, 72);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(80, 43);
            this.btnFuncionario.TabIndex = 92;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.ToolTip = "Funcionário";
            // 
            // bntFornecedor
            // 
            this.bntFornecedor.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntFornecedor.Appearance.Options.UseFont = true;
            this.bntFornecedor.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.fornecedor_20px;
            this.bntFornecedor.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.bntFornecedor.Location = new System.Drawing.Point(868, 72);
            this.bntFornecedor.Name = "bntFornecedor";
            this.bntFornecedor.Size = new System.Drawing.Size(80, 43);
            this.bntFornecedor.TabIndex = 91;
            this.bntFornecedor.Text = "Fornecedor";
            this.bntFornecedor.ToolTip = "Forncedor";
            // 
            // btnCliente
            // 
            this.btnCliente.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Appearance.Options.UseFont = true;
            this.btnCliente.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.AppearanceHovered.BackColor2 = System.Drawing.Color.Transparent;
            this.btnCliente.AppearanceHovered.Options.UseBackColor = true;
            this.btnCliente.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.AppearancePressed.BackColor2 = System.Drawing.Color.Transparent;
            this.btnCliente.AppearancePressed.Options.UseBackColor = true;
            this.btnCliente.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.cliente;
            this.btnCliente.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCliente.Location = new System.Drawing.Point(767, 72);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(80, 43);
            this.btnCliente.TabIndex = 90;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.ToolTip = "Cliente";
            // 
            // cmbTipoPessoa
            // 
            this.cmbTipoPessoa.Location = new System.Drawing.Point(41, 72);
            this.cmbTipoPessoa.Name = "cmbTipoPessoa";
            this.cmbTipoPessoa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPessoa.Properties.Appearance.Options.UseFont = true;
            this.cmbTipoPessoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoPessoa.Properties.Items.AddRange(new object[] {
            "Pessoa Fisica",
            "Pessoa Juridica"});
            this.cmbTipoPessoa.Size = new System.Drawing.Size(243, 26);
            this.cmbTipoPessoa.TabIndex = 86;
            this.cmbTipoPessoa.SelectedValueChanged += new System.EventHandler(this.cmbTipoPessoa_SelectedValueChanged);
            // 
            // frmCadastroRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 723);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.bntFornecedor);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbTipoPessoa);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pnlCadastroRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCadastroRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroRegistros";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroRegistros_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCadastroRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoPessoa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoPessoa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCliente;
        private DevExpress.XtraEditors.SimpleButton bntFornecedor;
        private DevExpress.XtraEditors.SimpleButton btnFuncionario;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.PanelControl pnlCadastroRegistro;
    }
}