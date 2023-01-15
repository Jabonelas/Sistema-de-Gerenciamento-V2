using DevExpress.Data.Filtering.Helpers;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
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

        private frmLogin frmLogin;

        private DataTable dt = new DataTable();

        private List<DadosProduto> listaEstoque = new List<DadosProduto>();

        public frmPDV()
        {
            InitializeComponent();

            FormatoFullScreen();

            lblStatusCaixa.Font = new Font("Segoe UI", 90, FontStyle.Bold);
            //lblNomeUsuario.Text = frmLogin.UsuarioLogado;

            //BuscarNumeroPedido();

            SetandoColunasGrid();
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
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            ChamandoAlertaSucessoNoCantoInferiorDireito();
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
                BuscarProdutoPorCodigoDeBarras();

                PreencherGrid();
            }
        }

        public class DadosProduto
        {
            public string codigoProduto = string.Empty;
            public string nomePrdouto = string.Empty;
            public decimal preco = 0;

            public DadosProduto(string _codigoProduto, string _nomePrdouto, decimal _preco)
            {
                codigoProduto = _codigoProduto;
                nomePrdouto = _nomePrdouto;
                preco = _preco;
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
                        listaEstoque.Add(new DadosProduto(dados.pd_codigo, dados.pd_nome, dados.pd_preco));

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

                foreach (var item in listaEstoque)
                {
                    dt.Rows.Add(++sequencia, item.codigoProduto, qtdProduto, item.nomePrdouto, (item.preco * qtdProduto));
                }

                lblQtdItens.Text = sequencia.ToString();

                gridControl1.DataSource = dt;
                gridControl1.Refresh();

                SetandoValoTotal();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void SetandoValoTotal()
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();

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
    }
}