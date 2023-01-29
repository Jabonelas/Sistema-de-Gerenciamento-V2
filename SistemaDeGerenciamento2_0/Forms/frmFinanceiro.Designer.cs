namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmFinanceiro
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanceiro));
            this.btnNovaDespesaContas = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_despesa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rg_tipo_cadastro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rg_nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rg_cpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rg_nome_fantasia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rg_cnpj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_parcelas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cd_categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_sub_valor_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_vencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_imagem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalAguardando = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalFinalizadas = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalAtrasadas = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnRealizarPagamento = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDeletar = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // btnNovaDespesaContas
            // 
            this.btnNovaDespesaContas.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnNovaDespesaContas.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnNovaDespesaContas.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaDespesaContas.Appearance.Options.UseBorderColor = true;
            this.btnNovaDespesaContas.Appearance.Options.UseFont = true;
            this.btnNovaDespesaContas.AppearanceDisabled.BackColor = System.Drawing.Color.Yellow;
            this.btnNovaDespesaContas.AppearanceDisabled.BackColor2 = System.Drawing.Color.Yellow;
            this.btnNovaDespesaContas.AppearanceDisabled.Options.UseBackColor = true;
            this.btnNovaDespesaContas.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.btnNovaDespesaContas.AppearanceHovered.BackColor2 = System.Drawing.Color.Red;
            this.btnNovaDespesaContas.AppearanceHovered.Options.UseBackColor = true;
            this.btnNovaDespesaContas.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnNovaDespesaContas.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnNovaDespesaContas.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.btnNovaDespesaContas.AppearancePressed.Options.UseBackColor = true;
            this.btnNovaDespesaContas.AppearancePressed.Options.UseBorderColor = true;
            this.btnNovaDespesaContas.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.adcao9;
            this.btnNovaDespesaContas.ImageOptions.ImageIndex = 5;
            this.btnNovaDespesaContas.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnNovaDespesaContas.ImageOptions.ImageToTextIndent = 10;
            this.btnNovaDespesaContas.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNovaDespesaContas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNovaDespesaContas.Location = new System.Drawing.Point(19, 53);
            this.btnNovaDespesaContas.Name = "btnNovaDespesaContas";
            this.btnNovaDespesaContas.Size = new System.Drawing.Size(217, 30);
            this.btnNovaDespesaContas.TabIndex = 80;
            this.btnNovaDespesaContas.Text = "Nova Despesas/Contas";
            this.btnNovaDespesaContas.Click += new System.EventHandler(this.btnNovaDespesaContas_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(19, 145);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(949, 243);
            this.gridControl1.TabIndex = 296;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "update";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_despesa,
            this.rg_tipo_cadastro,
            this.rg_nome,
            this.rg_cpf,
            this.rg_nome_fantasia,
            this.rg_cnpj,
            this.dp_parcelas,
            this.cd_categoria,
            this.dp_sub_valor_total,
            this.dp_vencimento,
            this.dp_imagem});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing_1);
            // 
            // id_despesa
            // 
            this.id_despesa.AppearanceCell.Options.UseTextOptions = true;
            this.id_despesa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id_despesa.AppearanceHeader.Options.UseTextOptions = true;
            this.id_despesa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id_despesa.Caption = "ID";
            this.id_despesa.FieldName = "id_despesa";
            this.id_despesa.Name = "id_despesa";
            this.id_despesa.Visible = true;
            this.id_despesa.VisibleIndex = 0;
            // 
            // rg_tipo_cadastro
            // 
            this.rg_tipo_cadastro.AppearanceCell.Options.UseTextOptions = true;
            this.rg_tipo_cadastro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rg_tipo_cadastro.AppearanceHeader.Options.UseTextOptions = true;
            this.rg_tipo_cadastro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rg_tipo_cadastro.Caption = "Tipo Cadastro";
            this.rg_tipo_cadastro.FieldName = "rg_tipo_cadastro";
            this.rg_tipo_cadastro.Name = "rg_tipo_cadastro";
            this.rg_tipo_cadastro.Visible = true;
            this.rg_tipo_cadastro.VisibleIndex = 1;
            // 
            // rg_nome
            // 
            this.rg_nome.AppearanceCell.Options.UseTextOptions = true;
            this.rg_nome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rg_nome.AppearanceHeader.Options.UseTextOptions = true;
            this.rg_nome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rg_nome.Caption = "Nome";
            this.rg_nome.FieldName = "rg_nome";
            this.rg_nome.Name = "rg_nome";
            this.rg_nome.Visible = true;
            this.rg_nome.VisibleIndex = 2;
            // 
            // rg_cpf
            // 
            this.rg_cpf.AppearanceCell.Options.UseTextOptions = true;
            this.rg_cpf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rg_cpf.AppearanceHeader.Options.UseTextOptions = true;
            this.rg_cpf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rg_cpf.Caption = "CPF";
            this.rg_cpf.FieldName = "rg_cpf";
            this.rg_cpf.Name = "rg_cpf";
            this.rg_cpf.Visible = true;
            this.rg_cpf.VisibleIndex = 3;
            // 
            // rg_nome_fantasia
            // 
            this.rg_nome_fantasia.AppearanceCell.Options.UseTextOptions = true;
            this.rg_nome_fantasia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rg_nome_fantasia.AppearanceHeader.Options.UseTextOptions = true;
            this.rg_nome_fantasia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rg_nome_fantasia.Caption = "Nome Fantasia";
            this.rg_nome_fantasia.FieldName = "rg_nome_fantasia";
            this.rg_nome_fantasia.Name = "rg_nome_fantasia";
            this.rg_nome_fantasia.Visible = true;
            this.rg_nome_fantasia.VisibleIndex = 4;
            // 
            // rg_cnpj
            // 
            this.rg_cnpj.AppearanceCell.Options.UseTextOptions = true;
            this.rg_cnpj.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rg_cnpj.AppearanceHeader.Options.UseTextOptions = true;
            this.rg_cnpj.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rg_cnpj.Caption = "CNPJ";
            this.rg_cnpj.FieldName = "rg_cnpj";
            this.rg_cnpj.Name = "rg_cnpj";
            this.rg_cnpj.Visible = true;
            this.rg_cnpj.VisibleIndex = 5;
            // 
            // dp_parcelas
            // 
            this.dp_parcelas.AppearanceCell.Options.UseTextOptions = true;
            this.dp_parcelas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dp_parcelas.AppearanceHeader.Options.UseTextOptions = true;
            this.dp_parcelas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dp_parcelas.Caption = "Parcela";
            this.dp_parcelas.FieldName = "dp_parcelas";
            this.dp_parcelas.Name = "dp_parcelas";
            this.dp_parcelas.Visible = true;
            this.dp_parcelas.VisibleIndex = 6;
            // 
            // cd_categoria
            // 
            this.cd_categoria.AppearanceCell.Options.UseTextOptions = true;
            this.cd_categoria.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cd_categoria.AppearanceHeader.Options.UseTextOptions = true;
            this.cd_categoria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cd_categoria.Caption = "Categoria";
            this.cd_categoria.FieldName = "cd_categoria";
            this.cd_categoria.Name = "cd_categoria";
            this.cd_categoria.Visible = true;
            this.cd_categoria.VisibleIndex = 7;
            // 
            // dp_sub_valor_total
            // 
            this.dp_sub_valor_total.AppearanceCell.Options.UseTextOptions = true;
            this.dp_sub_valor_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dp_sub_valor_total.AppearanceHeader.Options.UseTextOptions = true;
            this.dp_sub_valor_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dp_sub_valor_total.Caption = "Valor";
            this.dp_sub_valor_total.DisplayFormat.FormatString = "C2";
            this.dp_sub_valor_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dp_sub_valor_total.FieldName = "dp_sub_valor_total";
            this.dp_sub_valor_total.Name = "dp_sub_valor_total";
            this.dp_sub_valor_total.Visible = true;
            this.dp_sub_valor_total.VisibleIndex = 8;
            // 
            // dp_vencimento
            // 
            this.dp_vencimento.AppearanceCell.Options.UseTextOptions = true;
            this.dp_vencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dp_vencimento.AppearanceHeader.Options.UseTextOptions = true;
            this.dp_vencimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dp_vencimento.Caption = "Vencimento";
            this.dp_vencimento.FieldName = "dp_vencimento";
            this.dp_vencimento.Name = "dp_vencimento";
            this.dp_vencimento.Visible = true;
            this.dp_vencimento.VisibleIndex = 9;
            // 
            // dp_imagem
            // 
            this.dp_imagem.AppearanceCell.Options.UseTextOptions = true;
            this.dp_imagem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dp_imagem.AppearanceHeader.Options.UseTextOptions = true;
            this.dp_imagem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dp_imagem.Caption = "Status";
            this.dp_imagem.FieldName = "dp_imagem";
            this.dp_imagem.Name = "dp_imagem";
            this.dp_imagem.Visible = true;
            this.dp_imagem.VisibleIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 20);
            this.labelControl3.TabIndex = 298;
            this.labelControl3.Text = "Despesas / Contas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox2.Location = new System.Drawing.Point(-162, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1305, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 300;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-14, 28);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(215, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 301;
            this.pictureBox6.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(19, 449);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(124, 20);
            this.labelControl4.TabIndex = 303;
            this.labelControl4.Text = "Total Aguardando:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(375, 449);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(114, 20);
            this.labelControl5.TabIndex = 304;
            this.labelControl5.Text = "Total Finalizadas:";
            // 
            // lblTotalAguardando
            // 
            this.lblTotalAguardando.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAguardando.Appearance.Options.UseFont = true;
            this.lblTotalAguardando.Location = new System.Drawing.Point(149, 449);
            this.lblTotalAguardando.Name = "lblTotalAguardando";
            this.lblTotalAguardando.Size = new System.Drawing.Size(48, 20);
            this.lblTotalAguardando.TabIndex = 306;
            this.lblTotalAguardando.Text = "R$ 0,00";
            // 
            // lblTotalFinalizadas
            // 
            this.lblTotalFinalizadas.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFinalizadas.Appearance.Options.UseFont = true;
            this.lblTotalFinalizadas.Location = new System.Drawing.Point(495, 449);
            this.lblTotalFinalizadas.Name = "lblTotalFinalizadas";
            this.lblTotalFinalizadas.Size = new System.Drawing.Size(48, 20);
            this.lblTotalFinalizadas.TabIndex = 307;
            this.lblTotalFinalizadas.Text = "R$ 0,00";
            // 
            // lblTotalAtrasadas
            // 
            this.lblTotalAtrasadas.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAtrasadas.Appearance.Options.UseFont = true;
            this.lblTotalAtrasadas.Location = new System.Drawing.Point(833, 449);
            this.lblTotalAtrasadas.Name = "lblTotalAtrasadas";
            this.lblTotalAtrasadas.Size = new System.Drawing.Size(48, 20);
            this.lblTotalAtrasadas.TabIndex = 308;
            this.lblTotalAtrasadas.Text = "R$ 0,00";
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Location = new System.Drawing.Point(89, 494);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 25);
            this.lblTotal.TabIndex = 310;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(19, 494);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(64, 25);
            this.labelControl11.TabIndex = 309;
            this.labelControl11.Text = "TOTAL:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(721, 449);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(106, 20);
            this.labelControl13.TabIndex = 311;
            this.labelControl13.Text = "Total Atrasadas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox1.Location = new System.Drawing.Point(-162, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1305, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 313;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(19, 404);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(44, 15);
            this.labelControl14.TabIndex = 314;
            this.labelControl14.Text = "Valores:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 15);
            this.labelControl2.TabIndex = 302;
            this.labelControl2.Text = "Contas a pagar:";
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
            this.btnFechar.Location = new System.Drawing.Point(961, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 315;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRealizarPagamento)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnRealizarPagamento
            // 
            this.btnRealizarPagamento.Caption = "Realizar Pagamento";
            this.btnRealizarPagamento.Id = 0;
            this.btnRealizarPagamento.Name = "btnRealizarPagamento";
            this.btnRealizarPagamento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAlterar_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnRealizarPagamento,
            this.btnDeletar});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(987, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 533);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(987, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 533);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(987, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 533);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Caption = "Deletar";
            this.btnDeletar.Id = 1;
            this.btnDeletar.Name = "btnDeletar";
            // 
            // frmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 533);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.lblTotalAtrasadas);
            this.Controls.Add(this.lblTotalFinalizadas);
            this.Controls.Add(this.lblTotalAguardando);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnNovaDespesaContas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFinanceiro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFinanceiro_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmFinanceiro_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmFinanceiro_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnNovaDespesaContas;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn id_despesa;
        private DevExpress.XtraGrid.Columns.GridColumn rg_tipo_cadastro;
        private DevExpress.XtraGrid.Columns.GridColumn rg_cpf;
        private DevExpress.XtraGrid.Columns.GridColumn rg_cnpj;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblTotalAguardando;
        private DevExpress.XtraEditors.LabelControl lblTotalFinalizadas;
        private DevExpress.XtraEditors.LabelControl lblTotalAtrasadas;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn rg_nome_fantasia;
        private DevExpress.XtraGrid.Columns.GridColumn cd_categoria;
        private DevExpress.XtraGrid.Columns.GridColumn dp_sub_valor_total;
        private DevExpress.XtraGrid.Columns.GridColumn dp_vencimento;
        private DevExpress.XtraGrid.Columns.GridColumn rg_nome;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnRealizarPagamento;
        private DevExpress.XtraBars.BarButtonItem btnDeletar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn dp_parcelas;
        private DevExpress.XtraGrid.Columns.GridColumn dp_imagem;
    }
}