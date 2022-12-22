using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

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

        private List<int> ListaFKNFEntrada = new List<int>();

        private List<DadosNotaFiscalEntrada> ListaDadosNFEntrada = new List<DadosNotaFiscalEntrada>();

        private List<DadosNotaFiscalEntrada> ListaCodigoProdutoEDescricaoDaNF = new List<DadosNotaFiscalEntrada>();

        private List<DadosNotaFiscalEntrada> ListaValorProdutoECoditoProdutoNF = new List<DadosNotaFiscalEntrada>();

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
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
            else if (e.KeyCode == Keys.F10)
            {
                Salvar();
            }
        }

        private void frmEntradaNF_Shown(object sender, EventArgs e)
        {
            ArquivoLocal();
        }

        private void Salvar()
        {
            if (VerificarExistenciaCadastroFornecedor() == true
                && VerificarExistenciaNF() == false
                && VerificarCNPJRecepitor() == true
                && VerificandoCodigoProdutoEDescricao() == true
                && VerificandoValorProduto() == true)
            {
                SalvarNFEntrada();

                AdicionandoFKNFEntradaNaListaDadosNFEntrada();

                SalvarEstoque();

                ChamandoAlertaSucessoNoCantoInferiorDireito();
            }
        }

        private void LimparListas()
        {
            ListaCodigoProdutoEDescricaoDaNF.Clear();
            ListaValorProdutoECoditoProdutoNF.Clear();
            ListaDadosNFEntrada.Clear();
            ListaFKNFEntrada.Clear();
        }

        private void ArquivoLocal()
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Arquivo XML (*.xml;) |*.xml;";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                LimparListas();

                localArquivo = abrirPesquisa.FileName;

                LerXMLPegarDadosEmissor();

                LerXMLPegarDadosRecepitor();

                LerXML();

                PreencherGrid();

                txtLocalArquivo.Text = localArquivo;
            }
        }

        private bool VerificandoValorProduto()
        {
            try
            {
                List<string> ListaValorProduto = new List<string>();

                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    int i = 0;

                    foreach (var item in ListaValorProdutoECoditoProdutoNF)
                    {
                        decimal valorProdutoConvertido = Convert.ToDecimal(item.valorUnitario);

                        var valorProduto = db.tb_produto.Where(x => x.pd_custo == valorProdutoConvertido && x.pd_codigo == item.codigoProduto)
                        .Select(x => x.pd_codigo_barras).ToList();

                        valorProduto.ForEach(x => ListaValorProduto.Add(x));
                        valorProduto.ForEach(x => ListaDadosNFEntrada[i].codigoBarras = x);

                        i++;
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
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Valor do Produto - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarValorDoProduto(x);

                return false;
            }
        }

        private bool VerificandoCodigoProdutoEDescricao()
        {
            try
            {
                List<string> ListaCodigoProdutoEDescricaoCadastrado = new List<string>();

                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    int i = 0;

                    foreach (var item in ListaCodigoProdutoEDescricaoDaNF)
                    {
                        var codigoProduto = db.tb_produto.Where(x => x.pd_codigo == item.codigoProduto && x.pd_nome == item.descricao)
                        .Select(x => x.id_produto).ToList();

                        codigoProduto.ForEach(x => ListaCodigoProdutoEDescricaoCadastrado.Add(x.ToString()));
                        codigoProduto.ForEach(x => ListaDadosNFEntrada[i].FKProduto = x);

                        i++;
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
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Codigo do Produto e Descrição - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarCodigoDoProdutoEDescricao(x);

                return false;
            }
        }

        private void PreencherGrid()
        {
            var item = "";
            var codigoProduto = "";
            var descricaoProduto = "";
            var tipoUnidade = "";
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
                dt.Columns.Add("Valor Unitario");
                dt.Columns.Add("Valor Total");

                while (meuXml.Read())
                {
                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "det")
                    {
                        item = meuXml.GetAttribute("nItem");

                        codigoProduto = "";
                        descricaoProduto = "";
                        tipoUnidade = "";
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

                            ListaCodigoProdutoEDescricaoDaNF.Add(new DadosNotaFiscalEntrada { codigoProduto = codigoProduto, descricao = descricaoProduto });
                        }

                        //Quantidade de Produto
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "qCom")
                        {
                            quantidadeProduto = meuXml.ReadElementString().Replace(".", ",");
                        }

                        //Tipo unidade
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "uCom")
                        {
                            tipoUnidade = meuXml.ReadElementString();
                        }
                        //Valor da Unidade
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vUnCom")
                        {
                            valorUnidade = meuXml.ReadElementString().Replace(".", ",");

                            ListaValorProdutoECoditoProdutoNF.Add(new DadosNotaFiscalEntrada
                            {
                                valorUnitario = Convert.ToDecimal(valorUnidade),
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

                            dt.Rows.Add(item,
                                codigoProduto,
                                descricaoProduto,
                                string.Format("{0000:00}", quantidadeProdutoConvertido),
                                tipoUnidade,
                                string.Format("{0:C}", valorUnidadeConvertido),
                                string.Format("{0:C}", valorProdutoConvertido));

                            ListaDadosNFEntrada.Add(new DadosNotaFiscalEntrada
                            {
                                numeroNFEntrada = Convert.ToInt32(txtNumeroNF.Text),
                                quantidade = Convert.ToDecimal(quantidadeProduto),
                                codigoProduto = codigoProduto,
                                indiceProduto = Convert.ToInt32(item),
                                cnpj = txtCNPJEmissor.Text,
                                razaoSocial = txtRazaoSocialEmitente.Text,
                                descricao = descricaoProduto,
                                unidade = tipoUnidade,
                                valorUnitario = Convert.ToDecimal(valorUnidade.Replace("R$ ", "")),
                                valorTotal = Convert.ToDecimal(txtValorTotalNF.Text.Replace("R$ ", "")),
                                dataEmissao = Convert.ToDateTime(txtDataEmissao.Text),
                                dataLancamento = DateTime.Today
                            });
                        }
                    }
                }

                gdvNotaFiscalEntrada.DataSource = dt;
                gdvNotaFiscalEntrada.Refresh();
            }
        }

        private void LerXML()
        {
            try
            {
                using (XmlReader meuXml = XmlReader.Create(localArquivo))
                {
                    var fimItens = false;

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
                    }
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

        private void ChamandoAlertaSucessoNoCantoInferiorDireito()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n   Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $"{msg.titulo}", msg.texto, string.Empty, msg.image, msg);
        }

        private void SalvarNFEntrada()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    foreach (var item in ListaDadosNFEntrada)
                    {
                        var dadosNFEntrada = new tb_nota_fiscal_entrada
                        {
                            nfe_numero_nf_entrada = item.numeroNFEntrada,
                            nfe_quantidade = item.quantidade,
                            nfe_codigo_produto = item.codigoProduto,
                            nfe_indice = item.indiceProduto,
                            nfe_cnpj = item.cnpj,
                            nfe_razao_social = item.razaoSocial,
                            nfe_descricao_social = item.descricao,
                            nfe_unidade = item.unidade,
                            nfe_valor_unitario = item.valorUnitario,
                            nfe_valor_total = item.valorTotal,
                            nfe_data_emissao = item.dataEmissao,
                            nfe_data_lancamento = item.dataLancamento,
                        };

                        db.tb_nota_fiscal_entrada.Add(dadosNFEntrada);
                        db.SaveChanges();

                        ListaFKNFEntrada.Add(dadosNFEntrada.id_nota_fiscal_entrada);
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Nota Fiscal de Entrada - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroNotaFiscalEntrada(x);
            }
        }

        private void AdicionandoFKNFEntradaNaListaDadosNFEntrada()
        {
            int i = 0;

            foreach (var item in ListaFKNFEntrada)
            {
                ListaDadosNFEntrada[i].FKNFEntrada = item;

                i++;
            }
        }

        private void SalvarEstoque()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    foreach (var item in ListaDadosNFEntrada)
                    {
                        var dadosEstoque = new tb_estoque
                        {
                            ep_quantidade = item.quantidade,
                            ep_data_entrada = item.dataLancamento,
                            ep_codigo_barras = item.codigoBarras,
                            ep_status_situacao = "L",
                            fk_produto = item.FKProduto,
                            fk_nota_fiscal_entrada = item.FKNFEntrada,
                        };

                        db.tb_estoque.Add(dadosEstoque);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Estoque - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroEstoque(x);
            }
        }

        private bool VerificarCNPJRecepitor()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    var verificarCnpjRecepitor = db.tb_registro.Where(x => x.rg_categoria == "Empresa" && x.rg_cnpj == cnpjRecepitor)
                        .Select(x => x.rg_cnpj).Any();

                    if (verificarCnpjRecepitor == false)
                    {
                        MensagemAtencao.MensagemNaoCadastrado("Destinatário");
                    }

                    return verificarCnpjRecepitor;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar CNPJ Recepitor - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarCNPJDaEmpresa(x);

                return false;
            }
        }

        private bool VerificarExistenciaNF()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    int numeroNFTextBox = Convert.ToInt32(txtNumeroNF.Text);

                    var numeroNF = db.tb_nota_fiscal_entrada.Where(x => x.nfe_cnpj == txtCNPJEmissor.Text &&
                    x.nfe_numero_nf_entrada == numeroNFTextBox).Any();

                    if (numeroNF == true)
                    {
                        MensagemAtencao.MensagemJaExistente("Nota Fiscal");
                    }

                    return numeroNF;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Existencia de Nota Fiscal de Entrada - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarNFEntradaExistente(x);

                return false;
            }
        }

        private bool VerificarExistenciaCadastroFornecedor()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    var cnpj = db.tb_registro.Where(x => x.rg_cnpj.Equals(txtCNPJEmissor.Text)).Any();

                    if (cnpj == false)
                    {
                        MensagemAtencao.MensagemNaoCadastrado("Forncedor");
                    }

                    return cnpj;
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