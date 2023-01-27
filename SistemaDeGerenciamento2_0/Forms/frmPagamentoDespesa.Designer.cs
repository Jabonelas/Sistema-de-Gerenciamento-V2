namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmPagamentoDespesa
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtFornecedor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new DevExpress.XtraEditors.TextEdit();
            this.txtVencimento = new DevExpress.XtraEditors.TextEdit();
            this.txtCategoria = new DevExpress.XtraEditors.TextEdit();
            this.txtObservacoes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.txtValorTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtSubCategoria = new DevExpress.XtraEditors.TextEdit();
            this.txtJuros = new DevExpress.XtraEditors.TextEdit();
            this.txtDesconto = new DevExpress.XtraEditors.TextEdit();
            this.txtMulta = new DevExpress.XtraEditors.TextEdit();
            this.btnRealizarPagamento = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtParcela = new DevExpress.XtraEditors.TextEdit();
            this.AlertaSalvar = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacoes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJuros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMulta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 47);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 20);
            this.labelControl5.TabIndex = 120;
            this.labelControl5.Text = "Data:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.EditValue = "";
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(12, 154);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Properties.Appearance.Options.UseFont = true;
            this.txtFornecedor.Size = new System.Drawing.Size(301, 34);
            this.txtFornecedor.TabIndex = 119;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 207);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 20);
            this.labelControl1.TabIndex = 121;
            this.labelControl1.Text = "Sub-Total:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(254, 207);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 20);
            this.labelControl2.TabIndex = 122;
            this.labelControl2.Text = "Desconto:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(254, 283);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 20);
            this.labelControl3.TabIndex = 123;
            this.labelControl3.Text = "Valor Total:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 362);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 20);
            this.labelControl4.TabIndex = 124;
            this.labelControl4.Text = "Observações:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 283);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 20);
            this.labelControl6.TabIndex = 125;
            this.labelControl6.Text = "Multa:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(490, 207);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 20);
            this.labelControl7.TabIndex = 126;
            this.labelControl7.Text = "Juros:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(12, 128);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(78, 20);
            this.labelControl8.TabIndex = 127;
            this.labelControl8.Text = "Fornecedor:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(371, 128);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(68, 20);
            this.labelControl9.TabIndex = 128;
            this.labelControl9.Text = "Categoria:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(231, 47);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(82, 20);
            this.labelControl10.TabIndex = 129;
            this.labelControl10.Text = "Vencimento:";
            // 
            // txtData
            // 
            this.txtData.EditValue = "";
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(12, 73);
            this.txtData.Name = "txtData";
            this.txtData.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Properties.Appearance.Options.UseFont = true;
            this.txtData.Size = new System.Drawing.Size(170, 34);
            this.txtData.TabIndex = 130;
            // 
            // txtVencimento
            // 
            this.txtVencimento.EditValue = "";
            this.txtVencimento.Enabled = false;
            this.txtVencimento.Location = new System.Drawing.Point(231, 73);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimento.Properties.Appearance.Options.UseFont = true;
            this.txtVencimento.Size = new System.Drawing.Size(170, 34);
            this.txtVencimento.TabIndex = 131;
            // 
            // txtCategoria
            // 
            this.txtCategoria.EditValue = "";
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(371, 154);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Properties.Appearance.Options.UseFont = true;
            this.txtCategoria.Size = new System.Drawing.Size(301, 34);
            this.txtCategoria.TabIndex = 132;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.EditValue = "";
            this.txtObservacoes.Location = new System.Drawing.Point(12, 388);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Properties.Appearance.Options.UseFont = true;
            this.txtObservacoes.Size = new System.Drawing.Size(660, 34);
            this.txtObservacoes.TabIndex = 4;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(13, 5);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(198, 20);
            this.labelControl13.TabIndex = 140;
            this.labelControl13.Text = "Consulta Detalhada Despesa";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-98, 15);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(888, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 139;
            this.pictureBox6.TabStop = false;
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
            this.btnFechar.Location = new System.Drawing.Point(660, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 141;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(254, 309);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Properties.Appearance.Options.UseFont = true;
            this.txtValorTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtValorTotal.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtValorTotal.Properties.MaskSettings.Set("mask", "c");
            this.txtValorTotal.Properties.MaxLength = 20;
            this.txtValorTotal.Properties.NullText = "R$ 0,00";
            this.txtValorTotal.Properties.UseMaskAsDisplayFormat = true;
            this.txtValorTotal.Size = new System.Drawing.Size(182, 34);
            this.txtValorTotal.TabIndex = 3;
            // 
            // txtSubCategoria
            // 
            this.txtSubCategoria.Enabled = false;
            this.txtSubCategoria.Location = new System.Drawing.Point(12, 233);
            this.txtSubCategoria.Name = "txtSubCategoria";
            this.txtSubCategoria.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCategoria.Properties.Appearance.Options.UseFont = true;
            this.txtSubCategoria.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSubCategoria.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSubCategoria.Properties.MaskSettings.Set("mask", "c");
            this.txtSubCategoria.Properties.MaxLength = 20;
            this.txtSubCategoria.Properties.NullText = "R$ 0,00";
            this.txtSubCategoria.Properties.UseMaskAsDisplayFormat = true;
            this.txtSubCategoria.Size = new System.Drawing.Size(182, 34);
            this.txtSubCategoria.TabIndex = 143;
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(490, 233);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuros.Properties.Appearance.Options.UseFont = true;
            this.txtJuros.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtJuros.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtJuros.Properties.MaskSettings.Set("mask", "P");
            this.txtJuros.Properties.MaxLength = 20;
            this.txtJuros.Properties.NullText = "0,00%";
            this.txtJuros.Properties.UseMaskAsDisplayFormat = true;
            this.txtJuros.Size = new System.Drawing.Size(182, 34);
            this.txtJuros.TabIndex = 1;
            this.txtJuros.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtJuros_KeyUp);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(254, 233);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtDesconto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtDesconto.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtDesconto.Properties.MaskSettings.Set("mask", "P");
            this.txtDesconto.Properties.MaxLength = 20;
            this.txtDesconto.Properties.NullText = "0,00%";
            this.txtDesconto.Properties.UseMaskAsDisplayFormat = true;
            this.txtDesconto.Size = new System.Drawing.Size(182, 34);
            this.txtDesconto.TabIndex = 0;
            this.txtDesconto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDesconto_KeyUp);
            // 
            // txtMulta
            // 
            this.txtMulta.Location = new System.Drawing.Point(13, 309);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMulta.Properties.Appearance.Options.UseFont = true;
            this.txtMulta.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMulta.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtMulta.Properties.MaskSettings.Set("mask", "P");
            this.txtMulta.Properties.MaxLength = 20;
            this.txtMulta.Properties.NullText = "0,00%";
            this.txtMulta.Properties.UseMaskAsDisplayFormat = true;
            this.txtMulta.Size = new System.Drawing.Size(182, 34);
            this.txtMulta.TabIndex = 2;
            this.txtMulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMulta_KeyUp);
            // 
            // btnRealizarPagamento
            // 
            this.btnRealizarPagamento.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPagamento.Appearance.Options.UseFont = true;
            this.btnRealizarPagamento.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.save_20px;
            this.btnRealizarPagamento.ImageOptions.ImageIndex = 5;
            this.btnRealizarPagamento.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnRealizarPagamento.ImageOptions.ImageToTextIndent = 10;
            this.btnRealizarPagamento.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnRealizarPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRealizarPagamento.Location = new System.Drawing.Point(471, 439);
            this.btnRealizarPagamento.Name = "btnRealizarPagamento";
            this.btnRealizarPagamento.Size = new System.Drawing.Size(201, 30);
            this.btnRealizarPagamento.TabIndex = 5;
            this.btnRealizarPagamento.Text = "Realizar Pagamento (F10)";
            this.btnRealizarPagamento.Click += new System.EventHandler(this.btnRealizarPagamento_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(444, 47);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(51, 20);
            this.labelControl11.TabIndex = 148;
            this.labelControl11.Text = "Parcela:";
            // 
            // txtParcela
            // 
            this.txtParcela.EditValue = "";
            this.txtParcela.Enabled = false;
            this.txtParcela.Location = new System.Drawing.Point(444, 73);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcela.Properties.Appearance.Options.UseFont = true;
            this.txtParcela.Size = new System.Drawing.Size(170, 34);
            this.txtParcela.TabIndex = 149;
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
            // frmPagamentoDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 484);
            this.Controls.Add(this.txtParcela);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.btnRealizarPagamento);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.txtSubCategoria);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmPagamentoDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPagamentoDespesa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPagamentoDespesa_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPagamentoDespesa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPagamentoDespesa_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.txtFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacoes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJuros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMulta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.TextEdit txtFornecedor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.TextEdit txtData;
        public DevExpress.XtraEditors.TextEdit txtVencimento;
        public DevExpress.XtraEditors.TextEdit txtCategoria;
        public DevExpress.XtraEditors.TextEdit txtObservacoes;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.TextEdit txtValorTotal;
        private DevExpress.XtraEditors.TextEdit txtSubCategoria;
        private DevExpress.XtraEditors.TextEdit txtJuros;
        private DevExpress.XtraEditors.TextEdit txtDesconto;
        private DevExpress.XtraEditors.TextEdit txtMulta;
        private DevExpress.XtraEditors.SimpleButton btnRealizarPagamento;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        public DevExpress.XtraEditors.TextEdit txtParcela;
        private DevExpress.XtraBars.Alerter.AlertControl AlertaSalvar;
    }
}