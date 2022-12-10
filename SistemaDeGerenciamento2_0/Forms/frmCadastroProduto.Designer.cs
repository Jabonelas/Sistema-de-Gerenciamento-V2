namespace SistemaDeGerenciamento2_0.Forms
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacoes = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.pcbRequesitosCodigo = new DevExpress.XtraEditors.PictureEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCusto = new DevExpress.XtraEditors.TextEdit();
            this.txtMargemLucro = new DevExpress.XtraEditors.TextEdit();
            this.txtPreco = new DevExpress.XtraEditors.TextEdit();
            this.txtEstoqueMinimo = new DevExpress.XtraEditors.TextEdit();
            this.txtTipoUnidade = new DevExpress.XtraEditors.TextEdit();
            this.cmbTipoProduto = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbFinalidade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoDeBarras = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAcessarGrupoSubGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pcbRequesitosCodigoDeBarras = new DevExpress.XtraEditors.PictureEdit();
            this.cmbFornecedor = new DevExpress.XtraEditors.LookUpEdit();
            this.queryFornecedor = new System.Windows.Forms.BindingSource(this.components);
            this.sqlFornecedor = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.AlertaSalvar = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.cmbGrupo = new DevExpress.XtraEditors.LookUpEdit();
            this.queryGrupo = new System.Windows.Forms.BindingSource(this.components);
            this.sqlGrupo = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRequesitosCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargemLucro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoqueMinimo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoUnidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinalidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDeBarras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRequesitosCodigoDeBarras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(30, 362);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(81, 20);
            this.labelControl12.TabIndex = 99;
            this.labelControl12.Text = "Observação:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(501, 279);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(40, 20);
            this.labelControl11.TabIndex = 95;
            this.labelControl11.Text = "Preço:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(267, 279);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(120, 20);
            this.labelControl10.TabIndex = 94;
            this.labelControl10.Text = "Margem de Lucro:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(738, 279);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(111, 20);
            this.labelControl9.TabIndex = 91;
            this.labelControl9.Text = "Estoque Mínimo:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(331, 204);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(97, 20);
            this.labelControl8.TabIndex = 89;
            this.labelControl8.Text = "Tipo Unidade:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(675, 204);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 20);
            this.labelControl7.TabIndex = 88;
            this.labelControl7.Text = "Tipo Produto:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(30, 279);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 20);
            this.labelControl6.TabIndex = 82;
            this.labelControl6.Text = "Custo:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(675, 129);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 20);
            this.labelControl5.TabIndex = 81;
            this.labelControl5.Text = "Grupo:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(30, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 20);
            this.labelControl4.TabIndex = 80;
            this.labelControl4.Text = "Nome:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(675, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 20);
            this.labelControl3.TabIndex = 79;
            this.labelControl3.Text = "Finalidade:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(331, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(118, 20);
            this.labelControl2.TabIndex = 78;
            this.labelControl2.Text = "Código de Barras:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 20);
            this.labelControl1.TabIndex = 77;
            this.labelControl1.Text = "Código:";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtObservacoes.Appearance.Text.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Appearance.Text.Options.UseFont = true;
            this.txtObservacoes.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtObservacoes.Location = new System.Drawing.Point(30, 388);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtObservacoes.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtObservacoes.Size = new System.Drawing.Size(888, 89);
            this.txtObservacoes.TabIndex = 14;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(30, 11);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(170, 20);
            this.labelControl13.TabIndex = 101;
            this.labelControl13.Text = "Cadastrar Novo Produto";
            // 
            // pcbRequesitosCodigo
            // 
            this.pcbRequesitosCodigo.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.informacao20;
            this.pcbRequesitosCodigo.Location = new System.Drawing.Point(86, 62);
            this.pcbRequesitosCodigo.Name = "pcbRequesitosCodigo";
            this.pcbRequesitosCodigo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcbRequesitosCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.pcbRequesitosCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcbRequesitosCodigo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcbRequesitosCodigo.Properties.ZoomAcceleration = 5D;
            this.pcbRequesitosCodigo.Size = new System.Drawing.Size(23, 20);
            this.pcbRequesitosCodigo.TabIndex = 105;
            this.pcbRequesitosCodigo.ToolTip = "De 1 até 20 caracteres\r\ncom letras e números, \r\nsem caracteres especiais \r\ncomo e" +
    "spaço e símbolos.";
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
            this.btnCancelar.Location = new System.Drawing.Point(805, 492);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 30);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar (Esc)";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Appearance.Options.UseFont = true;
            this.btnSalvar.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.salvar;
            this.btnSalvar.ImageOptions.ImageIndex = 5;
            this.btnSalvar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnSalvar.ImageOptions.ImageToTextIndent = 10;
            this.btnSalvar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(675, 492);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 30);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar (F10)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(30, 305);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto.Properties.Appearance.Options.UseFont = true;
            this.txtCusto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCusto.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCusto.Properties.MaskSettings.Set("mask", "c");
            this.txtCusto.Properties.MaskSettings.Set("hideInsignificantZeros", null);
            this.txtCusto.Properties.MaxLength = 20;
            this.txtCusto.Properties.NullText = "R$ 0,00";
            this.txtCusto.Properties.UseMaskAsDisplayFormat = true;
            this.txtCusto.Size = new System.Drawing.Size(180, 26);
            this.txtCusto.TabIndex = 9;
            this.txtCusto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCusto_KeyUp);
            this.txtCusto.Leave += new System.EventHandler(this.txtCusto_Leave);
            // 
            // txtMargemLucro
            // 
            this.txtMargemLucro.Location = new System.Drawing.Point(266, 305);
            this.txtMargemLucro.Name = "txtMargemLucro";
            this.txtMargemLucro.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargemLucro.Properties.Appearance.Options.UseFont = true;
            this.txtMargemLucro.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMargemLucro.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtMargemLucro.Properties.MaskSettings.Set("mask", "P");
            this.txtMargemLucro.Properties.MaxLength = 20;
            this.txtMargemLucro.Properties.NullText = "0,00%";
            this.txtMargemLucro.Properties.UseMaskAsDisplayFormat = true;
            this.txtMargemLucro.Size = new System.Drawing.Size(180, 26);
            this.txtMargemLucro.TabIndex = 10;
            this.txtMargemLucro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMargemLucro_KeyUp);
            this.txtMargemLucro.Leave += new System.EventHandler(this.txtMargemLucro_Leave);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(502, 305);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Properties.Appearance.Options.UseFont = true;
            this.txtPreco.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPreco.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPreco.Properties.MaskSettings.Set("mask", "c");
            this.txtPreco.Properties.MaxLength = 20;
            this.txtPreco.Properties.NullText = "R$ 0,00";
            this.txtPreco.Properties.UseMaskAsDisplayFormat = true;
            this.txtPreco.Size = new System.Drawing.Size(180, 26);
            this.txtPreco.TabIndex = 12;
            this.txtPreco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPreco_KeyUp);
            this.txtPreco.Leave += new System.EventHandler(this.txtPreco_Leave);
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(738, 305);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMinimo.Properties.Appearance.Options.UseFont = true;
            this.txtEstoqueMinimo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtEstoqueMinimo.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtEstoqueMinimo.Properties.MaskSettings.Set("mask", "d");
            this.txtEstoqueMinimo.Properties.MaxLength = 20;
            this.txtEstoqueMinimo.Properties.NullText = "0";
            this.txtEstoqueMinimo.Properties.UseMaskAsDisplayFormat = true;
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(180, 26);
            this.txtEstoqueMinimo.TabIndex = 13;
            this.txtEstoqueMinimo.Leave += new System.EventHandler(this.txtEstoqueMinimo_Leave);
            // 
            // txtTipoUnidade
            // 
            this.txtTipoUnidade.Location = new System.Drawing.Point(328, 230);
            this.txtTipoUnidade.Name = "txtTipoUnidade";
            this.txtTipoUnidade.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoUnidade.Properties.Appearance.Options.UseFont = true;
            this.txtTipoUnidade.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtTipoUnidade.Properties.MaskSettings.Set("mask", "\\p{L}+");
            this.txtTipoUnidade.Properties.MaxLength = 20;
            this.txtTipoUnidade.Properties.NullText = "Ex.: Peça, Un, Kg";
            this.txtTipoUnidade.Size = new System.Drawing.Size(288, 26);
            this.txtTipoUnidade.TabIndex = 7;
            // 
            // cmbTipoProduto
            // 
            this.cmbTipoProduto.Location = new System.Drawing.Point(674, 230);
            this.cmbTipoProduto.Name = "cmbTipoProduto";
            this.cmbTipoProduto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoProduto.Properties.Appearance.Options.UseFont = true;
            this.cmbTipoProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoProduto.Properties.Items.AddRange(new object[] {
            "Normal",
            "Composicao",
            "Grade"});
            this.cmbTipoProduto.Properties.MaxLength = 20;
            this.cmbTipoProduto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTipoProduto.Size = new System.Drawing.Size(243, 26);
            this.cmbTipoProduto.TabIndex = 8;
            this.cmbTipoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoProduto_KeyPress);
            // 
            // cmbFinalidade
            // 
            this.cmbFinalidade.Location = new System.Drawing.Point(675, 88);
            this.cmbFinalidade.Name = "cmbFinalidade";
            this.cmbFinalidade.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFinalidade.Properties.Appearance.Options.UseFont = true;
            this.cmbFinalidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFinalidade.Properties.Items.AddRange(new object[] {
            "Venda ",
            "Uso / Consumo",
            "Matéria Prima"});
            this.cmbFinalidade.Properties.MaxLength = 20;
            this.cmbFinalidade.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbFinalidade.Size = new System.Drawing.Size(243, 26);
            this.cmbFinalidade.TabIndex = 2;
            this.cmbFinalidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFinalidade_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(30, 156);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Properties.Appearance.Options.UseFont = true;
            this.txtNome.Size = new System.Drawing.Size(589, 26);
            this.txtNome.TabIndex = 3;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(330, 88);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDeBarras.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoDeBarras.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCodigoDeBarras.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCodigoDeBarras.Properties.MaskSettings.Set("mask", "d");
            this.txtCodigoDeBarras.Properties.MaxLength = 20;
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(288, 26);
            this.txtCodigoDeBarras.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(30, 88);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.MaxLength = 20;
            this.txtCodigo.Size = new System.Drawing.Size(243, 26);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnFechar.Appearance.Options.UseBorderColor = true;
            this.btnFechar.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnFechar.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.ImageOptions.Image")));
            this.btnFechar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFechar.Location = new System.Drawing.Point(928, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 75;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAcessarGrupoSubGrupo
            // 
            this.btnAcessarGrupoSubGrupo.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.ferramenta_preta20;
            this.btnAcessarGrupoSubGrupo.Location = new System.Drawing.Point(887, 156);
            this.btnAcessarGrupoSubGrupo.Name = "btnAcessarGrupoSubGrupo";
            this.btnAcessarGrupoSubGrupo.Size = new System.Drawing.Size(31, 26);
            this.btnAcessarGrupoSubGrupo.TabIndex = 5;
            this.btnAcessarGrupoSubGrupo.ToolTip = "Criar/Editar grupos";
            this.btnAcessarGrupoSubGrupo.Click += new System.EventHandler(this.btnAcessarGrupoSubGrupo_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.separador;
            this.pictureBox6.Location = new System.Drawing.Point(-132, 37);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1208, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 93;
            this.pictureBox6.TabStop = false;
            // 
            // pcbRequesitosCodigoDeBarras
            // 
            this.pcbRequesitosCodigoDeBarras.EditValue = global::SistemaDeGerenciamento2_0.Properties.Resources.informacao20;
            this.pcbRequesitosCodigoDeBarras.Location = new System.Drawing.Point(457, 62);
            this.pcbRequesitosCodigoDeBarras.Name = "pcbRequesitosCodigoDeBarras";
            this.pcbRequesitosCodigoDeBarras.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcbRequesitosCodigoDeBarras.Properties.Appearance.Options.UseBackColor = true;
            this.pcbRequesitosCodigoDeBarras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcbRequesitosCodigoDeBarras.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcbRequesitosCodigoDeBarras.Properties.ZoomAcceleration = 5D;
            this.pcbRequesitosCodigoDeBarras.Size = new System.Drawing.Size(23, 20);
            this.pcbRequesitosCodigoDeBarras.TabIndex = 106;
            this.pcbRequesitosCodigoDeBarras.ToolTip = "Se não for informado, \r\num código de barras\r\n para uso interno será\r\ngerado.";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Location = new System.Drawing.Point(30, 230);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.Properties.Appearance.Options.UseFont = true;
            this.cmbFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFornecedor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_registro", "ID", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("rg_cnpj", "CNPJ", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("rg_nome_fantasia", "Nome Fantasia", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbFornecedor.Properties.DataSource = this.queryFornecedor;
            this.cmbFornecedor.Properties.DisplayMember = "rg_cnpj";
            this.cmbFornecedor.Properties.DropDownRows = 5;
            this.cmbFornecedor.Properties.MaxLength = 20;
            this.cmbFornecedor.Properties.NullText = "";
            this.cmbFornecedor.Properties.PopupSizeable = false;
            this.cmbFornecedor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbFornecedor.Properties.ValueMember = "id_registro";
            this.cmbFornecedor.Size = new System.Drawing.Size(240, 26);
            this.cmbFornecedor.TabIndex = 6;
            // 
            // queryFornecedor
            // 
            this.queryFornecedor.DataMember = "Query";
            this.queryFornecedor.DataSource = this.sqlFornecedor;
            // 
            // sqlFornecedor
            // 
            this.sqlFornecedor.ConnectionName = "SistemaDeGerenciamento2_0.Properties.Settings.SistemaDeGerenciamento2_0Connection" +
    "String";
            this.sqlFornecedor.Name = "sqlFornecedor";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlFornecedor.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlFornecedor.ResultSchemaSerializable = resources.GetString("sqlFornecedor.ResultSchemaSerializable");
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(30, 204);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(78, 20);
            this.labelControl14.TabIndex = 110;
            this.labelControl14.Text = "Fornecedor:";
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
            // cmbGrupo
            // 
            this.cmbGrupo.Location = new System.Drawing.Point(675, 156);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrupo.Properties.Appearance.Options.UseFont = true;
            this.cmbGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGrupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_grupo", "ID", 25, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gp_nome_grupo", "Nome Grupo", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("gp_nome_agrupador", "Nome Agrupador", 109, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbGrupo.Properties.DataSource = this.queryGrupo;
            this.cmbGrupo.Properties.DisplayMember = "gp_nome_grupo";
            this.cmbGrupo.Properties.DropDownRows = 5;
            this.cmbGrupo.Properties.MaxLength = 20;
            this.cmbGrupo.Properties.NullText = "";
            this.cmbGrupo.Properties.PopupSizeable = false;
            this.cmbGrupo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbGrupo.Properties.ValueMember = "id_grupo";
            this.cmbGrupo.Size = new System.Drawing.Size(206, 26);
            this.cmbGrupo.TabIndex = 4;
            // 
            // queryGrupo
            // 
            this.queryGrupo.DataMember = "Query";
            this.queryGrupo.DataSource = this.sqlGrupo;
            // 
            // sqlGrupo
            // 
            this.sqlGrupo.ConnectionName = "SistemaDeGerenciamento2_0.Properties.Settings.SistemaDeGerenciamento2_0Connection" +
    "String";
            this.sqlGrupo.Name = "sqlGrupo";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = "select \"tb_grupo\".\"id_grupo\",\r\n       \"tb_grupo\".\"gp_nome_grupo\",\r\n       \"tb_gru" +
    "po\".\"gp_nome_agrupador\"\r\n  from \"dbo\".\"tb_grupo\" \"tb_grupo\"\r\nwhere  \"tb_grupo\".\"" +
    "gp_nome_grupo\" is not null";
            this.sqlGrupo.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlGrupo.ResultSchemaSerializable = resources.GetString("sqlGrupo.ResultSchemaSerializable");
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 538);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.pcbRequesitosCodigoDeBarras);
            this.Controls.Add(this.pcbRequesitosCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.txtMargemLucro);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtEstoqueMinimo);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtTipoUnidade);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.cmbTipoProduto);
            this.Controls.Add(this.cmbFinalidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigoDeBarras);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAcessarGrupoSubGrupo);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telacadastro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroProduto_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCadastroProduto_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCadastroProduto_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRequesitosCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargemLucro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoqueMinimo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoUnidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinalidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDeBarras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRequesitosCodigoDeBarras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtCusto;
        private DevExpress.XtraEditors.TextEdit txtMargemLucro;
        private DevExpress.XtraEditors.TextEdit txtPreco;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtEstoqueMinimo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtTipoUnidade;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoProduto;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFinalidade;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.TextEdit txtCodigoDeBarras;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.SimpleButton btnAcessarGrupoSubGrupo;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraRichEdit.RichEditControl txtObservacoes;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.PictureEdit pcbRequesitosCodigo;
        private DevExpress.XtraEditors.PictureEdit pcbRequesitosCodigoDeBarras;
        private DevExpress.XtraEditors.LookUpEdit cmbFornecedor;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraBars.Alerter.AlertControl AlertaSalvar;
        private DevExpress.XtraEditors.LookUpEdit cmbGrupo;
        private System.Windows.Forms.BindingSource queryGrupo;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlGrupo;
        private System.Windows.Forms.BindingSource queryFornecedor;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlFornecedor;
    }
}