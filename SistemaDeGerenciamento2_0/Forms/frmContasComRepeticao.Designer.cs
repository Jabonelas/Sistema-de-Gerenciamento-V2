namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmContasComRepeticao
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContasComRepeticao));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbPeriocidade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtObservacoesDespesa = new DevExpress.XtraEditors.TextEdit();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.cmbFornecedor = new DevExpress.XtraEditors.LookUpEdit();
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCategoria = new DevExpress.XtraEditors.LookUpEdit();
            this.tb_cadastro_despesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.txtDataLancamento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtDataVencimento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtObservacoesDespesaRepeticao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.chkRepetirDespesa = new DevExpress.XtraEditors.CheckEdit();
            this.AlertaSalvar = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriocidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacoesDespesa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_cadastro_despesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataLancamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacoesDespesaRepeticao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRepetirDespesa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 325);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 20);
            this.labelControl3.TabIndex = 83;
            this.labelControl3.Text = "Periodicidade:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(447, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 20);
            this.labelControl4.TabIndex = 84;
            this.labelControl4.Text = "Valor:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(320, 126);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 20);
            this.labelControl5.TabIndex = 85;
            this.labelControl5.Text = "Categoria:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(13, 127);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 20);
            this.labelControl6.TabIndex = 86;
            this.labelControl6.Text = "Fonecedor:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(13, 193);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(87, 20);
            this.labelControl7.TabIndex = 87;
            this.labelControl7.Text = "Observações:";
            // 
            // cmbPeriocidade
            // 
            this.cmbPeriocidade.Enabled = false;
            this.cmbPeriocidade.Location = new System.Drawing.Point(13, 350);
            this.cmbPeriocidade.Name = "cmbPeriocidade";
            this.cmbPeriocidade.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriocidade.Properties.Appearance.Options.UseFont = true;
            this.cmbPeriocidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPeriocidade.Properties.Items.AddRange(new object[] {
            "Diário",
            "Semanal",
            "Mensal",
            "Anual"});
            this.cmbPeriocidade.Size = new System.Drawing.Size(191, 36);
            this.cmbPeriocidade.TabIndex = 7;
            // 
            // txtObservacoesDespesa
            // 
            this.txtObservacoesDespesa.Location = new System.Drawing.Point(13, 219);
            this.txtObservacoesDespesa.Name = "txtObservacoesDespesa";
            this.txtObservacoesDespesa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoesDespesa.Properties.Appearance.Options.UseFont = true;
            this.txtObservacoesDespesa.Properties.MaxLength = 200;
            this.txtObservacoesDespesa.Size = new System.Drawing.Size(625, 34);
            this.txtObservacoesDespesa.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(447, 85);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Properties.Appearance.Options.UseFont = true;
            this.txtValor.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtValor.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtValor.Properties.MaskSettings.Set("mask", "c");
            this.txtValor.Properties.MaxLength = 20;
            this.txtValor.Properties.NullText = "R$ 0,00";
            this.txtValor.Properties.UseMaskAsDisplayFormat = true;
            this.txtValor.Size = new System.Drawing.Size(191, 34);
            this.txtValor.TabIndex = 2;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Location = new System.Drawing.Point(13, 153);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.Properties.Appearance.Options.UseFont = true;
            this.cmbFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFornecedor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_registro", "ID", 67, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("rg_cnpj", "CNPJ", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("rg_nome_fantasia", "Nome Fantasia", 103, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbFornecedor.Properties.DataSource = this.queryBindingSource;
            this.cmbFornecedor.Properties.DisplayMember = "rg_nome_fantasia";
            this.cmbFornecedor.Properties.DropDownRows = 5;
            this.cmbFornecedor.Properties.MaxLength = 20;
            this.cmbFornecedor.Properties.NullText = "";
            this.cmbFornecedor.Properties.PopupSizeable = false;
            this.cmbFornecedor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbFornecedor.Properties.ValueMember = "id_registro";
            this.cmbFornecedor.Size = new System.Drawing.Size(280, 34);
            this.cmbFornecedor.TabIndex = 3;
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "update";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery3.Name = "Query";
            customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.cancelar;
            this.btnCancelar.ImageOptions.ImageIndex = 5;
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnCancelar.ImageOptions.ImageToTextIndent = 10;
            this.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(525, 482);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar (Esc)";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Appearance.Options.UseFont = true;
            this.btnSalvar.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.save_20px;
            this.btnSalvar.ImageOptions.ImageIndex = 5;
            this.btnSalvar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnSalvar.ImageOptions.ImageToTextIndent = 10;
            this.btnSalvar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(395, 482);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 30);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar (F10)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Location = new System.Drawing.Point(320, 153);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.Properties.Appearance.Options.UseFont = true;
            this.cmbCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategoria.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_categoria_despesa", "ID", 67, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cd_categoria", "Categoria", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbCategoria.Properties.DataSource = this.tb_cadastro_despesaBindingSource;
            this.cmbCategoria.Properties.DisplayMember = "cd_categoria";
            this.cmbCategoria.Properties.DropDownRows = 5;
            this.cmbCategoria.Properties.MaxLength = 20;
            this.cmbCategoria.Properties.NullText = "";
            this.cmbCategoria.Properties.PopupSizeable = false;
            this.cmbCategoria.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbCategoria.Properties.ValueMember = "id_categoria_despesa";
            this.cmbCategoria.Size = new System.Drawing.Size(318, 34);
            this.cmbCategoria.TabIndex = 4;
            // 
            // tb_cadastro_despesaBindingSource
            // 
            this.tb_cadastro_despesaBindingSource.DataMember = "tb_cadastro_despesa";
            this.tb_cadastro_despesaBindingSource.DataSource = this.sqlDataSource3;
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "update";
            this.sqlDataSource3.Name = "sqlDataSource3";
            columnExpression5.ColumnName = "id_categoria_despesa";
            table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"143\" />";
            table3.Name = "tb_cadastro_despesa";
            columnExpression5.Table = table3;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "cd_categoria";
            columnExpression6.Table = table3;
            column6.Expression = columnExpression6;
            selectQuery3.Columns.Add(column5);
            selectQuery3.Columns.Add(column6);
            selectQuery3.Name = "tb_cadastro_despesa";
            selectQuery3.Tables.Add(table3);
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery3});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // txtDataLancamento
            // 
            this.txtDataLancamento.Location = new System.Drawing.Point(13, 85);
            this.txtDataLancamento.Name = "txtDataLancamento";
            this.txtDataLancamento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataLancamento.Properties.Appearance.Options.UseFont = true;
            this.txtDataLancamento.Properties.MaxLength = 20;
            this.txtDataLancamento.Size = new System.Drawing.Size(191, 34);
            this.txtDataLancamento.TabIndex = 0;
            this.txtDataLancamento.TabStop = false;
            this.txtDataLancamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataLancamento_KeyPress);
            this.txtDataLancamento.Leave += new System.EventHandler(this.txtDataLancamento_Leave);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(13, 59);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(120, 20);
            this.labelControl8.TabIndex = 96;
            this.labelControl8.Text = "Data Lançamento:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(13, 14);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(152, 20);
            this.labelControl13.TabIndex = 121;
            this.labelControl13.Text = "Cadastro de Despesas";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-107, 33);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(864, 21);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 120;
            this.pictureBox6.TabStop = false;
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Location = new System.Drawing.Point(231, 85);
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVencimento.Properties.Appearance.Options.UseFont = true;
            this.txtDataVencimento.Properties.MaxLength = 20;
            this.txtDataVencimento.Size = new System.Drawing.Size(191, 34);
            this.txtDataVencimento.TabIndex = 1;
            this.txtDataVencimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataVencimento_KeyPress);
            this.txtDataVencimento.Leave += new System.EventHandler(this.txtDataVencimento_Leave);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(231, 57);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(118, 20);
            this.labelControl9.TabIndex = 122;
            this.labelControl9.Text = "Data Vencimento:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox1.Location = new System.Drawing.Point(-109, 299);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // txtObservacoesDespesaRepeticao
            // 
            this.txtObservacoesDespesaRepeticao.Enabled = false;
            this.txtObservacoesDespesaRepeticao.Location = new System.Drawing.Point(13, 421);
            this.txtObservacoesDespesaRepeticao.Name = "txtObservacoesDespesaRepeticao";
            this.txtObservacoesDespesaRepeticao.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoesDespesaRepeticao.Properties.Appearance.Options.UseFont = true;
            this.txtObservacoesDespesaRepeticao.Properties.MaxLength = 200;
            this.txtObservacoesDespesaRepeticao.Size = new System.Drawing.Size(625, 34);
            this.txtObservacoesDespesaRepeticao.TabIndex = 8;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(13, 395);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(87, 20);
            this.labelControl11.TabIndex = 126;
            this.labelControl11.Text = "Observações:";
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
            this.btnFechar.Location = new System.Drawing.Point(624, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 128;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // chkRepetirDespesa
            // 
            this.chkRepetirDespesa.Location = new System.Drawing.Point(13, 276);
            this.chkRepetirDespesa.Name = "chkRepetirDespesa";
            this.chkRepetirDespesa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepetirDespesa.Properties.Appearance.Options.UseFont = true;
            this.chkRepetirDespesa.Properties.Caption = "Repetir Despesa";
            this.chkRepetirDespesa.Size = new System.Drawing.Size(249, 25);
            this.chkRepetirDespesa.TabIndex = 6;
            this.chkRepetirDespesa.CheckedChanged += new System.EventHandler(this.chkRepetirDespesa_CheckedChanged);
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
            // frmContasComRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 527);
            this.Controls.Add(this.chkRepetirDespesa);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtObservacoesDespesaRepeticao);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDataVencimento);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtDataLancamento);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cmbPeriocidade);
            this.Controls.Add(this.txtObservacoesDespesa);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmContasComRepeticao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContasComRepeticao";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmContasComRepeticao_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmContasComRepeticao_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmContasComRepeticao_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriocidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacoesDespesa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_cadastro_despesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataLancamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacoesDespesaRepeticao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRepetirDespesa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtObservacoesDespesa;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPeriocidade;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.LookUpEdit cmbFornecedor;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.XtraEditors.LookUpEdit cmbCategoria;
        private System.Windows.Forms.BindingSource tb_cadastro_despesaBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.XtraEditors.TextEdit txtDataLancamento;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.TextEdit txtDataVencimento;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit txtObservacoesDespesaRepeticao;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.CheckEdit chkRepetirDespesa;
        private DevExpress.XtraBars.Alerter.AlertControl AlertaSalvar;
    }
}