using DevExpress.XtraEditors;
using SistemaDeGerenciamento2_0.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static SistemaDeGerenciamento2_0.Forms.frmEntradaNF;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmEntradaNF : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;

        private int Y = 0;

        private string cnpjRecepitor = string.Empty;

        private string localArquivo = string.Empty;

        private string enderecoEmissor = string.Empty;

        private DataTable dt = new DataTable();

        public frmEntradaNF()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            ArquivoLocal();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void frmEntradaNF_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmEntradaNF_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmEntradaNF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela();
            }
        }

        private void frmEntradaNF_Shown(object sender, EventArgs e)
        {
            ArquivoLocal();
        }

        private void ArquivoLocal()
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Arquivo XML (*.xml;) |*.xml;";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                ListaCodigoProdutoEDescricaoDaNF.Clear();
                ListaValorProdutoECoditoProdutoNF.Clear();

                localArquivo = abrirPesquisa.FileName;

                LerXML();

                LerXMLPegarDadosEmissor();

                LerXMLPegarDadosRecepitor();

                txtLocalArquivo.Text = localArquivo;
            }
        }

        //private Dictionary<decimal, string> ListaValorProdutoECoditoProdutoNF = new Dictionary<decimal, string>();
        private List<ValorProdutoECoditoProdutoNF> ListaValorProdutoECoditoProdutoNF = new List<ValorProdutoECoditoProdutoNF>();

        public class ValorProdutoECoditoProdutoNF
        {
            public decimal valorProduto { get; set; }

            public string codigoProduto { get; set; }
        }

        private bool VerificandoValorProduto()
        {
            try
            {
                List<string> ListaValorProduto = new List<string>();

                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    foreach (var item in ListaValorProdutoECoditoProdutoNF)
                    {
                        decimal valorProdutoConvertido = Convert.ToDecimal(item.valorProduto);

                        var valorProduto = db.tb_produto.Where(x => x.pd_custo == valorProdutoConvertido && x.pd_codigo == item.codigoProduto)
                        .Select(x => x.pd_codigo).ToList();

                        valorProduto.ForEach(x => ListaValorProduto.Add(x));
                    }

                    if (ListaValorProdutoECoditoProdutoNF.Count == ListaValorProduto.Count)
                    {
                        return true;
                    }
                    else
                    {
                        MensagemAtencao.MensagemProdutoComValoresDivergentes();

                        return false;
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());

                return false;
            }
        }

        //private Dictionary<string, string> ListaCodigoProdutoEDescricaoDaNF = new Dictionary<string, string>();

        public class CodigoProdutoNomeProduto
        {
            public string codigoProduto { get; set; }
            public string nomeProduto { get; set; }
        }

        private List<CodigoProdutoNomeProduto> ListaCodigoProdutoEDescricaoDaNF = new List<CodigoProdutoNomeProduto>();

        private bool VerificandoCodigoProdutoEDescricao()
        {
            try
            {
                List<string> ListaCodigoProdutoEDescricaoCadastrado = new List<string>();

                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    foreach (var item in ListaCodigoProdutoEDescricaoDaNF)
                    {
                        var codigoProduto = db.tb_produto.Where(x => x.pd_codigo == item.codigoProduto && x.pd_nome == item.nomeProduto)
                        .Select(x => x.pd_codigo).ToList();

                        codigoProduto.ForEach(x => ListaCodigoProdutoEDescricaoCadastrado.Add(x));
                    }

                    if (ListaCodigoProdutoEDescricaoDaNF.Count == ListaCodigoProdutoEDescricaoCadastrado.Count)
                    {
                        return true;
                    }
                    else
                    {
                        MensagemAtencao.MensagemNaoCadastrado("Produto em Nota Fiscal");

                        return false;
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());

                return false;
            }
        }

        private void LerXML()
        {
            try
            {
                var item = "";
                var codigoProduto = "";
                var descricaoProduto = "";
                var quantidadeProduto = "";
                var valorUnidade = "";
                var valorProduto = "";

                using (XmlReader meuXml = XmlReader.Create(localArquivo))
                {
                    var fimItens = false;

                    dt.Clear();

                    dt.Rows.Clear();

                    dt.Columns.Clear();

                    gdvNotaFiscalEntrada.Refresh();
                    gridView1.RefreshData();

                    dt.Columns.Add("Item");
                    dt.Columns.Add("Código Produto");
                    dt.Columns.Add("Decrição");
                    dt.Columns.Add("Quantidade");
                    dt.Columns.Add("Unidade");
                    dt.Columns.Add("Valor");

                    while (meuXml.Read())
                    {
                        //Natureza da Operação
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "natOp")
                        {
                            txtNaturezaDaOperacao.Text = meuXml.ReadElementString();
                        }
                        //Numero da NF
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "nNF")
                        {
                            txtNumeroNF.Text = meuXml.ReadElementString();
                        }
                        //Data Emissão
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "dhEmi")
                        {
                            txtDataEmissao.Text = meuXml.ReadElementString().Replace("T", "  ");
                        }
                        //Valor Total
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vNF")
                        {
                            decimal valorTotal = Convert.ToDecimal(meuXml.ReadElementString().Replace(".", ","));

                            txtValorTotalNF.Text = string.Format("{0:C}", valorTotal);
                        }

                        //// Preencher GridView

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "det")
                        {
                            item = meuXml.GetAttribute("nItem");

                            codigoProduto = "";
                            descricaoProduto = "";
                            quantidadeProduto = "";
                            valorUnidade = "";
                            valorProduto = "";
                        }
                        else if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "total")
                        {
                            fimItens = true;
                        }

                        if (!fimItens)
                        {
                            //Codigo do Produto
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cProd")
                            {
                                codigoProduto = meuXml.ReadElementString();
                            }

                            //Descrição do Produto
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xProd")
                            {
                                descricaoProduto = meuXml.ReadElementString();

                                ListaCodigoProdutoEDescricaoDaNF.Add(new CodigoProdutoNomeProduto { codigoProduto = codigoProduto, nomeProduto = descricaoProduto });
                            }

                            //Quantidade de Produto
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "qCom")
                            {
                                quantidadeProduto = meuXml.ReadElementString().Replace(".", ",");
                            }

                            //Valor da Unidade
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vUnCom")
                            {
                                valorUnidade = meuXml.ReadElementString().Replace(".", ",");

                                ListaValorProdutoECoditoProdutoNF.Add(new ValorProdutoECoditoProdutoNF
                                {
                                    valorProduto = Convert.ToDecimal(valorUnidade),
                                    codigoProduto = codigoProduto
                                });
                            }
                            // Valor do Produto
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vProd")
                            {
                                valorProduto = meuXml.ReadElementString().Replace(".", ",");

                                decimal valorUnidadeConvertido = Convert.ToDecimal(valorUnidade);
                                decimal valorProdutoConvertido = Convert.ToDecimal(valorProduto);
                                decimal quantidadeProdutoConvertido = Convert.ToDecimal(quantidadeProduto);

                                dt.Rows.Add(item, codigoProduto, descricaoProduto, string.Format("{0000:00}", quantidadeProdutoConvertido),
                                    string.Format("{0:C}", valorUnidadeConvertido), string.Format("{0:C}", valorProdutoConvertido));
                            }
                        }
                    }

                    gdvNotaFiscalEntrada.DataSource = dt;
                    gdvNotaFiscalEntrada.Refresh();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Ler Dados Gerais da Xml - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoLerDadosGeralXml(x);
            }
        }

        private void LerXMLPegarDadosEmissor()
        {
            try
            {
                var isEmitente = false;

                using (XmlReader meuXml = XmlReader.Create(localArquivo))
                {
                    while (meuXml.Read())
                    {
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "emit")
                        {
                            isEmitente = true;
                        }
                        else if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "dest")
                        {
                            break;
                        }

                        if (isEmitente)
                        {
                            //CNPJ
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "CNPJ")
                            {
                                string CNPJ = meuXml.ReadElementString();

                                double CNPJConvertido = Convert.ToDouble(CNPJ);

                                txtCNPJEmissor.Text = string.Format(@"{0:00\.000\.000\/0000\-00}", CNPJConvertido);
                            }
                            //Nome
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xNome")
                            {
                                txtRazaoSocialEmitente.Text = meuXml.ReadElementString();
                            }
                            //Nome Fantasia
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xFant")
                            {
                                txtNomeFantasia.Text = meuXml.ReadElementString();
                            }
                            //Pais
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xPais")
                            {
                                txtPaisEmissor.Text = meuXml.ReadElementString();
                            }
                            //Telefone
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "fone")
                            {
                                string Telefone = meuXml.ReadElementString();

                                double TelefoneConvertido = Convert.ToDouble(Telefone);

                                txtTelefoneEmissor.Text = string.Format("{0:(00) 0000-0000}", TelefoneConvertido);
                            }
                            //Municipio
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xMun")
                            {
                                txtCidade.Text = meuXml.ReadElementString();
                            }
                            //Estado
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "UF")
                            {
                                txtEstado.Text = meuXml.ReadElementString();
                            }
                            //CEP
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "CEP")
                            {
                                string CEP = meuXml.ReadElementString();

                                double CEPConvertido = Convert.ToDouble(CEP);

                                txtCEPEmissor.Text = string.Format("{0:00000-000}", CEPConvertido);
                            }

                            //Endereco
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xLgr")
                            {
                                enderecoEmissor = meuXml.ReadElementString();
                            }

                            string numero = string.Empty;
                            //Numero Endereco
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "nro")
                            {
                                numero = meuXml.ReadElementString();

                                txtEnderecoEmissor.Text = $"{enderecoEmissor} Nº {numero}";
                            }
                            //Inscrição Estadual
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "IE")
                            {
                                string inscricaoEstadual = meuXml.ReadElementString();

                                double inscricaoEstadualConvertido = Convert.ToDouble(inscricaoEstadual);

                                txtInscricaoEstadualEmissor.Text = string.Format(@"{0:000,000,000,000}", inscricaoEstadualConvertido);
                            }
                            //Bairro
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xBairro")
                            {
                                txtBairroEmissor.Text = meuXml.ReadElementString();
                            }
                        }
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Ler Dados do Emissor da Xml - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoLerDadosEmissorXml(x);
            }
        }

        private void LerXMLPegarDadosRecepitor()
        {
            try
            {
                var isRecepitor = false;

                using (XmlReader meuXml = XmlReader.Create(localArquivo))
                {
                    while (meuXml.Read())
                    {
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "dest")
                        {
                            isRecepitor = true;
                        }
                        else if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "det")
                        {
                            break;
                        }

                        if (isRecepitor)
                        {
                            //CNPJ do Recepitor
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "CNPJ")
                            {
                                string CNPJ = meuXml.ReadElementString();

                                double CNPJConvertido = Convert.ToDouble(CNPJ);

                                cnpjRecepitor = string.Format(@"{0:00\.000\.000\/0000\-00}", CNPJConvertido);
                            }
                        }
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Ler Dados do Emissor da Xml - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoLerDadosEmissorXml(x);
            }
        }

        private void FecharTela()
        {
            if (txtRazaoSocialEmitente.Text != string.Empty)
            {
                MensagemAtencao.MensagemCancelar(this);
            }
            else
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool IsCnpjFornecedorCadastrado = VerificarExistenciaCadastroFornecedor();

            if (IsCnpjFornecedorCadastrado == true)
            {
                bool IsNFExistente = VerificarExistenciaNF();

                if (IsNFExistente == false)
                {
                    bool IsCnpjDaEmpresa = VerificarCNPJRecepitor();

                    if (IsCnpjDaEmpresa == true)
                    {
                        bool IsCodigoProdutoEDescricaoCadastrado = VerificandoCodigoProdutoEDescricao();

                        if (IsCodigoProdutoEDescricaoCadastrado == true)
                        {
                            bool IsValorProdutoIgualValorCadastrado = VerificandoValorProduto();

                            if (IsValorProdutoIgualValorCadastrado == true)
                            {
                                MessageBox.Show("Ate aqui esta dando td certo");
                            }
                        }
                    }
                }
            }
        }

        private bool VerificarCNPJRecepitor()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    var verificarCnpjRecepitor = db.tb_registro.Where(x => x.rg_categoria == "Empresa" && x.rg_cnpj == cnpjRecepitor)
                        .Select(x => x.rg_cnpj).ToList();

                    if (verificarCnpjRecepitor.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MensagemAtencao.MensagemNaoCadastrado("Destinatário");

                        return false;
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());

                return false;
            }
        }

        private bool VerificarExistenciaNF()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    int numeroNFTextBox = Convert.ToInt32(txtNumeroNF.Text);

                    var numeroNF = db.tb_nota_fiscal_entrada.Where(x => x.nfe_cnpj == txtCNPJEmissor.Text &&
                    x.nfe_numero_nf_entrada == numeroNFTextBox).Select(x => x.nfe_cnpj).ToList();

                    if (numeroNF.Count > 0)
                    {
                        MensagemAtencao.MensagemJaExistente("Nota Fiscal");

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());

                return false;
            }
        }

        private bool VerificarExistenciaCadastroFornecedor()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    var cnpj = db.tb_registro.Where(x => x.rg_cnpj.Equals(txtCNPJEmissor.Text)).Select(x => x.rg_cnpj).ToList();

                    if (cnpj.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MensagemAtencao.MensagemNaoCadastrado("Forncedor");

                        return false;
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar CNPJ para verificação de existencia de cadastro - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarCNPJParaVerificacaSeExisteCadastro(x);

                return false;
            }
        }
    }
}