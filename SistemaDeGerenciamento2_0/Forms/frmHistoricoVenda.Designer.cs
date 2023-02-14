namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmHistoricoVenda
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
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnCalendario = new DevExpress.XtraEditors.SimpleButton();
            this.txtCalendario = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblValorTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalendario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
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
            this.btnFechar.Location = new System.Drawing.Point(1213, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 294;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(992, 22);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 20);
            this.labelControl4.TabIndex = 326;
            this.labelControl4.Text = "Data:";
            // 
            // btnCalendario
            // 
            this.btnCalendario.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.Appearance.Options.UseFont = true;
            this.btnCalendario.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.calendar_plus_20px;
            this.btnCalendario.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCalendario.Location = new System.Drawing.Point(950, 48);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(35, 34);
            this.btnCalendario.TabIndex = 325;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            this.btnCalendario.Leave += new System.EventHandler(this.btnCalendario_Leave);
            // 
            // txtCalendario
            // 
            this.txtCalendario.Location = new System.Drawing.Point(992, 48);
            this.txtCalendario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalendario.Name = "txtCalendario";
            this.txtCalendario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalendario.Properties.Appearance.Options.UseFont = true;
            this.txtCalendario.Properties.MaxLength = 14;
            this.txtCalendario.Properties.ReadOnly = true;
            this.txtCalendario.Size = new System.Drawing.Size(223, 34);
            this.txtCalendario.TabIndex = 324;
            this.txtCalendario.Click += new System.EventHandler(this.txtCalendario_Click);
            this.txtCalendario.Enter += new System.EventHandler(this.txtCalendario_Enter);
            this.txtCalendario.Leave += new System.EventHandler(this.txtCalendario_Leave);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(26, 105);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1189, 368);
            this.gridControl1.TabIndex = 327;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(132, 20);
            this.labelControl3.TabIndex = 328;
            this.labelControl3.Text = "Histórico de Venda";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-20, 21);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(215, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 329;
            this.pictureBox6.TabStop = false;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Appearance.Options.UseFont = true;
            this.lblValorTotal.Location = new System.Drawing.Point(110, 504);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(53, 21);
            this.lblValorTotal.TabIndex = 331;
            this.lblValorTotal.Text = "R$ 0,00";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(26, 504);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 21);
            this.labelControl5.TabIndex = 330;
            this.labelControl5.Text = "Total Valor:";
            // 
            // frmHistoricoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 555);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.txtCalendario);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmHistoricoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistoricoVenda";
            this.Click += new System.EventHandler(this.frmHistoricoVenda_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHistoricoVenda_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmHistoricoVenda_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmHistoricoVenda_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.txtCalendario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.SimpleButton btnCalendario;
        public DevExpress.XtraEditors.TextEdit txtCalendario;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl lblValorTotal;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}