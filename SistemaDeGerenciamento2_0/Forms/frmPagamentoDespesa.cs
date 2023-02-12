using DevExpress.XtraEditors;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmPagamentoDespesa : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;
        private int parcela = 0;
        private int idDespesa = 0;
        private decimal valorJuros = 0;
        private decimal valorMulta = 0;
        private string valor = string.Empty;
        private string categoria = string.Empty;
        private string vencimento = string.Empty;
        private string nomeEmpresa = string.Empty;

        public frmPagamentoDespesa(int _idDespesa, int _parcela, string _nomeEmpresa,
            string _categoria, string _valor, DateTime _vencimento)
        {
            InitializeComponent();

            idDespesa = _idDespesa;
            parcela = _parcela;
            nomeEmpresa = _nomeEmpresa;
            categoria = _categoria;
            valor = _valor;
            vencimento = _vencimento.ToShortDateString();

            PreencherTextBox();
        }

        private void PreencherTextBox()
        {
            txtData.Text = DateTime.Now.ToShortDateString();
            txtVencimento.Text = vencimento;
            txtParcela.Text = parcela.ToString();
            txtFornecedor.Text = nomeEmpresa;
            txtCategoria.Text = categoria;
            txtSubCategoria.Text = valor;
            txtValorTotal.Text = valor;
        }

        private void frmPagamentoDespesa_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmPagamentoDespesa_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPagamentoDespesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MensagemAtencao.MensagemCancelar(this);
            }
            else if (e.KeyCode == Keys.F10)
            {
                MensagemAtencao.MensagemConfirmar(this);
            }
        }

        private void txtDesconto_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDesconto.Text != string.Empty)
            {
                decimal valorParcial = Convert.ToDecimal(valor.Replace("R$", string.Empty));
                decimal porcentagemDesconto = Convert.ToDecimal(txtDesconto.Text.Replace("%", string.Empty));
                decimal valorDesconto = (valorParcial * porcentagemDesconto / 100);

                txtValorTotal.Text = (valorParcial - valorDesconto).ToString("C2");
            }
        }

        private void txtJuros_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtJuros.Text != string.Empty)
            {
                decimal valorParcial = Convert.ToDecimal(valor.Replace("R$", string.Empty));
                decimal porcentagemJuros = Convert.ToDecimal(txtJuros.Text.Replace("%", string.Empty));
                valorJuros = (valorParcial * porcentagemJuros / 100);

                txtValorTotal.Text = (valorParcial + valorJuros + valorMulta).ToString("C2");
            }
        }

        private void txtMulta_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMulta.Text != string.Empty)
            {
                decimal valorParcial = Convert.ToDecimal(valor.Replace("R$", string.Empty));
                decimal porcentagemMulta = Convert.ToDecimal(txtMulta.Text.Replace("%", string.Empty));
                valorMulta = (valorParcial * porcentagemMulta / 100);

                txtValorTotal.Text = (valorParcial + valorMulta + valorJuros).ToString("C2");
            }
        }

        private void btnRealizarPagamento_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemConfirmar(this);
        }

        public void RealizarPagamento()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var pagamentoDespesa = db.tb_despesa.Where(x => x.id_despesa.Equals(idDespesa)).ToList();

                    byte[] imagem;
                    ImageConverter converter = new ImageConverter();
                    imagem = (byte[])converter.ConvertTo(Resources.checkmark_20px, typeof(byte[]));

                    foreach (var item in pagamentoDespesa)
                    {
                        item.dp_desconto = Convert.ToDecimal(txtDesconto.Text.Replace("%", string.Empty));
                        item.dp_juros = Convert.ToDecimal(txtJuros.Text.Replace("%", string.Empty));
                        item.dp_multa = Convert.ToDecimal(txtMulta.Text.Replace("%", string.Empty));
                        item.dp_valor_lancamento = Convert.ToDecimal(txtValorTotal.Text.Replace("R$", string.Empty));
                        item.dp_imagem = imagem;
                        item.dp_pagamento_em = Convert.ToDateTime(txtData.Text);
                        item.dp_observacao = txtObservacoes.Text;
                    }

                    db.SaveChanges();

                    DesativarCampos();

                    AlertaConfirmacao.ChamandoAlertaSucessoNoCantoInferiorDireito(AlertaSalvar, this);
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Pagamento Despesa - Pagamento - Pagamento Despesa | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoAtualizarPagamentoDespesa(x);
            }
        }

        private void DesativarCampos()
        {
            btnRealizarPagamento.Enabled = false;
            txtDesconto.Enabled = false;
            txtJuros.Enabled = false;
            txtMulta.Enabled = false;
            txtValorTotal.Enabled = false;
            txtObservacoes.Enabled = false;
        }
    }
}