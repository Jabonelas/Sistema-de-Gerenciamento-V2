namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmPagamento
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
            this.lblValorTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.btnCliente = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblSubTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblAcrescimo = new DevExpress.XtraEditors.LabelControl();
            this.lblDescontoGeral = new DevExpress.XtraEditors.LabelControl();
            this.lblDescontoItens = new DevExpress.XtraEditors.LabelControl();
            this.btnDebito = new DevExpress.XtraEditors.SimpleButton();
            this.btnCredito = new DevExpress.XtraEditors.SimpleButton();
            this.btnPix = new DevExpress.XtraEditors.SimpleButton();
            this.pnlTipoPagamento = new DevExpress.XtraEditors.PanelControl();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTipoPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Appearance.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Appearance.Options.UseFont = true;
            this.lblValorTotal.Location = new System.Drawing.Point(515, 66);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(555, 128);
            this.lblValorTotal.TabIndex = 297;
            this.lblValorTotal.Text = "R$ 00752,00";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(515, 23);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(217, 37);
            this.labelControl13.TabIndex = 296;
            this.labelControl13.Text = "TOTAL A PAGAR:";
            // 
            // btnCliente
            // 
            this.btnCliente.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnCliente.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Appearance.Options.UseBackColor = true;
            this.btnCliente.Appearance.Options.UseFont = true;
            this.btnCliente.Location = new System.Drawing.Point(15, 211);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(227, 74);
            this.btnCliente.TabIndex = 295;
            this.btnCliente.Text = "DINHEIRO (SHIFT + D)";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 25);
            this.labelControl1.TabIndex = 298;
            this.labelControl1.Text = "SUBTOTAL:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(204, 25);
            this.labelControl2.TabIndex = 299;
            this.labelControl2.Text = "DESCONTO NOS ITENS:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(166, 25);
            this.labelControl3.TabIndex = 300;
            this.labelControl3.Text = "DESCONTO GERAL:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(112, 25);
            this.labelControl4.TabIndex = 301;
            this.labelControl4.Text = "ACRESCIMO:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Appearance.Options.UseFont = true;
            this.lblSubTotal.Location = new System.Drawing.Point(290, 13);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(88, 25);
            this.lblSubTotal.TabIndex = 302;
            this.lblSubTotal.Text = "R$ 200,00";
            // 
            // lblAcrescimo
            // 
            this.lblAcrescimo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcrescimo.Appearance.Options.UseFont = true;
            this.lblAcrescimo.Location = new System.Drawing.Point(290, 148);
            this.lblAcrescimo.Name = "lblAcrescimo";
            this.lblAcrescimo.Size = new System.Drawing.Size(66, 25);
            this.lblAcrescimo.TabIndex = 303;
            this.lblAcrescimo.Text = "R$ 0,00";
            // 
            // lblDescontoGeral
            // 
            this.lblDescontoGeral.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoGeral.Appearance.Options.UseFont = true;
            this.lblDescontoGeral.Location = new System.Drawing.Point(290, 103);
            this.lblDescontoGeral.Name = "lblDescontoGeral";
            this.lblDescontoGeral.Size = new System.Drawing.Size(66, 25);
            this.lblDescontoGeral.TabIndex = 304;
            this.lblDescontoGeral.Text = "R$ 0,00";
            // 
            // lblDescontoItens
            // 
            this.lblDescontoItens.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoItens.Appearance.Options.UseFont = true;
            this.lblDescontoItens.Location = new System.Drawing.Point(290, 58);
            this.lblDescontoItens.Name = "lblDescontoItens";
            this.lblDescontoItens.Size = new System.Drawing.Size(66, 25);
            this.lblDescontoItens.TabIndex = 305;
            this.lblDescontoItens.Text = "R$ 0,00";
            // 
            // btnDebito
            // 
            this.btnDebito.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnDebito.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebito.Appearance.Options.UseBackColor = true;
            this.btnDebito.Appearance.Options.UseFont = true;
            this.btnDebito.Location = new System.Drawing.Point(271, 211);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(227, 74);
            this.btnDebito.TabIndex = 306;
            this.btnDebito.Text = "CARTÃO DEBITO (SHIFT +R )";
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnCredito.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.Appearance.Options.UseBackColor = true;
            this.btnCredito.Appearance.Options.UseFont = true;
            this.btnCredito.Location = new System.Drawing.Point(527, 211);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(227, 74);
            this.btnCredito.TabIndex = 307;
            this.btnCredito.Text = "CARTÃO CREDITO (SHIFT + C)";
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnPix
            // 
            this.btnPix.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnPix.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPix.Appearance.Options.UseBackColor = true;
            this.btnPix.Appearance.Options.UseFont = true;
            this.btnPix.Location = new System.Drawing.Point(783, 211);
            this.btnPix.Name = "btnPix";
            this.btnPix.Size = new System.Drawing.Size(227, 74);
            this.btnPix.TabIndex = 308;
            this.btnPix.Text = "PIX (SHIFT + P)";
            this.btnPix.Click += new System.EventHandler(this.btnPix_Click);
            // 
            // pnlTipoPagamento
            // 
            this.pnlTipoPagamento.Location = new System.Drawing.Point(15, 305);
            this.pnlTipoPagamento.Name = "pnlTipoPagamento";
            this.pnlTipoPagamento.Size = new System.Drawing.Size(995, 269);
            this.pnlTipoPagamento.TabIndex = 309;
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
            this.btnFechar.Location = new System.Drawing.Point(997, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 310;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 591);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlTipoPagamento);
            this.Controls.Add(this.btnPix);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.lblDescontoItens);
            this.Controls.Add(this.lblDescontoGeral);
            this.Controls.Add(this.lblAcrescimo);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.btnCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPagamento";
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPagamento_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPagamento_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPagamento_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTipoPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblValorTotal;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton btnCliente;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblSubTotal;
        private DevExpress.XtraEditors.LabelControl lblDescontoItens;
        private DevExpress.XtraEditors.SimpleButton btnDebito;
        private DevExpress.XtraEditors.SimpleButton btnCredito;
        private DevExpress.XtraEditors.SimpleButton btnPix;
        private DevExpress.XtraEditors.PanelControl pnlTipoPagamento;
        public DevExpress.XtraEditors.LabelControl lblAcrescimo;
        public DevExpress.XtraEditors.LabelControl lblDescontoGeral;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
    }
}