﻿namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmFormaPagamentoDinheiro
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTroco = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btn1FinalizarVenda = new DevExpress.XtraEditors.SimpleButton();
            this.btn1CancelarVenda = new DevExpress.XtraEditors.SimpleButton();
            this.txtValorEntregue = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorEntregue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Appearance.Options.UseFont = true;
            this.lblValorTotal.Location = new System.Drawing.Point(33, 105);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(216, 65);
            this.lblValorTotal.TabIndex = 299;
            this.lblValorTotal.Text = "R$ 752,00";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(33, 74);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(146, 25);
            this.labelControl13.TabIndex = 298;
            this.labelControl13.Text = "TOTAL A PAGAR:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(384, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 25);
            this.labelControl1.TabIndex = 300;
            this.labelControl1.Text = "VALOR PAGO:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(746, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 25);
            this.labelControl2.TabIndex = 301;
            this.labelControl2.Text = "TROCO:";
            // 
            // lblTroco
            // 
            this.lblTroco.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Appearance.Options.UseFont = true;
            this.lblTroco.Location = new System.Drawing.Point(746, 105);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(216, 65);
            this.lblTroco.TabIndex = 302;
            this.lblTroco.Text = "R$ 752,00";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(393, 235);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(104, 20);
            this.labelControl4.TabIndex = 304;
            this.labelControl4.Text = "VENDEDOR(A):";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(503, 235);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(130, 20);
            this.labelControl5.TabIndex = 305;
            this.labelControl5.Text = "NOME VENDEDOR";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(223, 25);
            this.labelControl6.TabIndex = 306;
            this.labelControl6.Text = "FORMA DE PAGAMENTO:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(241, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 25);
            this.labelControl7.TabIndex = 307;
            this.labelControl7.Text = "DINHEIRO";
            // 
            // btn1FinalizarVenda
            // 
            this.btn1FinalizarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1FinalizarVenda.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn1FinalizarVenda.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btn1FinalizarVenda.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btn1FinalizarVenda.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1FinalizarVenda.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn1FinalizarVenda.Appearance.Options.UseBackColor = true;
            this.btn1FinalizarVenda.Appearance.Options.UseBorderColor = true;
            this.btn1FinalizarVenda.Appearance.Options.UseFont = true;
            this.btn1FinalizarVenda.Appearance.Options.UseForeColor = true;
            this.btn1FinalizarVenda.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn1FinalizarVenda.AppearanceDisabled.BackColor2 = System.Drawing.Color.Yellow;
            this.btn1FinalizarVenda.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.btn1FinalizarVenda.AppearanceDisabled.Options.UseBackColor = true;
            this.btn1FinalizarVenda.AppearanceDisabled.Options.UseForeColor = true;
            this.btn1FinalizarVenda.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn1FinalizarVenda.AppearanceHovered.BackColor2 = System.Drawing.Color.Red;
            this.btn1FinalizarVenda.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn1FinalizarVenda.AppearanceHovered.Options.UseBackColor = true;
            this.btn1FinalizarVenda.AppearanceHovered.Options.UseForeColor = true;
            this.btn1FinalizarVenda.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn1FinalizarVenda.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btn1FinalizarVenda.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btn1FinalizarVenda.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btn1FinalizarVenda.AppearancePressed.Options.UseBackColor = true;
            this.btn1FinalizarVenda.AppearancePressed.Options.UseBorderColor = true;
            this.btn1FinalizarVenda.AppearancePressed.Options.UseForeColor = true;
            this.btn1FinalizarVenda.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.checkmark_30px;
            this.btn1FinalizarVenda.ImageOptions.ImageIndex = 5;
            this.btn1FinalizarVenda.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btn1FinalizarVenda.ImageOptions.ImageToTextIndent = 10;
            this.btn1FinalizarVenda.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn1FinalizarVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn1FinalizarVenda.Location = new System.Drawing.Point(703, 219);
            this.btn1FinalizarVenda.Name = "btn1FinalizarVenda";
            this.btn1FinalizarVenda.Size = new System.Drawing.Size(280, 44);
            this.btn1FinalizarVenda.TabIndex = 309;
            this.btn1FinalizarVenda.Text = "Finalizar Pagamento (F2)";
            // 
            // btn1CancelarVenda
            // 
            this.btn1CancelarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1CancelarVenda.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btn1CancelarVenda.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btn1CancelarVenda.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btn1CancelarVenda.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1CancelarVenda.Appearance.Options.UseBackColor = true;
            this.btn1CancelarVenda.Appearance.Options.UseBorderColor = true;
            this.btn1CancelarVenda.Appearance.Options.UseFont = true;
            this.btn1CancelarVenda.AppearanceDisabled.BackColor = System.Drawing.Color.Red;
            this.btn1CancelarVenda.AppearanceDisabled.BackColor2 = System.Drawing.Color.Yellow;
            this.btn1CancelarVenda.AppearanceDisabled.Options.UseBackColor = true;
            this.btn1CancelarVenda.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.btn1CancelarVenda.AppearanceHovered.BackColor2 = System.Drawing.Color.Red;
            this.btn1CancelarVenda.AppearanceHovered.Options.UseBackColor = true;
            this.btn1CancelarVenda.AppearancePressed.BackColor = System.Drawing.Color.Red;
            this.btn1CancelarVenda.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btn1CancelarVenda.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btn1CancelarVenda.AppearancePressed.Options.UseBackColor = true;
            this.btn1CancelarVenda.AppearancePressed.Options.UseBorderColor = true;
            this.btn1CancelarVenda.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.delete_30px;
            this.btn1CancelarVenda.ImageOptions.ImageIndex = 5;
            this.btn1CancelarVenda.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btn1CancelarVenda.ImageOptions.ImageToTextIndent = 10;
            this.btn1CancelarVenda.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn1CancelarVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn1CancelarVenda.Location = new System.Drawing.Point(12, 217);
            this.btn1CancelarVenda.Name = "btn1CancelarVenda";
            this.btn1CancelarVenda.Size = new System.Drawing.Size(280, 44);
            this.btn1CancelarVenda.TabIndex = 308;
            this.btn1CancelarVenda.Text = "Cancelar Pagamento (F9)";
            // 
            // txtValorEntregue
            // 
            this.txtValorEntregue.Location = new System.Drawing.Point(382, 105);
            this.txtValorEntregue.Name = "txtValorEntregue";
            this.txtValorEntregue.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEntregue.Properties.Appearance.Options.UseFont = true;
            this.txtValorEntregue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtValorEntregue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtValorEntregue.Properties.MaskSettings.Set("mask", "c");
            this.txtValorEntregue.Properties.MaxLength = 20;
            this.txtValorEntregue.Properties.NullText = "R$ 0,00";
            this.txtValorEntregue.Properties.UseMaskAsDisplayFormat = true;
            this.txtValorEntregue.Size = new System.Drawing.Size(269, 80);
            this.txtValorEntregue.TabIndex = 310;
            this.txtValorEntregue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorEntregue_KeyUp);
            // 
            // frmFormaPagamentoDinheiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 269);
            this.Controls.Add(this.txtValorEntregue);
            this.Controls.Add(this.btn1FinalizarVenda);
            this.Controls.Add(this.btn1CancelarVenda);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.labelControl13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFormaPagamentoDinheiro";
            this.Text = "frmFormaPagamentoDinheiro";
            this.Load += new System.EventHandler(this.frmFormaPagamentoDinheiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtValorEntregue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblValorTotal;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblTroco;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btn1FinalizarVenda;
        private DevExpress.XtraEditors.SimpleButton btn1CancelarVenda;
        private DevExpress.XtraEditors.TextEdit txtValorEntregue;
    }
}