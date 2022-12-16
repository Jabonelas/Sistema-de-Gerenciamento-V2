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
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.btnFuncionario = new DevExpress.XtraEditors.SimpleButton();
            this.btnFornecedor = new DevExpress.XtraEditors.SimpleButton();
            this.btnCliente = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTipoPessoa = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pnlCadastroRegistro = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 46);
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
            // btnFuncionario
            // 
            this.btnFuncionario.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Appearance.Options.UseFont = true;
            this.btnFuncionario.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.funcionario_20;
            this.btnFuncionario.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnFuncionario.Location = new System.Drawing.Point(967, 72);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(80, 43);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.ToolTip = "Funcionário";
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.Appearance.Options.UseFont = true;
            this.btnFornecedor.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.fornecedor_20px;
            this.btnFornecedor.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnFornecedor.Location = new System.Drawing.Point(868, 72);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(80, 43);
            this.btnFornecedor.TabIndex = 2;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.ToolTip = "Forncedor";
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.cliente;
            this.btnCliente.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCliente.Location = new System.Drawing.Point(767, 72);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(80, 43);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.ToolTip = "Cliente";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // cmbTipoPessoa
            // 
            this.cmbTipoPessoa.Location = new System.Drawing.Point(29, 72);
            this.cmbTipoPessoa.Name = "cmbTipoPessoa";
            this.cmbTipoPessoa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPessoa.Properties.Appearance.Options.UseFont = true;
            this.cmbTipoPessoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoPessoa.Properties.Items.AddRange(new object[] {
            "Pessoa Fisica",
            "Pessoa Juridica"});
            this.cmbTipoPessoa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTipoPessoa.Size = new System.Drawing.Size(243, 26);
            this.cmbTipoPessoa.TabIndex = 0;
            this.cmbTipoPessoa.SelectedValueChanged += new System.EventHandler(this.cmbTipoPessoa_SelectedValueChanged);
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
            // pnlCadastroRegistro
            // 
            this.pnlCadastroRegistro.AutoScroll = true;
            this.pnlCadastroRegistro.Location = new System.Drawing.Point(15, 136);
            this.pnlCadastroRegistro.Name = "pnlCadastroRegistro";
            this.pnlCadastroRegistro.Size = new System.Drawing.Size(1041, 582);
            this.pnlCadastroRegistro.TabIndex = 138;
            // 
            // frmCadastroRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 723);
            this.Controls.Add(this.pnlCadastroRegistro);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbTipoPessoa);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCadastroRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroRegistros";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroRegistros_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoPessoa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCliente;
        private DevExpress.XtraEditors.SimpleButton btnFornecedor;
        private DevExpress.XtraEditors.SimpleButton btnFuncionario;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.FlowLayoutPanel pnlCadastroRegistro;
    }
}