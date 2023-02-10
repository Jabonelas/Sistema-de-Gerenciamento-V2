namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmVisaoGeral
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
            DevExpress.XtraCharts.Legend legend1 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.Legend legend2 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle4 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbAno = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMes = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblVendaAnual = new DevExpress.XtraEditors.LabelControl();
            this.lblDespesaAnual = new DevExpress.XtraEditors.LabelControl();
            this.lblDespesaSemanal = new DevExpress.XtraEditors.LabelControl();
            this.lblVendaSemanal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox1.Location = new System.Drawing.Point(-30, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 334;
            this.pictureBox1.TabStop = false;
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            legend1.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            legend1.Name = "Legend 1";
            legend1.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            legend1.Title.Visible = true;
            legend1.Title.WordWrap = true;
            this.chartControl1.Legends.AddRange(new DevExpress.XtraCharts.Legend[] {
            legend1});
            this.chartControl1.Location = new System.Drawing.Point(12, 96);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(1188, 282);
            this.chartControl1.TabIndex = 332;
            chartTitle1.Indent = 6;
            chartTitle1.Text = "Despesa/Vendas Mensal";
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Left;
            chartTitle2.Text = "Valor R$";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-20, 20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(215, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 331;
            this.pictureBox6.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 20);
            this.labelControl3.TabIndex = 330;
            this.labelControl3.Text = "Visão Geral";
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
            this.btnFechar.Location = new System.Drawing.Point(1186, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 295;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(201, 17);
            this.labelControl1.TabIndex = 333;
            this.labelControl1.Text = "Dados Vendas / Despesa Mensal\r\n";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1076, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 20);
            this.labelControl2.TabIndex = 336;
            this.labelControl2.Text = "Ano:";
            // 
            // cmbAno
            // 
            this.cmbAno.Location = new System.Drawing.Point(1076, 56);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAno.Properties.Appearance.Options.UseFont = true;
            this.cmbAno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAno.Properties.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbAno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbAno.Size = new System.Drawing.Size(124, 34);
            this.cmbAno.TabIndex = 335;
            this.cmbAno.TextChanged += new System.EventHandler(this.cmbAno_TextChanged);
            // 
            // chartControl2
            // 
            this.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            legend2.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            legend2.Name = "Legend 1";
            legend2.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            legend2.Title.Visible = true;
            legend2.Title.WordWrap = true;
            this.chartControl2.Legends.AddRange(new DevExpress.XtraCharts.Legend[] {
            legend2});
            this.chartControl2.Location = new System.Drawing.Point(614, 467);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(586, 235);
            this.chartControl2.TabIndex = 337;
            chartTitle3.Indent = 6;
            chartTitle3.Text = "Despesa/Venda Semanal";
            chartTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Left;
            chartTitle4.Text = "Valor R$";
            this.chartControl2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3,
            chartTitle4});
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1040, 401);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 20);
            this.labelControl4.TabIndex = 339;
            this.labelControl4.Text = "Mês:";
            // 
            // cmbMes
            // 
            this.cmbMes.Location = new System.Drawing.Point(1040, 427);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.Properties.Appearance.Options.UseFont = true;
            this.cmbMes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMes.Properties.DropDownRows = 5;
            this.cmbMes.Properties.MaxLength = 20;
            this.cmbMes.Properties.NullText = "";
            this.cmbMes.Properties.PopupSizeable = false;
            this.cmbMes.Size = new System.Drawing.Size(160, 34);
            this.cmbMes.TabIndex = 341;
            this.cmbMes.TextChanged += new System.EventHandler(this.cmbMes_TextChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(359, 441);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(188, 25);
            this.labelControl5.TabIndex = 342;
            this.labelControl5.Text = "Total de Venda Anual:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(359, 576);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(211, 25);
            this.labelControl6.TabIndex = 343;
            this.labelControl6.Text = "Total de Venda Semanal:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(53, 441);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(205, 25);
            this.labelControl7.TabIndex = 344;
            this.labelControl7.Text = "Total de Despesa Anual:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(53, 576);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(228, 25);
            this.labelControl8.TabIndex = 345;
            this.labelControl8.Text = "Total de Despesa Semanal:";
            // 
            // lblVendaAnual
            // 
            this.lblVendaAnual.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendaAnual.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.lblVendaAnual.Appearance.Options.UseFont = true;
            this.lblVendaAnual.Appearance.Options.UseForeColor = true;
            this.lblVendaAnual.Location = new System.Drawing.Point(359, 482);
            this.lblVendaAnual.Name = "lblVendaAnual";
            this.lblVendaAnual.Size = new System.Drawing.Size(97, 40);
            this.lblVendaAnual.TabIndex = 346;
            this.lblVendaAnual.Text = "R$ 0,00";
            // 
            // lblDespesaAnual
            // 
            this.lblDespesaAnual.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespesaAnual.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(184)))), ((int)(((byte)(10)))));
            this.lblDespesaAnual.Appearance.Options.UseFont = true;
            this.lblDespesaAnual.Appearance.Options.UseForeColor = true;
            this.lblDespesaAnual.Location = new System.Drawing.Point(53, 482);
            this.lblDespesaAnual.Name = "lblDespesaAnual";
            this.lblDespesaAnual.Size = new System.Drawing.Size(97, 40);
            this.lblDespesaAnual.TabIndex = 347;
            this.lblDespesaAnual.Text = "R$ 0,00";
            // 
            // lblDespesaSemanal
            // 
            this.lblDespesaSemanal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespesaSemanal.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(184)))), ((int)(((byte)(10)))));
            this.lblDespesaSemanal.Appearance.Options.UseFont = true;
            this.lblDespesaSemanal.Appearance.Options.UseForeColor = true;
            this.lblDespesaSemanal.Location = new System.Drawing.Point(53, 616);
            this.lblDespesaSemanal.Name = "lblDespesaSemanal";
            this.lblDespesaSemanal.Size = new System.Drawing.Size(97, 40);
            this.lblDespesaSemanal.TabIndex = 348;
            this.lblDespesaSemanal.Text = "R$ 0,00";
            // 
            // lblVendaSemanal
            // 
            this.lblVendaSemanal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendaSemanal.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.lblVendaSemanal.Appearance.Options.UseFont = true;
            this.lblVendaSemanal.Appearance.Options.UseForeColor = true;
            this.lblVendaSemanal.Location = new System.Drawing.Point(359, 616);
            this.lblVendaSemanal.Name = "lblVendaSemanal";
            this.lblVendaSemanal.Size = new System.Drawing.Size(97, 40);
            this.lblVendaSemanal.TabIndex = 349;
            this.lblVendaSemanal.Text = "R$ 0,00";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(614, 434);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(209, 17);
            this.labelControl9.TabIndex = 350;
            this.labelControl9.Text = "Dados Vendas / Despesa Semanal\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox2.Location = new System.Drawing.Point(572, 447);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 351;
            this.pictureBox2.TabStop = false;
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // frmVisaoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 719);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.lblVendaSemanal);
            this.Controls.Add(this.lblDespesaSemanal);
            this.Controls.Add(this.lblDespesaAnual);
            this.Controls.Add(this.lblVendaAnual);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmVisaoGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisaoGeral";
            this.Shown += new System.EventHandler(this.frmVisaoGeral_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVisaoGeral_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmVisaoGeral_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmVisaoGeral_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAno;
        public DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit cmbMes;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lblVendaAnual;
        private DevExpress.XtraEditors.LabelControl lblDespesaAnual;
        private DevExpress.XtraEditors.LabelControl lblDespesaSemanal;
        private DevExpress.XtraEditors.LabelControl lblVendaSemanal;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}