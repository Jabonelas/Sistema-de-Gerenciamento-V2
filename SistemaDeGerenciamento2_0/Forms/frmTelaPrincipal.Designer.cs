namespace SistemaDeGerenciamento2_0
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.pnlTelaPrincipal = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnAcessoRapido = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.VisaoGeral = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PDV = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Financeiro = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Cadastro = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Produtos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Relatorios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Configuracao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTelaPrincipal
            // 
            this.pnlTelaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTelaPrincipal.Location = new System.Drawing.Point(260, 31);
            this.pnlTelaPrincipal.Name = "pnlTelaPrincipal";
            this.pnlTelaPrincipal.Size = new System.Drawing.Size(973, 447);
            this.pnlTelaPrincipal.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Default.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Default.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnAcessoRapido,
            this.VisaoGeral,
            this.PDV,
            this.Financeiro,
            this.Cadastro,
            this.Produtos,
            this.Relatorios,
            this.Configuracao});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 447);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnAcessoRapido
            // 
            this.btnAcessoRapido.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.foguete_preto2;
            this.btnAcessoRapido.Name = "btnAcessoRapido";
            this.btnAcessoRapido.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAcessoRapido.Text = "Acesso Rápido";
            this.btnAcessoRapido.Click += new System.EventHandler(this.btnAcessoRapido_Click_1);
            // 
            // VisaoGeral
            // 
            this.VisaoGeral.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.VisaoGeral.Appearance.Default.Options.UseFont = true;
            this.VisaoGeral.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.VisaoGeral.Appearance.Disabled.Options.UseFont = true;
            this.VisaoGeral.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.VisaoGeral.Appearance.Hovered.Options.UseFont = true;
            this.VisaoGeral.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.VisaoGeral.Appearance.Normal.Options.UseFont = true;
            this.VisaoGeral.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisaoGeral.Appearance.Pressed.Options.UseFont = true;
            this.VisaoGeral.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.olhos_preto;
            this.VisaoGeral.Name = "VisaoGeral";
            this.VisaoGeral.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.VisaoGeral.Text = "Visão Geral";
            // 
            // PDV
            // 
            this.PDV.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.PDV.Appearance.Default.Options.UseFont = true;
            this.PDV.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.PDV.Appearance.Disabled.Options.UseFont = true;
            this.PDV.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.PDV.Appearance.Hovered.Options.UseFont = true;
            this.PDV.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.PDV.Appearance.Normal.Options.UseFont = true;
            this.PDV.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.PDV.Appearance.Pressed.Options.UseFont = true;
            this.PDV.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.computer_preto;
            this.PDV.Name = "PDV";
            this.PDV.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.PDV.Text = "PDV";
            // 
            // Financeiro
            // 
            this.Financeiro.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Financeiro.Appearance.Default.Options.UseFont = true;
            this.Financeiro.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Financeiro.Appearance.Disabled.Options.UseFont = true;
            this.Financeiro.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Financeiro.Appearance.Hovered.Options.UseFont = true;
            this.Financeiro.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Financeiro.Appearance.Normal.Options.UseFont = true;
            this.Financeiro.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Financeiro.Appearance.Pressed.Options.UseFont = true;
            this.Financeiro.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.dinheiro_preto3;
            this.Financeiro.Name = "Financeiro";
            this.Financeiro.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Financeiro.Text = "Financeiro";
            this.Financeiro.Click += new System.EventHandler(this.Financeiro_Click);
            // 
            // Cadastro
            // 
            this.Cadastro.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Cadastro.Appearance.Default.Options.UseFont = true;
            this.Cadastro.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Cadastro.Appearance.Disabled.Options.UseFont = true;
            this.Cadastro.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Cadastro.Appearance.Hovered.Options.UseFont = true;
            this.Cadastro.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Cadastro.Appearance.Normal.Options.UseFont = true;
            this.Cadastro.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Cadastro.Appearance.Pressed.Options.UseFont = true;
            this.Cadastro.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.cadastros_preto_1;
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Cadastro.Text = "Cadastros";
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // Produtos
            // 
            this.Produtos.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.produto_preto2;
            this.Produtos.Name = "Produtos";
            this.Produtos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Produtos.Text = "Produtos";
            this.Produtos.Click += new System.EventHandler(this.Produtos_Click);
            // 
            // Relatorios
            // 
            this.Relatorios.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.relatorio_preto;
            this.Relatorios.Name = "Relatorios";
            this.Relatorios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Relatorios.Text = "Relatórios";
            // 
            // Configuracao
            // 
            this.Configuracao.ImageOptions.Image = global::SistemaDeGerenciamento2_0.Properties.Resources.configuracao_preta1;
            this.Configuracao.Name = "Configuracao";
            this.Configuracao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Configuracao.Text = "Configurações";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1233, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.skinBarSubItem1);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Tema";
            this.skinBarSubItem1.Id = 0;
            this.skinBarSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("skinBarSubItem1.ImageOptions.Image")));
            this.skinBarSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("skinBarSubItem1.ImageOptions.LargeImage")));
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            this.skinBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 478);
            this.ControlContainer = this.pnlTelaPrincipal;
            this.Controls.Add(this.pnlTelaPrincipal);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.KeyPreview = true;
            this.Name = "frmTelaPrincipal";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTelaPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer pnlTelaPrincipal;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement VisaoGeral;
        private DevExpress.XtraBars.Navigation.AccordionControlElement PDV;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Financeiro;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Cadastro;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Produtos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Relatorios;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Configuracao;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAcessoRapido;
    }
}

