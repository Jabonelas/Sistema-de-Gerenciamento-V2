﻿using DevExpress.XtraGrid;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmCadastroUsuario : DevExpress.XtraEditors.XtraForm
    {
        public int? FK_Permissoes = 0;

        private int? IDCadastro = 0;

        public frmCadastroUsuario(int? iDCadastro)
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource2.FillAsync();

            txtSenha.Properties.UseSystemPasswordChar = true;
            txtConfirmacaoSenha.Properties.UseSystemPasswordChar = true;

            IDCadastro = iDCadastro;

            ReloadData();

            BuscarFKPermissoes();

            TelaPermissoes();
        }

        public frmCadastroUsuario()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource2.FillAsync();

            txtSenha.Properties.UseSystemPasswordChar = true;
            txtConfirmacaoSenha.Properties.UseSystemPasswordChar = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaPermissoes()
        {
            pnlPermissoes.Controls.Clear();
            frmPermissoes frmPermissoes = new frmPermissoes(this);
            frmPermissoes.TopLevel = false;
            pnlPermissoes.Controls.Add(frmPermissoes);
            pnlPermissoes.Tag = frmPermissoes;
            frmPermissoes.Show();
        }

        private void txtSenha_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaSenha(e);
        }

        private void txtConfirmacaoSenha_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaSenha(e);
        }

        private void txtConfirmacaoSenha_Leave(object sender, EventArgs e)
        {
            if (txtConfirmacaoSenha.Text != string.Empty)
            {
                if (txtSenha.Text != txtConfirmacaoSenha.Text)
                {
                    MensagemAtencao.MensagemSenhasDivergentes();

                    txtConfirmacaoSenha.BackColor = Color.LightGray;
                }
                else
                {
                    txtConfirmacaoSenha.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
        }

        private void txtNome_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtNomeUsuario);
        }

        private void pcbExibirSenha_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            txtSenha.Properties.UseSystemPasswordChar = false;
            txtConfirmacaoSenha.Properties.UseSystemPasswordChar = false;

            pcbExibirSenha.Image = Resources.olho_aberto_20;
        }

        private void pcbExibirSenha_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            txtSenha.Properties.UseSystemPasswordChar = true;

            txtConfirmacaoSenha.Properties.UseSystemPasswordChar = true;

            pcbExibirSenha.Image = Resources.olho_20;
        }

        private void frmCadastroUsuario_Shown(object sender, EventArgs e)
        {
            TelaPermissoes();
        }

        private void cmbFuncionario_TextChanged(object sender, EventArgs e)
        {
            IDCadastro = Convert.ToInt32(cmbFuncionario.Properties.GetKeyValueByDisplayValue(cmbFuncionario.Text));

            ReloadData();

            BuscarFKPermissoes();

            TelaPermissoes();
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(this))
            {
                BuscarFKPermissoes();
            }
        }

        private async void BuscarFKPermissoes()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities7 db = new SistemaDeGerenciamento2_0Entities7())
                {
                    var FKPermissoes = db.tb_registro.Where(x => x.id_registro == IDCadastro)
                    .Select(x => new { x.fk_permissoes, x.rg_login, x.rg_senha }).ToList();

                    foreach (var item in FKPermissoes)
                    {
                        txtNomeUsuario.Text = item.rg_login;
                        txtSenha.Text = item.rg_senha;
                        txtConfirmacaoSenha.Text = item.rg_senha;
                        FK_Permissoes = item.fk_permissoes;
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Usuario e Senha na tela de Cadastro Novo Usuário - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarDadosNovoUsuario(x);
            }
        }
    }
}