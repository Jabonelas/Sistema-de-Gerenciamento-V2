namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmCalendario
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
            this.dtDataFinal = new DevExpress.XtraScheduler.DateNavigator();
            this.dtDataInicial = new DevExpress.XtraScheduler.DateNavigator();
            this.btnProximoMes = new DevExpress.XtraEditors.SimpleButton();
            this.btnEsteMes = new DevExpress.XtraEditors.SimpleButton();
            this.btnUltimos30Dias = new DevExpress.XtraEditors.SimpleButton();
            this.btnUltimos7Dias = new DevExpress.XtraEditors.SimpleButton();
            this.btnOntem = new DevExpress.XtraEditors.SimpleButton();
            this.btnHoje = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.txtDataFinal = new DevExpress.XtraEditors.TextEdit();
            this.txtDataInicial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataFinal.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataInicial.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dtDataFinal.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dtDataFinal.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataFinal.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.dtDataFinal.Location = new System.Drawing.Point(263, 38);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(245, 258);
            this.dtDataFinal.TabIndex = 335;
            this.dtDataFinal.Click += new System.EventHandler(this.dtDataFinal_Click);
            // 
            // dtDataInicial
            // 
            this.dtDataInicial.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dtDataInicial.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dtDataInicial.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataInicial.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.dtDataInicial.Location = new System.Drawing.Point(12, 38);
            this.dtDataInicial.Name = "dtDataInicial";
            this.dtDataInicial.Size = new System.Drawing.Size(245, 259);
            this.dtDataInicial.TabIndex = 336;
            this.dtDataInicial.Click += new System.EventHandler(this.dtDataInicial_Click);
            // 
            // btnProximoMes
            // 
            this.btnProximoMes.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximoMes.Appearance.Options.UseFont = true;
            this.btnProximoMes.Location = new System.Drawing.Point(599, 252);
            this.btnProximoMes.Name = "btnProximoMes";
            this.btnProximoMes.Size = new System.Drawing.Size(168, 34);
            this.btnProximoMes.TabIndex = 342;
            this.btnProximoMes.Text = "Próximo Mês";
            this.btnProximoMes.Click += new System.EventHandler(this.btnProximoMes_Click_1);
            this.btnProximoMes.MouseEnter += new System.EventHandler(this.btnProximoMes_MouseEnter_1);
            // 
            // btnEsteMes
            // 
            this.btnEsteMes.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsteMes.Appearance.Options.UseFont = true;
            this.btnEsteMes.Location = new System.Drawing.Point(599, 204);
            this.btnEsteMes.Name = "btnEsteMes";
            this.btnEsteMes.Size = new System.Drawing.Size(168, 34);
            this.btnEsteMes.TabIndex = 341;
            this.btnEsteMes.Text = "Este Mês";
            this.btnEsteMes.Click += new System.EventHandler(this.btnEsteMes_Click_1);
            this.btnEsteMes.MouseEnter += new System.EventHandler(this.btnEsteMes_MouseEnter_1);
            // 
            // btnUltimos30Dias
            // 
            this.btnUltimos30Dias.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimos30Dias.Appearance.Options.UseFont = true;
            this.btnUltimos30Dias.Location = new System.Drawing.Point(599, 156);
            this.btnUltimos30Dias.Name = "btnUltimos30Dias";
            this.btnUltimos30Dias.Size = new System.Drawing.Size(168, 34);
            this.btnUltimos30Dias.TabIndex = 340;
            this.btnUltimos30Dias.Text = "Últimos 30 Dias";
            this.btnUltimos30Dias.Click += new System.EventHandler(this.btnUltimos30Dias_Click_1);
            this.btnUltimos30Dias.MouseEnter += new System.EventHandler(this.btnUltimos30Dias_MouseEnter_1);
            // 
            // btnUltimos7Dias
            // 
            this.btnUltimos7Dias.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimos7Dias.Appearance.Options.UseFont = true;
            this.btnUltimos7Dias.Location = new System.Drawing.Point(599, 108);
            this.btnUltimos7Dias.Name = "btnUltimos7Dias";
            this.btnUltimos7Dias.Size = new System.Drawing.Size(168, 34);
            this.btnUltimos7Dias.TabIndex = 339;
            this.btnUltimos7Dias.Text = "Últimos 7 Dias";
            this.btnUltimos7Dias.Click += new System.EventHandler(this.btnUltimos7Dias_Click_1);
            this.btnUltimos7Dias.MouseEnter += new System.EventHandler(this.btnUltimos7Dias_MouseEnter_1);
            // 
            // btnOntem
            // 
            this.btnOntem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOntem.Appearance.Options.UseFont = true;
            this.btnOntem.Location = new System.Drawing.Point(599, 60);
            this.btnOntem.Name = "btnOntem";
            this.btnOntem.Size = new System.Drawing.Size(168, 34);
            this.btnOntem.TabIndex = 338;
            this.btnOntem.Text = "Ontem";
            this.btnOntem.Click += new System.EventHandler(this.btnOntem_Click_1);
            this.btnOntem.MouseEnter += new System.EventHandler(this.btnOntem_MouseEnter_1);
            // 
            // btnHoje
            // 
            this.btnHoje.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoje.Appearance.Options.UseFont = true;
            this.btnHoje.Location = new System.Drawing.Point(599, 12);
            this.btnHoje.Name = "btnHoje";
            this.btnHoje.Size = new System.Drawing.Size(168, 34);
            this.btnHoje.TabIndex = 337;
            this.btnHoje.Text = "Hoje";
            this.btnHoje.Click += new System.EventHandler(this.btnHoje_Click_1);
            this.btnHoje.MouseEnter += new System.EventHandler(this.btnHoje_MouseEnter_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Location = new System.Drawing.Point(709, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 34);
            this.btnCancelar.TabIndex = 355;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Appearance.Options.UseFont = true;
            this.btnAplicar.Location = new System.Drawing.Point(532, 371);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(116, 34);
            this.btnAplicar.TabIndex = 354;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click_1);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(697, 322);
            this.txtDataFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Properties.Appearance.Options.UseFont = true;
            this.txtDataFinal.Properties.MaxLength = 14;
            this.txtDataFinal.Properties.ReadOnly = true;
            this.txtDataFinal.Size = new System.Drawing.Size(140, 34);
            this.txtDataFinal.TabIndex = 356;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Location = new System.Drawing.Point(521, 322);
            this.txtDataInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.Properties.Appearance.Options.UseFont = true;
            this.txtDataInicial.Properties.MaxLength = 14;
            this.txtDataInicial.Properties.ReadOnly = true;
            this.txtDataInicial.Size = new System.Drawing.Size(140, 34);
            this.txtDataInicial.TabIndex = 357;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(263, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 20);
            this.labelControl2.TabIndex = 359;
            this.labelControl2.Text = "Data Final:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 20);
            this.labelControl3.TabIndex = 358;
            this.labelControl3.Text = "Data Inicial:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(697, 299);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 20);
            this.labelControl1.TabIndex = 360;
            this.labelControl1.Text = "Data Final:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(521, 300);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 20);
            this.labelControl4.TabIndex = 361;
            this.labelControl4.Text = "Data Inicial:";
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 427);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnProximoMes);
            this.Controls.Add(this.btnEsteMes);
            this.Controls.Add(this.btnUltimos30Dias);
            this.Controls.Add(this.btnUltimos7Dias);
            this.Controls.Add(this.btnOntem);
            this.Controls.Add(this.btnHoje);
            this.Controls.Add(this.dtDataInicial);
            this.Controls.Add(this.dtDataFinal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCalendario";
            ((System.ComponentModel.ISupportInitialize)(this.dtDataFinal.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataInicial.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraScheduler.DateNavigator dtDataFinal;
        private DevExpress.XtraScheduler.DateNavigator dtDataInicial;
        private DevExpress.XtraEditors.SimpleButton btnProximoMes;
        private DevExpress.XtraEditors.SimpleButton btnEsteMes;
        private DevExpress.XtraEditors.SimpleButton btnUltimos30Dias;
        private DevExpress.XtraEditors.SimpleButton btnUltimos7Dias;
        private DevExpress.XtraEditors.SimpleButton btnOntem;
        private DevExpress.XtraEditors.SimpleButton btnHoje;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
        public DevExpress.XtraEditors.TextEdit txtDataFinal;
        public DevExpress.XtraEditors.TextEdit txtDataInicial;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}