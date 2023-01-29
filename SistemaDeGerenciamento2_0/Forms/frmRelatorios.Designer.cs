namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmRelatorios
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pnlRelotorios = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnIndicadoresVendas = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovaVenda = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFaturamento = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnFaturamentoPorVendedor = new DevExpress.XtraBars.BarButtonItem();
            this.btnFaturamentoPorDia = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 20);
            this.labelControl3.TabIndex = 303;
            this.labelControl3.Text = "Relatórios";
            // 
            // pnlRelotorios
            // 
            this.pnlRelotorios.AutoScroll = true;
            this.pnlRelotorios.Location = new System.Drawing.Point(12, 90);
            this.pnlRelotorios.Name = "pnlRelotorios";
            this.pnlRelotorios.Size = new System.Drawing.Size(944, 343);
            this.pnlRelotorios.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.entrada_preta;
            this.simpleButton3.ImageOptions.ImageIndex = 5;
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.simpleButton3.ImageOptions.ImageToTextIndent = 10;
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.simpleButton3.Location = new System.Drawing.Point(777, 44);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(179, 30);
            this.simpleButton3.TabIndex = 22;
            this.simpleButton3.Text = "Fluxo de caixa";
            // 
            // btnIndicadoresVendas
            // 
            this.btnIndicadoresVendas.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndicadoresVendas.Appearance.Options.UseFont = true;
            this.btnIndicadoresVendas.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.entrada_preta;
            this.btnIndicadoresVendas.ImageOptions.ImageIndex = 5;
            this.btnIndicadoresVendas.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnIndicadoresVendas.ImageOptions.ImageToTextIndent = 10;
            this.btnIndicadoresVendas.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnIndicadoresVendas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIndicadoresVendas.Location = new System.Drawing.Point(267, 44);
            this.btnIndicadoresVendas.Name = "btnIndicadoresVendas";
            this.btnIndicadoresVendas.Size = new System.Drawing.Size(179, 30);
            this.btnIndicadoresVendas.TabIndex = 20;
            this.btnIndicadoresVendas.Text = "Indicadores de Venda";
            this.btnIndicadoresVendas.Click += new System.EventHandler(this.btnIndicadoresVendas_Click);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaVenda.Appearance.Options.UseFont = true;
            this.btnNovaVenda.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.entrada_preta;
            this.btnNovaVenda.ImageOptions.ImageIndex = 5;
            this.btnNovaVenda.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnNovaVenda.ImageOptions.ImageToTextIndent = 10;
            this.btnNovaVenda.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNovaVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNovaVenda.Location = new System.Drawing.Point(12, 44);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(179, 30);
            this.btnNovaVenda.TabIndex = 19;
            this.btnNovaVenda.Text = "Histórico de Venda";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-21, 19);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(215, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 304;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox1.Location = new System.Drawing.Point(-165, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1298, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 305;
            this.pictureBox1.TabStop = false;
            // 
            // btnFaturamento
            // 
            this.btnFaturamento.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnFaturamento.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturamento.Appearance.Options.UseBorderColor = true;
            this.btnFaturamento.Appearance.Options.UseFont = true;
            this.btnFaturamento.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.btnFaturamento.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnFaturamento.AppearanceDropDown.BorderColor = System.Drawing.Color.Black;
            this.btnFaturamento.AppearanceDropDown.Options.UseBorderColor = true;
            this.btnFaturamento.AppearanceDropDownDisabled.BorderColor = System.Drawing.Color.Black;
            this.btnFaturamento.AppearanceDropDownDisabled.Options.UseBorderColor = true;
            this.btnFaturamento.AppearanceDropDownHovered.BorderColor = System.Drawing.Color.Black;
            this.btnFaturamento.AppearanceDropDownHovered.Options.UseBorderColor = true;
            this.btnFaturamento.AppearanceDropDownPressed.BorderColor = System.Drawing.Color.Black;
            this.btnFaturamento.AppearanceDropDownPressed.Options.UseBorderColor = true;
            this.btnFaturamento.AppearanceHovered.BorderColor = System.Drawing.Color.Black;
            this.btnFaturamento.AppearanceHovered.Options.UseBorderColor = true;
            this.btnFaturamento.AppearancePressed.BorderColor = System.Drawing.Color.Black;
            this.btnFaturamento.AppearancePressed.Options.UseBorderColor = true;
            this.btnFaturamento.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.btnFaturamento.DropDownControl = this.popupMenu1;
            this.btnFaturamento.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.acesso_20px;
            this.btnFaturamento.Location = new System.Drawing.Point(521, 44);
            this.btnFaturamento.MenuManager = this.barManager1;
            this.btnFaturamento.Name = "btnFaturamento";
            this.btnFaturamento.Size = new System.Drawing.Size(179, 30);
            this.btnFaturamento.TabIndex = 307;
            this.btnFaturamento.Text = "Faturamento";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFaturamentoPorVendedor),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFaturamentoPorDia)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnFaturamentoPorVendedor
            // 
            this.btnFaturamentoPorVendedor.Caption = "Faturamento Por Vendedor";
            this.btnFaturamentoPorVendedor.Id = 0;
            this.btnFaturamentoPorVendedor.Name = "btnFaturamentoPorVendedor";
            this.btnFaturamentoPorVendedor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFaturamentoPorVendedor_ItemClick);
            // 
            // btnFaturamentoPorDia
            // 
            this.btnFaturamentoPorDia.Caption = "Faturamento Por Dia";
            this.btnFaturamentoPorDia.Id = 1;
            this.btnFaturamentoPorDia.Name = "btnFaturamentoPorDia";
            this.btnFaturamentoPorDia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFaturamentoPorDia_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnFaturamentoPorVendedor,
            this.btnFaturamentoPorDia});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(968, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 441);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(968, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 441);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(968, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 441);
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 441);
            this.Controls.Add(this.btnFaturamento);
            this.Controls.Add(this.pnlRelotorios);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnIndicadoresVendas);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorios";
            this.Text = "frmRelatorios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNovaVenda;
        private DevExpress.XtraEditors.SimpleButton btnIndicadoresVendas;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel pnlRelotorios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.DropDownButton btnFaturamento;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnFaturamentoPorVendedor;
        private DevExpress.XtraBars.BarButtonItem btnFaturamentoPorDia;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}