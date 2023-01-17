using DevExpress.Data.Filtering.Helpers;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraSplashScreen;
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
    public partial class frmPDV : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        public static string passagemDeCodigoDeBarras = string.Empty;

        public static bool permissaoRemoverItem = false;

        private DataTable dt = new DataTable();

        private frmTelaPrincipal frmTelaPrincipal;

        private frmLogin frmLogin;

        private List<DadosProduto> listaEstoque = new List<DadosProduto>();

        private List<DadosProduto> listaSecundaria = new List<DadosProduto>();

        private PermissoesUsuario permissoesUsuario = new PermissoesUsuario();

        public frmPDV(frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            FormatoFullScreen();

            frmTelaPrincipal = _frmTelaPrincipal;

            ReloadData();

            lblStatusCaixa.Font = new Font("Segoe UI", 90, FontStyle.Bold);
            lblNomeUsuario.Text = frmLogin.UsuarioLogado;

            //BuscarNumeroPedido();
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                SetandoColunasGrid();

                BuscarTodosOsProdutos();
            }
        }

        private int[] PegandoIndiceDaLinhaDoGrid()
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();

            return SelectedRowHandles;
        }

        private void ApagarGrupoComDesconto()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    //int idConfiguracaoFinanceira = PegandoDadosDaLinha();

                    //var dadosConfiguracaoFinanceira = db.tb_configuracao_financeira.Where(x => x.id_configuracao_financeira == idConfiguracaoFinanceira).First();

                    //db.Entry(dadosConfiguracaoFinanceira).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

                    //db.tb_configuracao_financeira.Remove(dadosConfiguracaoFinanceira);
                    //db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Deletar Configurações Financeiras Desconto Por Grupo - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoDeletarGrupoComDesconto(x);
            }
        }

        private void BuscarTodosOsProdutos()
        {
            try
            {
                listaEstoque.Clear();

                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dados = db.tb_estoque.Join(db.tb_produto, estoque => estoque.fk_produto, produto => produto.id_produto, (estoque, produto)
                    => new
                    {
                        Estoque = estoque,
                        Produto = produto,
                    }).Where(x => x.Produto.id_produto == x.Estoque.fk_produto && x.Estoque.ep_quantidade > 0);

                    foreach (var item in dados)
                    {
                        listaEstoque.Add(new DadosProduto(item.Produto.pd_codigo, item.Produto.pd_codigo_barras, item.Produto.pd_nome, item.Produto.pd_preco, item.Estoque.ep_quantidade));
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void txtQuantidadeProduto_Leave(object sender, EventArgs e)
        {
            if (txtQuantidadeProduto.Text != string.Empty)
            {
                txtCodigoDeBarras.Focus();
            }
            else
            {
                txtQuantidadeProduto.Text = "1";
            }
        }

        private void txtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoDeBarras.Text != string.Empty)
            {
                BuscarProdutoPeloCodigoDeBarras();
            }
        }

        private void BuscarProdutoPeloCodigoDeBarras()
        {
            try
            {
                listaSecundaria.Clear();

                foreach (var item in listaEstoque)
                {
                    string codigoProduto = item.CodigoProduto;
                    string nomePrdouto = item.NomeProduto;
                    string codigoBarras = item.CodigoDeBarrasProduto;
                    decimal quantidadeProduto = item.QuantidadeProduto;
                    decimal precoProduto = item.PrecoProduto;

                    if (codigoBarras == txtCodigoDeBarras.Text)
                    {
                        if (quantidadeProduto >= Convert.ToDecimal(txtQuantidadeProduto.Text))
                        {
                            listaSecundaria.Add(new DadosProduto(codigoProduto, nomePrdouto, precoProduto));

                            quantidadeProduto -= Convert.ToDecimal(txtQuantidadeProduto.Text);

                            lblDescricaoProduto.Text = nomePrdouto;

                            lblValorUnitario.Text = precoProduto.ToString("C2");

                            PreencherGrid();

                            return;
                        }
                        else if (quantidadeProduto <= Convert.ToDecimal(txtQuantidadeProduto.Text))
                        {
                            MensagemAtencao.MensagemQuantidadeIndisponivel();

                            return;
                        }
                    }
                }

                MensagemAtencao.MensagemCampoDigitadoInvalido("Código de Barrras");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void BuscarProdutoPorCodigoDeBarras()
        {
            try
            {
                listaEstoque.Clear();

                int qdtSolicitada = Convert.ToInt32(txtQuantidadeProduto.Text);

                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dados = db.tb_estoque.Join(db.tb_produto, estoque => estoque.fk_produto, produto => produto.id_produto, (estoque, produto)
                        => new
                        {
                            Estoque = estoque,
                            Produto = produto,
                        }).Where(x => x.Produto.id_produto == x.Estoque.fk_produto && x.Estoque.ep_quantidade > qdtSolicitada && x.Produto.pd_codigo_barras == txtCodigoDeBarras.Text)
                        .Select(x => new { x.Produto.pd_codigo, x.Produto.pd_nome, x.Produto.pd_preco }).FirstOrDefault();

                    if (dados != null)
                    {
                        //listaEstoque.Add(new DadosProduto(dados.pd_codigo, dados.pd_nome, dados.pd_preco));

                        lblDescricaoProduto.Text = dados.pd_nome;

                        lblValorUnitario.Text = dados.pd_preco.ToString("C2");
                    }
                    else
                    {
                        MensagemAtencao.MensagemQuantidadeIndisponivel();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void SetandoColunasGrid()
        {
            dt.Columns.Add("SEQ.");
            dt.Columns.Add("CODIGO PRODUTO");
            dt.Columns.Add("QTD UN");
            dt.Columns.Add("DESCRICAO");
            dt.Columns.Add("VALOR TOTAL R$");
        }

        private int qtdLinhasGrid = 0;

        private void PreencherGrid()
        {
            try
            {
                int sequencia = gridView1.RowCount;

                int qtdProduto = Convert.ToInt32(txtQuantidadeProduto.Text);

                foreach (var item in listaSecundaria)
                {
                    dt.Rows.Add(++sequencia, item.codigoProduto, qtdProduto, item.nomePrdouto, (item.preco * qtdProduto));
                }

                lblQtdItens.Text = sequencia.ToString();

                gridControl1.DataSource = dt;
                gridControl1.Refresh();

                SetandoValorTotal();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public void RemoverProdutoGrid()
        {
            try
            {
                int[] indiceProdutro = PegandoIndiceDaLinhaDoGrid();

                dt.Rows.RemoveAt(indiceProdutro[0]);

                int qtdItens = gridView1.RowCount;

                lblQtdItens.Text = qtdItens.ToString();

                gridControl1.DataSource = dt;
                gridControl1.Refresh();

                SetandoValorTotal();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void SetandoValorTotal()
        {
            qtdLinhasGrid = gridView1.RowCount;

            decimal valorTotal = 0;

            for (int i = 0; i < qtdLinhasGrid; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                object cellValue = row["VALOR TOTAL R$"];

                valorTotal = valorTotal + Convert.ToDecimal(cellValue);
            }

            lblValorTotal.Text = valorTotal.ToString("C2");
            lblSubtotal.Text = valorTotal.ToString("C2");
        }

        public class DadosProduto
        {
            public string codigoProduto = string.Empty;
            public string nomePrdouto = string.Empty;
            public decimal preco = 0;

            public string CodigoProduto = string.Empty;
            public string CodigoDeBarrasProduto = string.Empty;
            public string NomeProduto = string.Empty;
            public decimal PrecoProduto = 0;
            public decimal QuantidadeProduto = 0;

            public DadosProduto(string _codigoProduto, string _nomePrdouto, decimal _preco)
            {
                codigoProduto = _codigoProduto;
                nomePrdouto = _nomePrdouto;
                preco = _preco;
            }

            public DadosProduto(string _codigoProduto, string _codigoDeBarrasProduto, string _nomeProduto, decimal _precoProduto, decimal _quantidadeProduto)
            {
                CodigoProduto = _codigoProduto;
                CodigoDeBarrasProduto = _codigoDeBarrasProduto;
                NomeProduto = _nomeProduto;
                PrecoProduto = _precoProduto;
                QuantidadeProduto = _quantidadeProduto;
            }
        }

        private void BuscarNumeroPedido()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var numeroPedido = db.tb_nota_fiscal_saida.LastOrDefault().nfs_numero_nf_saida;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void FormatoFullScreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void ChamandoAlertaSucessoNoCantoInferiorDireito()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n   Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $"{msg.titulo}", msg.texto, string.Empty, msg.image, msg);
        }

        private void txtQuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasNumero(e, txtQuantidadeProduto);
        }

        private void txtCodigoDeBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtCodigoDeBarras);
        }

        private void frmPDV_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmPDV_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmPDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F1)
            {
                txtCodigoDeBarras.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtQuantidadeProduto.Focus();
            }
            else if (e.KeyCode == Keys.F6)
            {
                RemoverItem();
            }
            else if (e.KeyCode == Keys.F2)
            {
                FinalizarVenda();
            }
        }

        private void FinalizarVenda()
        {
            PreencherListaNFSaida();

            frmPagamento frmPagamento = new frmPagamento(lblValorTotal.Text);
            frmPagamento.ShowDialog();
        }

        private void btn1FinalizarVenda_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }

        public List<tb_nota_fiscal_saida> listaNFSaida = new List<tb_nota_fiscal_saida>();

        private void PreencherListaNFSaida()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    qtdLinhasGrid = gridView1.RowCount;

                    for (int i = 0; i < qtdLinhasGrid; i++)
                    {
                        DataRow row = gridView1.GetDataRow(i);
                        object sequenciaProduto = row["SEQ."];
                        object codProduto = row["CODIGO PRODUTO"];
                        object qtdProduto = row["QTD UN"];
                        object nomeProduto = row["DESCRICAO"];
                        object valorProduto = row["VALOR TOTAL R$"];

                        listaNFSaida.Add(new tb_nota_fiscal_saida
                        {
                            nfs_numero_nf_saida = 1,
                            nfs_data_emissao = DateTime.Today,
                            nfs_quantidade = 0,
                            nfs_valor_total_parcial = 0,
                            nfs_valor_pago = 0,
                            nfs_valor_juros = 0,
                            nfs_valor_desconto = 0,
                            nfs_vendedor = "",
                            fk_estoque = 0,
                            fk_registro_cliente = 0
                        });
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnLocalizarProduto_Click(object sender, EventArgs e)
        {
            frmConsultarEstoque frmConsultarEstoque = new frmConsultarEstoque("");
            frmConsultarEstoque.ShowDialog();

            txtCodigoDeBarras.Text = passagemDeCodigoDeBarras;
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            RemoverItem();
        }

        private void RemoverItem()
        {
            permissoesUsuario.ReloadData(frmTelaPrincipal, frmLogin.UsuarioLogado);
            permissoesUsuario.VerificarRemoverItemTelaPDV("Remover Item Tela PDV");

            if (permissaoRemoverItem == true)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Realmente Deletar Remover o Produto?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    RemoverProdutoGrid();
                }
            }
        }
    }
}