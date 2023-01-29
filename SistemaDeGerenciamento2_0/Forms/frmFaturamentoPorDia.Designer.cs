namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmFaturamentoPorDia
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaturamentoPorDia));
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nfs_data_emissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nfs_quantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nfs_valor_parcial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl4
            // 
            this.gridControl4.DataMember = "tb_nota_fiscal_saida";
            this.gridControl4.DataSource = this.sqlDataSource1;
            this.gridControl4.Location = new System.Drawing.Point(24, 45);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(900, 282);
            this.gridControl4.TabIndex = 301;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "update";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "tb_nota_fiscal_saida";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nfs_data_emissao,
            this.nfs_quantidade,
            this.nfs_valor_parcial});
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsView.ShowFooter = true;
            // 
            // nfs_data_emissao
            // 
            this.nfs_data_emissao.AppearanceCell.Options.UseTextOptions = true;
            this.nfs_data_emissao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nfs_data_emissao.AppearanceHeader.Options.UseTextOptions = true;
            this.nfs_data_emissao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nfs_data_emissao.Caption = "Data Emissao";
            this.nfs_data_emissao.FieldName = "nfs_data_emissao";
            this.nfs_data_emissao.Name = "nfs_data_emissao";
            this.nfs_data_emissao.Visible = true;
            this.nfs_data_emissao.VisibleIndex = 0;
            // 
            // nfs_quantidade
            // 
            this.nfs_quantidade.AppearanceCell.Options.UseTextOptions = true;
            this.nfs_quantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nfs_quantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.nfs_quantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nfs_quantidade.Caption = "Quantidade Total";
            this.nfs_quantidade.FieldName = "nfs_quantidade";
            this.nfs_quantidade.Name = "nfs_quantidade";
            this.nfs_quantidade.Visible = true;
            this.nfs_quantidade.VisibleIndex = 1;
            // 
            // nfs_valor_parcial
            // 
            this.nfs_valor_parcial.AppearanceCell.Options.UseTextOptions = true;
            this.nfs_valor_parcial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nfs_valor_parcial.AppearanceHeader.Options.UseTextOptions = true;
            this.nfs_valor_parcial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nfs_valor_parcial.Caption = "Valor Total Produto";
            this.nfs_valor_parcial.DisplayFormat.FormatString = "C2";
            this.nfs_valor_parcial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.nfs_valor_parcial.FieldName = "nfs_valor_parcial";
            this.nfs_valor_parcial.Name = "nfs_valor_parcial";
            this.nfs_valor_parcial.Visible = true;
            this.nfs_valor_parcial.VisibleIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(146, 20);
            this.labelControl3.TabIndex = 305;
            this.labelControl3.Text = "Faturamento Por Dia";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-6, 18);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(215, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 306;
            this.pictureBox6.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(511, 13);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 307;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmFaturamentoPorDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 343);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.gridControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFaturamentoPorDia";
            this.Text = "frmFaturamentoPorDia";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn nfs_data_emissao;
        private DevExpress.XtraGrid.Columns.GridColumn nfs_quantidade;
        private DevExpress.XtraGrid.Columns.GridColumn nfs_valor_parcial;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}