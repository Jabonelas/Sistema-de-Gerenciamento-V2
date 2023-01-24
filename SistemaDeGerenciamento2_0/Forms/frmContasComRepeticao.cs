using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
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

        public frmContasComRepeticao()
        {
            InitializeComponent();

            sqlDataSource1.FillAsync();

            //txtDataInicial.Text = DateTime.Today.ToShortDateString();

            sqlDataSource3.Fill();
        }

        private void frmContasComRepeticao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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
                    Validacoes.IsDataValida(txtDataVencimento);
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
            }
            else
            {
                cmbPeriocidade.Enabled = false;
                txtObservacoesDespesaRepeticao.Enabled = false;
                cmbPeriocidade.Text = "";
                txtObservacoesDespesaRepeticao.Text = "";
            }
        }

        private int FK_Endereco = 0;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDespesaComRepeticao();
        }

        private void SalvarDespesa()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var despesa = new tb_despesa() { };
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
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
                        rp_data_final = Convert.ToDateTime(txtDataVencimento.ToString()),
                        rp_data_inicial = Convert.ToDateTime(txtDataLancamento.ToString()),
                        rp_observacao = txtObservacoesDespesaRepeticao.Text,
                        rp_periodicidade = cmbPeriocidade.Text,
                        fk_cadastro_despesa = Convert.ToInt32(cmbCategoria.Properties.GetKeyValueByDisplayValue(cmbCategoria.Text))
                    };

                    db.tb_repeticao_despesa.Add(repeticaoDespesa);
                    db.SaveChanges();

                    FK_Endereco = repeticaoDespesa.id_repeticao_despesas;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}