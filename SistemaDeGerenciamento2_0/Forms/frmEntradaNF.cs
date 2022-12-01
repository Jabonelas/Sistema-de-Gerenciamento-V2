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

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmEntradaNF : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private string localArquivo = string.Empty;

        public frmEntradaNF()
        {
            InitializeComponent();
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

        private void ArquivoLocal()
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Arquivo XML (*.xml;) |*.xml;";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                localArquivo = abrirPesquisa.FileName;

                txtLocalArquivo.Text = localArquivo;
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

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Item");
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Decricao");
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
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cProd")
                            {
                                codigoProduto = meuXml.ReadElementString();
                            }

                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xProd")
                            {
                                descricaoProduto = meuXml.ReadElementString();
                            }

                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "qCom")
                            {
                                quantidadeProduto = meuXml.ReadElementString().Replace(".", ",");
                            }

                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vUnCom")
                            {
                                valorUnidade = meuXml.ReadElementString().Replace(".", ",");
                            }

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
                            //Etado
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

                            string endereco = string.Empty;
                            //Endereco
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xLgr")
                            {
                                endereco = meuXml.ReadElementString();
                            }
                            //Numero Endereco
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "nro")
                            {
                                endereco += " Nº " + meuXml.ReadElementString();

                                txtEnderecoEmissor.Text = endereco;
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

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            ArquivoLocal();

            LerXML();

            LerXMLPegarDadosEmissor();
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void frmEntradaNF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void frmEntradaNF_Shown(object sender, EventArgs e)
        {
            ArquivoLocal();

            LerXML();

            LerXMLPegarDadosEmissor();
        }
    }
}