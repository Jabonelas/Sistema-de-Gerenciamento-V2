using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Diagnostics;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
using Microsoft.Win32;
using DevExpress.Utils.MVVM;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmCadastroProduto : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private int idProduto = 0;

        private bool IsAlteracaoCadastroProduto = false;

        public frmCadastroProduto()
        {
            InitializeComponent();

            sqlGrupo.FillAsync();

            sqlFornecedor.FillAsync();
        }

        private string codigoProduto = string.Empty;

        public frmCadastroProduto(string _codigoProduto)
        {
            InitializeComponent();

            codigoProduto = _codigoProduto;

            var tarefa = Task.Run(() =>
            {
                sqlGrupo.FillAsync();

                sqlFornecedor.FillAsync();
            });

            var esperador = tarefa.GetAwaiter();
            esperador.OnCompleted(() =>
            {
                ExibirDadosproduto();
            });

            txtCodigo.Enabled = false;
            txtCodigoDeBarras.Enabled = false;

            IsAlteracaoCadastroProduto = true;
        }

        private void ExibirDadosproduto()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadosProdutoCadastrado = (from produto in db.tb_produto
                                                  join grupo in db.tb_grupo
                                                  on produto.fk_grupo equals grupo.id_grupo
                                                  join registro in db.tb_registro
                                                  on produto.fk_registro_forncedor equals registro.id_registro
                                                  where produto.pd_codigo == codigoProduto.ToString()
                                                  select new
                                                  {
                                                      Produto = produto,
                                                      Grupo = grupo,
                                                      Registro = registro
                                                  }).ToList();

                    foreach (var item in dadosProdutoCadastrado)
                    {
                        txtCodigo.Text = item.Produto.pd_codigo;
                        txtCodigoDeBarras.Text = item.Produto.pd_codigo_barras;
                        cmbFinalidade.Text = item.Produto.pd_finalidade;
                        txtNome.Text = item.Produto.pd_nome;
                        cmbGrupo.Text = item.Grupo.gp_nome_grupo;
                        if (item.Registro.rg_cnpj != string.Empty)
                        {
                            cmbFornecedor.Text = item.Registro.rg_cnpj;
                        }
                        else
                        {
                            cmbFornecedor.Text = item.Registro.rg_cpf;
                        }
                        txtTipoUnidade.Text = item.Produto.pd_tipo_unidade;
                        cmbTipoProduto.Text = item.Produto.pd_tipo_produto;
                        txtCusto.Text = item.Produto.pd_custo.ToString("C");
                        txtMargemLucro.Text = $"{item.Produto.pd_margem}%";
                        txtPreco.Text = item.Produto.pd_preco.ToString("C");
                        txtEstoqueMinimo.Text = item.Produto.pd_estoque_minimo.ToString();
                        txtObservacoes.Text = item.Produto.pd_observacoes;
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Dados Cadastro Produto - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarDadosProduto(x);
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
            frmCadastroGrupoAgrupador frmCadastroGrupoSubGrupo = new frmCadastroGrupoAgrupador(this);
            frmCadastroGrupoSubGrupo.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsAlteracaoCadastroProduto == false)
            {
                SalvarProduto();
            }
            else
            {
                AlterarProduto();
            }
        }

        private void AlterarCadastroProduto()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadosCadastroProduto = db.tb_produto.Where(x => x.pd_codigo.Equals(txtCodigo.Text));

                    foreach (var item in dadosCadastroProduto)
                    {
                        item.pd_codigo = txtCodigo.Text;
                        item.pd_codigo_barras = txtCodigoDeBarras.Text;
                        item.pd_finalidade = cmbFinalidade.Text;
                        item.pd_nome = txtNome.Text;
                        item.pd_estoque_minimo = Convert.ToDecimal(txtEstoqueMinimo.Text);
                        item.pd_custo = Convert.ToDecimal(txtCusto.Text.Replace("R$ ", string.Empty));
                        item.pd_margem = Convert.ToDecimal(txtMargemLucro.Text.Replace("%", string.Empty));
                        item.pd_preco = Convert.ToDecimal(txtPreco.Text.Replace("R$ ", string.Empty));
                        item.pd_tipo_produto = cmbTipoProduto.Text;
                        item.pd_tipo_unidade = txtTipoUnidade.Text;
                        item.pd_observacoes = txtObservacoes.Text;
                        item.fk_grupo = Convert.ToInt32(cmbGrupo.Properties.GetKeyValueByDisplayValue(cmbGrupo.Text));
                        item.fk_registro_forncedor = Convert.ToInt32(cmbFornecedor.Properties.GetKeyValueByDisplayValue(cmbFornecedor.Text));
                    }

                    db.SaveChanges();

                    ChamandoAlertaSucessoNoCantoInferiorDireito();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Alterar Dados Produto - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoAtualizarDadosProduto(x);
            }
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

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, txtNome);
        }

        private void txtCusto_Leave(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(txtCusto.Text.Replace("R$ ", ""));

            VerificarSeValoresSaoPositivos(valor, txtCusto);
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(txtPreco.Text.Replace("R$ ", ""));

            VerificarSeValoresSaoPositivos(valor, txtPreco);
        }

        private void txtEstoqueMinimo_Leave(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(txtEstoqueMinimo.Text);

            VerificarSeValoresSaoPositivos(valor, txtEstoqueMinimo);
        }

        private void txtMargemLucro_Leave(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(txtMargemLucro.Text.Replace("%", ""));

            VerificarSeValoresSaoPositivos(valor, txtMargemLucro);
        }

        private void cmbFinalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, cmbFinalidade);
        }

        private void cmbTipoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, cmbTipoProduto);
        }

        private void AlterarProduto()
        {
            if (IsNomeProdutoComMesmoFornecedorJaCadastrado() == false &&
                IsTodosTextBoxForamPreenchidos() == true)
            {
                AlterarCadastroProduto();
            }
        }

        private void SalvarProduto()
        {
            if (IsNomeProdutoComMesmoFornecedorJaCadastrado() == false &&
                IsCodigoDeprodutoJaCadastrado() == false &&
                IsCodigoDeBarrasJaCadastrado() == false &&
                IsTodosTextBoxForamPreenchidos() == true)
            {
                SalvarCadastroProduto();

                if (txtCodigoDeBarras.Text == string.Empty)
                {
                    GerarCodigoDeBarras();
                }

                LimparCampos.LimpaCampos(this.Controls);

                txtTipoUnidade.Text = "Ex.: Peça, Un, Kg";
                txtEstoqueMinimo.Text = "0";
                txtCusto.Text = "R$ 0,00";
                txtMargemLucro.Text = "0,00%";
                txtPreco.Text = "R$ 0,00";
                txtObservacoes.Text = string.Empty;
            }
        }

        private bool IsCodigoDeBarrasJaCadastrado()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var IsExisteCodigoDeBarrasProduto = db.tb_produto.Where(x => x.pd_codigo_barras.Equals(txtCodigoDeBarras.Text)).Any();

                    if (IsExisteCodigoDeBarrasProduto == true)
                    {
                        MensagemAtencao.MensagemJaExistente("Codigo de Barras");
                    }

                    return IsExisteCodigoDeBarrasProduto;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Codigo de Barras - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarCodigoDeBarrasProduto(x);

                return false;
            }
        }

        private void VerificarSeValoresSaoPositivos(decimal _valor, DevExpress.XtraEditors.TextEdit _textBox)
        {
            if (_valor < 0)
            {
                MensagemAtencao.MensagemNaoAceitoValoresNegativos();

                _textBox.BackColor = Color.LightGray;

                _textBox.Focus();
            }
            else
            {
                _textBox.BackColor = Color.FromArgb(0, 255, 255, 255);
            }
        }

        private void GerarCodigoDeBarras()
        {
            int codigoDeClassificacao = 7896202;

            int codigoEditavel = 52353;

            int codigoFixo = 8;

            string codigoDeBarras = ($"{codigoDeClassificacao}{codigoDeClassificacao + idProduto}{codigoFixo}");

            txtCodigoDeBarras.Text = codigoDeBarras;

            AtualizarCodigoDeBarras(codigoDeBarras);
        }

        private void AtualizarCodigoDeBarras(string _codigoDeBarras)
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var codigoDeBarrasProduto = db.tb_produto.FirstOrDefault(x => x.id_produto.Equals(idProduto));

                    codigoDeBarrasProduto.pd_codigo_barras = _codigoDeBarras;

                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Atualizar Codigo de Barras - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroCodigoDeBarrasProduto(x);
            }
        }

        private bool IsNomeProdutoComMesmoFornecedorJaCadastrado()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    int valor = Convert.ToInt32(cmbFornecedor.Properties.GetKeyValueByDisplayValue(cmbFornecedor.Text));

                    var IsExisteNomeProdutoEFornecedor = db.tb_produto.Where(x => x.pd_nome.Equals(txtNome.Text)).Any();

                    if (IsExisteNomeProdutoEFornecedor == true)
                    {
                        MensagemAtencao.MensagemProdutoJaExistente();
                    }

                    return IsExisteNomeProdutoEFornecedor;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Nome do Produto e Fornecedor - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarNomeDoProdutoEFornecedor(x);

                return false;
            }
        }

        private void frmCadastroProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                VerificacaoFecharTela();
            }
            else if (e.KeyCode == Keys.F10)
            {
                SalvarProduto();
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

        private bool IsTodosTextBoxForamPreenchidos()
        {
            if (txtNome.Text != string.Empty && cmbGrupo.Text != string.Empty && cmbFinalidade.Text != string.Empty &&
                cmbTipoProduto.Text != string.Empty && txtTipoUnidade.Text != "Ex.: Peça, Un, Kg")
            {
                CorFundoTextBox(Color.FromArgb(0, 255, 255, 255));

                return true;
            }
            else
            {
                CorFundoTextBox(Color.LightGray);

                MensagemAtencao.MensagemPreencherCampos();

                return false;
            }
        }

        private bool IsCodigoDeprodutoJaCadastrado()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var IsExistecodigoProduto = db.tb_produto.Where(x => x.pd_codigo.Equals(txtCodigo.Text)).Any();

                    if (IsExistecodigoProduto == true)
                    {
                        MensagemAtencao.MensagemProdutoJaExistente();
                    }
                    return IsExistecodigoProduto;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Codigo Produto - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarCodigoDeProduto(x);

                return false;
            }
        }

        private void CorFundoTextBox(Color corFundo)
        {
            txtCodigo.BackColor = corFundo;
            cmbFinalidade.BackColor = corFundo;
            txtNome.BackColor = corFundo;
            cmbGrupo.BackColor = corFundo;
            cmbFornecedor.BackColor = corFundo;
            txtTipoUnidade.BackColor = corFundo;
            cmbTipoProduto.BackColor = corFundo;
            txtCusto.BackColor = corFundo;
            txtMargemLucro.BackColor = corFundo;
            txtPreco.BackColor = corFundo;
            txtEstoqueMinimo.BackColor = corFundo;
        }

        private void SalvarCadastroProduto()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var CadastroProduto = new tb_produto()
                    {
                        pd_codigo = txtCodigo.Text,
                        pd_codigo_barras = txtCodigoDeBarras.Text,
                        pd_finalidade = cmbFinalidade.Text,
                        pd_nome = txtNome.Text,
                        pd_estoque_minimo = Convert.ToDecimal(txtEstoqueMinimo.Text),
                        pd_custo = Convert.ToDecimal(txtCusto.Text.Replace("R$ ", string.Empty)),
                        pd_margem = Convert.ToDecimal(txtMargemLucro.Text.Replace("%", string.Empty)),
                        pd_preco = Convert.ToDecimal(txtPreco.Text.Replace("R$ ", string.Empty)),
                        pd_tipo_produto = cmbTipoProduto.Text,
                        pd_tipo_unidade = txtTipoUnidade.Text,
                        pd_observacoes = txtObservacoes.Text,
                        pd_usuario_cadastrador = frmLogin.UsuarioLogado,
                        fk_grupo = Convert.ToInt32(cmbGrupo.Properties.GetKeyValueByDisplayValue(cmbGrupo.Text)),
                        fk_registro_forncedor = Convert.ToInt32(cmbFornecedor.Properties.GetKeyValueByDisplayValue(cmbFornecedor.Text)),
                    };

                    db.tb_produto.Add(CadastroProduto);
                    db.SaveChanges();

                    idProduto = CadastroProduto.id_produto;

                    ChamandoAlertaSucessoNoCantoInferiorDireito();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Produto - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroProduto(x);
            }
        }

        private void ChamandoAlertaSucessoNoCantoInferiorDireito()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n   Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $"{msg.titulo}", msg.texto, string.Empty, msg.image, msg);
        }

        private void CalcularPreco()
        {
            if (Convert.ToDecimal(txtCusto.Text.Replace("R$ ", "")) > 0)
            {
                decimal valorCusto = Convert.ToDecimal(txtCusto.Text.Replace("R$", string.Empty));

                decimal margemLucro = Convert.ToDecimal(txtMargemLucro.Text.Replace("%", string.Empty));

                decimal valorPreco = 0;

                valorPreco = (valorCusto * margemLucro / 100) + valorCusto;

                txtPreco.Text = valorPreco.ToString("C");
            }
        }

        private void CalcularMargemLucro()
        {
            if (Convert.ToDecimal(txtPreco.Text.Replace("R$ ", "")) > 0)
            {
                decimal valorCusto = Convert.ToDecimal(txtCusto.Text.Replace("R$", string.Empty));

                decimal valorPreco = Convert.ToDecimal(txtPreco.Text.Replace("R$", string.Empty)); ;

                decimal margemLucro = 0;

                if (valorCusto > 0)
                {
                    margemLucro = ((valorPreco * 100) / valorCusto) / 100;

                    txtMargemLucro.Text = (margemLucro - 1).ToString("P");
                }
            }
        }
    }
}