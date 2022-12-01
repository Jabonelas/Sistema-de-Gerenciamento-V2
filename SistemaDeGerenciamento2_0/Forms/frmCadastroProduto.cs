using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SistemaDeGerenciamento2_0.Class;
using System.Diagnostics;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmCadastroProduto : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private List<GrupoClass> ListaIdGrupoAgrupador = new List<GrupoClass>();

        public frmCadastroProduto()
        {
            InitializeComponent();

            var tarefa = Task.Run(async () =>
            {
                await BuscarDadosParaPreencherComboBoxGrupo();
            });

            var esperador = tarefa.GetAwaiter();

            esperador.OnCompleted(() =>
            {
                PreenchimentoComboBoxGrupo();
            });
        }

        private class GrupoClass
        {
            public int idGrupo { get; set; }
            public string nomeGrupo { get; set; }
            public string nomeAgrupador { get; set; }
        }

        private async Task BuscarDadosParaPreencherComboBoxGrupo()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    ListaIdGrupoAgrupador = db.tb_grupo.Where(x => !string.IsNullOrEmpty(x.gp_nome_grupo))
                    .Select(x => new GrupoClass { idGrupo = x.id_grupo, nomeGrupo = x.gp_nome_grupo, nomeAgrupador = x.gp_nome_agrupador })
                    .ToList();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Grupo - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarGrupo(x);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            VerificacaoFecharTela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VerificacaoFecharTela();
        }

        private void btnAcessarGrupoSubGrupo_Click(object sender, EventArgs e)
        {
            frmCadastroGrupoAgrupador frmCadastroGrupoSubGrupo = new frmCadastroGrupoAgrupador();
            frmCadastroGrupoSubGrupo.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void txtCusto_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCusto.Text != string.Empty && txtCusto.Text != "R$ 0,00" && txtCusto.Text != "R$ " && txtCusto.Text != "R$" && txtCusto.Text != "R")
            {
                CalcularPreco();
            }
        }

        private void txtMargemLucro_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMargemLucro.Text != string.Empty)
            {
                CalcularPreco();
            }
            else
            {
                txtPreco.Text = txtCusto.Text;
            }
        }

        private void txtPreco_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPreco.Text != string.Empty && txtPreco.Text != "R$ 0,00" && txtPreco.Text != "R$ " && txtPreco.Text != "R$" && txtPreco.Text != "R")
            {
                CalcularMargemLucro();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtCodigo);
        }

        private void frmCadastroProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                VerificacaoFecharTela();
            }
        }

        private void frmCadastroProduto_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmCadastroProduto_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void VerificacaoFecharTela()
        {
            if (txtNome.Text != string.Empty || cmbGrupo.Text != string.Empty || cmbFinalidade.Text != string.Empty ||
                  cmbTipoProduto.Text != string.Empty)
            {
                MensagemAtencao.MensagemCancelar(this);
            }
            else
            {
                this.Close();
            }
        }

        private void PreenchimentoComboBoxGrupo()
        {
            cmbGrupo.Properties.DataSource = ListaIdGrupoAgrupador;
            cmbGrupo.Properties.DisplayMember = "nomeGrupo";
            cmbGrupo.Properties.ValueMember = "idGrupo";
        }

        private void Salvar()
        {
            if (txtNome.Text != string.Empty && cmbGrupo.Text != string.Empty && cmbFinalidade.Text != string.Empty &&
                cmbTipoProduto.Text != string.Empty && txtTipoUnidade.Text != "Ex.: Peça, Un, Kg")
            {
                ConexaoSalvar();
            }
            else
            {
                MensagemAtencao.MensagemPreencherCampos();
            }
        }

        private void ConexaoSalvar()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    var CadastroProduto = new tb_produto()
                    {
                        pd_codigo = txtCodigo.Text,
                        pd_codigo_barras = txtCodigoDeBarras.Text,
                        pd_finalidade = cmbFinalidade.Text,
                        pd_nome = txtNome.Text,
                        pd_estoque_minimo = Convert.ToDecimal(txtEstoqueMinimo.Text),
                        pd_custo = Convert.ToDecimal(txtCusto.Text.Replace("R$ ", "")),
                        pd_margem = Convert.ToDecimal(txtMargemLucro.Text.Replace("%", "")),
                        pd_preco = Convert.ToDecimal(txtPreco.Text.Replace("R$ ", "")),
                        pd_tipo_produto = cmbTipoProduto.Text,
                        pd_tipo_unidade = txtTipoUnidade.Text,
                        pd_observacoes = txtObservacoes.Text,
                        fk_grupo = Convert.ToInt32(cmbGrupo.Properties.GetKeyValueByDisplayValue(cmbGrupo.Text)),
                    };

                    db.tb_produto.Add(CadastroProduto);
                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"Erro ao Cadastrar Produto {x.ToString()}");

                MensagemErros.ErroAoCadastroProduto(x);
            }
        }

        private void CalcularPreco()
        {
            decimal valorCusto = Convert.ToDecimal(txtCusto.Text.Replace("R$", ""));

            decimal margemLucro = Convert.ToDecimal(txtMargemLucro.Text.Replace("%", ""));

            decimal valorPreco = 0;

            valorPreco = (valorCusto * margemLucro / 100) + valorCusto;

            txtPreco.Text = valorPreco.ToString("C");
        }

        private void CalcularMargemLucro()
        {
            decimal valorCusto = Convert.ToDecimal(txtCusto.Text.Replace("R$", ""));

            decimal valorPreco = Convert.ToDecimal(txtPreco.Text.Replace("R$", "")); ;

            decimal margemLucro = 0;

            margemLucro = ((valorPreco * 100) / valorCusto) / 100;

            txtMargemLucro.Text = (margemLucro - 1).ToString("P");
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, txtNome);
        }

        private void cmbFinalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, cmbFinalidade);
        }

        private void cmbTipoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, cmbTipoProduto);
        }
    }
}