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

        public frmPDV()
        {
            InitializeComponent();

            FormatoFullScreen();

            lblStatusCaixa.Font = new Font("Segoe UI", 90, FontStyle.Bold);
            //lblNomeUsuario.Text = frmLogin.UsuarioLogado;

            //BuscarNumeroPedido();
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
            BuscarProdutoPorCodigoDeBarras();

            PreencherGrid();
        }

        //private Dictionary<tb_estoque, tb_produto> listaEstoque = new Dictionary<tb_estoque, tb_produto>();
        //private List<tb_estoque, tb_produto> listaEstoque = new List<tb_estoque, tb_produto>();

        public class MyClass
        {
            public string codigoProduto = string.Empty;
            public string nomePrdouto = string.Empty;
            public decimal preco = 0;

            public MyClass(string _codigoProduto, string _nomePrdouto, decimal _preco)
            {
                codigoProduto = _codigoProduto;
                nomePrdouto = _nomePrdouto;
                preco = _preco;
            }
        }

        private List<MyClass> listaEstoque = new List<MyClass>();

        private void BuscarProdutoPorCodigoDeBarras()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    //listaEstoque = db.tb_estoque.Where(x => x.ep_codigo_barras == txtCodigoDeBarras.Text).ToList();
                    var dados = db.tb_estoque.Join(db.tb_produto, estoque => estoque.fk_produto, produto => produto.id_produto, (estoque, produto)
                        => new
                        {
                            Estoque = estoque,
                            Produto = produto,
                        }).Where(x => x.Produto.id_produto == x.Estoque.fk_produto && x.Estoque.ep_quantidade > 0)
                        .Select(x => new { x.Produto.pd_codigo, x.Produto.pd_nome, x.Produto.pd_preco }).First();

                    //dados.ForEach(x => listaEstoque.Add(x.Produto));

                    //listaEstoque.Add( dados.pd_codigo, dados.pd_nome, dados.pd_preco );
                    //listaEstoque.Add(new MyClass { dados.pd_codigo, dados.pd_nome, dados.pd_preco });
                    //listaEstoque.Add(new MyClass { "sas", "ss",1 });
                    //listaEstoque.Add(new MyClass { codigoProduto = dados.pd_codigo, nomePrdouto = dados.pd_nome, preco = dados.pd_preco });
                    listaEstoque.Add(new MyClass(dados.pd_codigo, dados.pd_nome, dados.pd_preco));
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void PreencherGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("SEQ.");
                dt.Columns.Add("CODIGO PRODUTO");
                dt.Columns.Add("QTD UN");
                dt.Columns.Add("DESCRICAO");
                dt.Columns.Add("VALOR TOTAL R$");

                int sequencia = 1;

                int qtdProduto = Convert.ToInt32(txtQuantidadeProduto.Text);

                foreach (var item in listaEstoque)
                {
                    //dt.Rows.Add(sequencia, item.pd_codigo, qtdProduto, item.pd_nome, (item.pd_preco * qtdProduto));

                    sequencia++;
                }

                gridControl1.DataSource = dt;
                gridControl1.Refresh();

                //using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                //{
                //}
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}