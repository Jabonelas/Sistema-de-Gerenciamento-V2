using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
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
    public partial class frmContasComRepeticao : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;
        private int FK_Repeticao = 0;

        public frmContasComRepeticao()
        {
            InitializeComponent();

            sqlDataSource1.FillAsync();

            txtDataLancamento.Text = DateTime.Today.ToShortDateString();

            sqlDataSource3.Fill();
        }

        private void frmContasComRepeticao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MensagemAtencao.MensagemCancelar(this);
            }
            else if (e.KeyCode == Keys.F10)
            {
                Salvar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(this);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoDinheiro(e, sender, txtValor);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmContasComRepeticao_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmContasComRepeticao_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void txtDataLancamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoData(e, txtDataLancamento);
        }

        private void txtDataVencimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoData(e, txtDataVencimento);
        }

        private void txtDataVencimento_Leave(object sender, EventArgs e)
        {
            if (txtDataVencimento.Text != string.Empty)
            {
                if (Validacoes.IsCampoPreenchido(txtDataVencimento) == true)
                {
                    if (Validacoes.IsDataValida(txtDataVencimento) == true)
                    {
                        if (Convert.ToDateTime(txtDataVencimento.Text) < Convert.ToDateTime(txtDataLancamento.Text))
                        {
                            MensagemAtencao.MensagemDataVencimentoMaiorQueLancamento();
                            txtDataVencimento.Focus();
                        }
                    }
                }
            }
        }

        private void txtDataLancamento_Leave(object sender, EventArgs e)
        {
            if (txtDataLancamento.Text != string.Empty)
            {
                if (Validacoes.IsCampoPreenchido(txtDataLancamento) == true)
                {
                    Validacoes.IsDataValida(txtDataLancamento);
                }
            }
        }

        private void chkRepetirDespesa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRepetirDespesa.Checked == true)
            {
                cmbPeriocidade.Enabled = true;
                txtObservacoesDespesaRepeticao.Enabled = true;
                cmbPrazo.Enabled = true;
                cmbPrazo.SelectedIndex = 0;
            }
            else
            {
                cmbPeriocidade.Enabled = false;
                txtObservacoesDespesaRepeticao.Enabled = false;
                cmbPrazo.Enabled = false;
                cmbPeriocidade.Text = string.Empty;
                txtObservacoesDespesaRepeticao.Text = string.Empty;
                cmbPrazo.Text = string.Empty;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            if (cmbPrazo.Text != string.Empty && cmbPeriocidade.Text == string.Empty)
            {
                MensagemAtencao.MensagemPreenchimentoCampoPeriocidade();
                cmbPeriocidade.Focus();
            }
            else
            {
                if (txtDataLancamento.Text != string.Empty && txtDataVencimento.Text != string.Empty && txtValor.Text != string.Empty
                    && cmbFornecedor.Text != string.Empty && cmbCategoria.Text != string.Empty)
                {
                    SalvarDespesaComRepeticao();

                    SalvarDespesa();

                    LimpandoCampos();
                }
                else
                {
                    MensagemAtencao.MensagemPreencherCampos();
                }
            }
        }

        private void LimpandoCampos()
        {
            txtDataVencimento.Text = string.Empty;
            txtValor.Text = "R$ 0,00";
            cmbFornecedor.Text = string.Empty;
            cmbCategoria.Text = string.Empty;
            txtObservacoesDespesa.Text = string.Empty;

            chkRepetirDespesa.Checked = false;
            cmbPeriocidade.Text = string.Empty;
            txtObservacoesDespesaRepeticao.Text = string.Empty;
        }

        private void SalvarDespesa()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    int quantidadeParcelas = Convert.ToInt32(cmbPrazo.Text.Replace("x", string.Empty));

                    for (int cont = 1; cont <= quantidadeParcelas; cont++)
                    {
                        byte[] imagem;
                        ImageConverter converter = new ImageConverter();
                        imagem = (byte[])converter.ConvertTo(Resources.delete_20px, typeof(byte[]));

                        var despesa = new tb_despesa()
                        {
                            dp_data = Convert.ToDateTime(txtDataLancamento.Text),
                            dp_observacao = txtObservacoesDespesa.Text,
                            dp_sub_valor_total = Convert.ToDecimal(txtValor.Text.Replace("R$", string.Empty)),
                            dp_vencimento = Convert.ToDateTime(txtDataVencimento.Text),
                            dp_parcelas = cont,
                            dp_imagem = imagem,
                            fk_registro = Convert.ToInt32(cmbFornecedor.Properties.GetKeyValueByDisplayValue(cmbFornecedor.Text)),
                            fk_repeticao_despesa = FK_Repeticao
                        };

                        db.tb_despesa.Add(despesa);
                        db.SaveChanges();
                    }

                    AlertaConfirmacao.ChamandoAlertaSucessoNoCantoInferiorDireito(AlertaSalvar, this);
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Despesas - Despesa - Contas Com Repetição | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroDespesas(x);
            }
        }

        private void SalvarDespesaComRepeticao()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var repeticaoDespesa = new tb_repeticao_despesa()
                    {
                        rp_data_final = Convert.ToDateTime(txtDataVencimento.Text.ToString()),
                        rp_data_inicial = Convert.ToDateTime(txtDataLancamento.Text.ToString()),
                        rp_observacao = txtObservacoesDespesaRepeticao.Text,
                        rp_periodicidade = cmbPeriocidade.Text,
                        fk_cadastro_despesa = Convert.ToInt32(cmbCategoria.Properties.GetKeyValueByDisplayValue(cmbCategoria.Text))
                    };

                    db.tb_repeticao_despesa.Add(repeticaoDespesa);
                    db.SaveChanges();

                    FK_Repeticao = repeticaoDespesa.id_repeticao_despesas;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Despesas Repetição - Despesa - Contas Com Repetição | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroDespesasRepeticao(x);
            }
        }
    }
}