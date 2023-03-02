using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.LookAndFeel;
using DevExpress.Office.Model;
using DevExpress.Utils.Extensions;
using DevExpress.Utils.VisualEffects;
using DevExpress.XtraScheduler;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraVerticalGrid.Painters;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Win32;
using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Forms;
using SistemaDeGerenciamento2_0.Models;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0
{
    public partial class frmTelaPrincipal : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private List<tb_despesa> listaDespesa = new List<tb_despesa>();

        private List<tb_repeticao_despesa> listaRepeticaoDespesa = new List<tb_repeticao_despesa>();

        private PermissoesUsuario permissoesCadastro = new PermissoesUsuario();

        private PermissoesUsuario permissoesUsuario = new PermissoesUsuario();

        public frmTelaPrincipal()
        {
            InitializeComponent();

            TelaAcessoRapido();

            lblUsuarioLogado.Text = frmLogin.UsuarioLogado;

            timer1.Start();

            BuscarDespesaContas();

            RepeticaoDeContasFixas();
        }

        private void VerificarAcessoAlertaEstoqueBaixo()
        {
            permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
            permissoesUsuario.VerificarAcessoEstoqueBaixo("Estoque Baixo", this);
        }

        private void VerificarAcessoContasAtrasadas()
        {
            permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
            permissoesUsuario.VerificarAcessoContasAtrasada("Contas Atrasadas", this);
        }

        private void TelaAcessoRapido()
        {
            pnlTelaPrincipal.Controls.Clear();
            frmAcessoRapido frmAcessoRapido = new frmAcessoRapido(this);
            frmAcessoRapido.TopLevel = false;
            pnlTelaPrincipal.Controls.Add(frmAcessoRapido);
            pnlTelaPrincipal.Tag = frmAcessoRapido;
            frmAcessoRapido.Show();
        }

        private void frmTelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MensagemAtencao.MensagemCancelar(this);
            }
        }

        private void Financeiro_Click(object sender, EventArgs e)
        {
            //ReloadData("Acesso Financeiro");

            //frmFinanceiro frmFinanceiro = new frmFinanceiro(this);
            //frmFinanceiro.ShowDialog();
        }

        private void btnAcessoRapido_Click_1(object sender, EventArgs e)
        {
            TelaAcessoRapido();
        }

        public void TelaConfiguracoes(string _tela)
        {
            pnlTelaPrincipal.Controls.Clear();
            frmConfiguracoes frmConfiguracoes = new frmConfiguracoes(this, _tela);
            frmConfiguracoes.TopLevel = false;
            pnlTelaPrincipal.Controls.Add(frmConfiguracoes);
            pnlTelaPrincipal.Tag = frmConfiguracoes;
            frmConfiguracoes.Show();
        }

        private void AcessandoTelas(string _btnSolitador)
        {
            if (_btnSolitador == "Novo Produto")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoCadastroProduto();
            }
            else if (_btnSolitador == "Cliente")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoCadastro("Cliente");
            }
            else if (_btnSolitador == "Fornecedor")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoCadastro("Fornecedor");
            }
            else if (_btnSolitador == "Funcionario")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoCadastro("Funcionario");
            }
            else if (_btnSolitador == "ConfigUsuario")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoConfigUsuario("ConfigUsuario");
            }
            else if (_btnSolitador == "ConfigEmpresa")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoConfigEmpresa("ConfigEmpresa");
            }
            else if (_btnSolitador == "ConfigFinanceiro")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoConfigFinanceira("ConfigFinanceiro");
            }
            else if (_btnSolitador == "Ir para produtos")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoTodosProdutos();
            }
            else if (_btnSolitador == "Todos Os Cadastros")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoTodosCadastros("Todos Os Cadastros");
            }
            else if (_btnSolitador == "ConfigPerfil")
            {
                permissoesUsuario.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesUsuario.VerificarAcessoConfigPerfil("ConfigPerfil");
            }
            //else if (_btnSolitador == "ConfigDespesa")
            //{
            //    permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
            //    permissoesCadastro.VerificarAcessoConfigDespesa("ConfigDespesa");
            //}
            else if (_btnSolitador == "Todos Os Produtos")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoTodosProdutos();
            }
            else if (_btnSolitador == "Acesso PDV")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoPDV("Acesso PDV");
            }
            else if (_btnSolitador == "Acesso Importar XML")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoFinanceiroImportarXML("Acesso Importar XML");
            }
            else if (_btnSolitador == "Acesso Despesa")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoFinanceiroDespesa("Acesso Despesa");
            }
            else if (_btnSolitador == "Acesso Categoria")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoFinanceiroCategoria("Acesso Categoria");
            }
            else if (_btnSolitador == "Faturamento Por Dia")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoRelatorioFaturamento("Faturamento Por Dia", this);
            }
            else if (_btnSolitador == "Faturamento Por Vendedor")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoRelatorioFaturamento("Faturamento Por Vendedor", this);
            }
            else if (_btnSolitador == "Indicadores de Venda")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoIndicadoresDeVenda("Indicadores de Venda", this);
            }
            else if (_btnSolitador == "Historico de Venda")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoHistoricoDeVenda("Historico de Venda", this);
            }
            else if (_btnSolitador == "Visao Geral")
            {
                permissoesCadastro.ReloadData(this, frmLogin.UsuarioLogado);
                permissoesCadastro.VerificarAcessoVisaoGeral("Visao Geral", this);
            }
        }

        private void btnConfigUsuario_Click(object sender, EventArgs e)
        {
            AcessandoTelas("ConfigUsuario");
        }

        private void btnConfigEmpresa_Click(object sender, EventArgs e)
        {
            AcessandoTelas("ConfigEmpresa");
        }

        private void btnConfigPerfil_Click(object sender, EventArgs e)
        {
            AcessandoTelas("ConfigPerfil");
        }

        private void btnConfigFinanceiro_Click(object sender, EventArgs e)
        {
            AcessandoTelas("ConfigFinanceiro");
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Novo Produto");
        }

        private void btnTodosOsProdutos_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Todos Os Produtos");
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Cliente");
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Fornecedor");
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Funcionario");
        }

        private void btnTodosOsCadastro_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Todos Os Cadastros");
        }

        private void btnConsultarEstoque_Click(object sender, EventArgs e)
        {
            frmConsultarEstoque frmConsultarEstoque = new frmConsultarEstoque();
            frmConsultarEstoque.ShowDialog();
        }

        private void PDV_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Acesso PDV");
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Acesso Importar XML");
        }

        private void btnDespesaContas_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Acesso Despesa");
        }

        private void btnFaturamentoPorDia_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Faturamento Por Dia");
        }

        private void btnFaturamentoPorVendedor_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Faturamento Por Vendedor");
        }

        private void btnIndicadoresVendas_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Indicadores de Venda");
        }

        private void btnHistorioDeVenda_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Historico de Venda");
        }

        private void btnDespesaAtrasada_Click(object sender, EventArgs e)
        {
            ContasAtrasadas();

            ReloadDataDespesaAtrasada();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ProdutosComEstoqueBaixo();

            ReloadDataEstoqueBaixo();
        }

        private void btnCategoriaDespesa_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Acesso Categoria");
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn == true)
            {
                UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Office2019White);
            }
            else
            {
                UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);
            }
        }

        private void Relatorios_Click(object sender, EventArgs e)
        {
            //TelaRelatorios();
        }

        private void TelaRelatorios()
        {
            pnlTelaPrincipal.Controls.Clear();
            frmRelatorios frmRelatorios = new frmRelatorios(this);
            frmRelatorios.TopLevel = false;
            pnlTelaPrincipal.Controls.Add(frmRelatorios);
            pnlTelaPrincipal.Tag = frmRelatorios;
            frmRelatorios.Show();
        }

        private void VisaoGeral_Click(object sender, EventArgs e)
        {
            AcessandoTelas("Visao Geral");
        }

        public void TelaVisaoGeral()
        {
            pnlTelaPrincipal.Controls.Clear();
            frmVisaoGeral frmVisaoGeral = new frmVisaoGeral(this);
            frmVisaoGeral.TopLevel = false;
            pnlTelaPrincipal.Controls.Add(frmVisaoGeral);
            pnlTelaPrincipal.Tag = frmVisaoGeral;
            frmVisaoGeral.Show();
        }

        public void ProdutosComEstoqueBaixo()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var teste = db.tb_estoque.Join(db.tb_produto, estoque => estoque.fk_produto, produto => produto.id_produto, (estoque, produto) => new
                    {
                        Estoque = estoque,
                        Produto = produto,
                    }).Where(x => x.Estoque.ep_quantidade <= x.Produto.pd_estoque_minimo && x.Estoque.fk_produto == x.Produto.id_produto).ToList();

                    int cont = 0;

                    foreach (var item in teste)
                    {
                        btnEstoque.Visible = true;

                        badge1.Properties.Text = (++cont).ToString();
                        badge1.Visible = true;
                    }

                    if (cont != 0)
                    {
                        ChamandoMensagemAlertaEstoqueBaixo();
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Produtos com Estoque Minimo - Tela Principal - Buscar Contas Atradas | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarProdutosComEstoqueBaixo(x);
            }
        }

        public void ContasAtrasadas()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var teste = db.tb_despesa.Where(x => x.dp_pagamento_em == null && x.dp_vencimento <= DateTime.Today).Select(x => x.dp_vencimento).ToList();

                    int cont = 0;

                    foreach (var item in teste)
                    {
                        btnDespesaAtrasada.Visible = true;

                        badge2.Properties.Text = (++cont).ToString();
                        badge2.Visible = true;
                    }

                    if (cont != 0)
                    {
                        ChamandoMensagemContaAtrasada();
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Contas Atrasadas - Tela Principal - Buscar Contas Atradas | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarContasAtrasadas(x);
            }
        }

        private void frmTelaPrincipal_Shown(object sender, EventArgs e)
        {
            VerificarAcessoAlertaEstoqueBaixo();

            VerificarAcessoContasAtrasadas();
        }

        private void ChamandoMensagemAlertaEstoqueBaixo()
        {
            MensagemAlerta msg = new MensagemAlerta("Atenção! \nExistencia de Estoque Baixo", Resources.new_product_20px);
            alertEstoqueBaixo.Show(this, msg.titulo, msg.texto, string.Empty, msg.image, msg);
        }

        private void ChamandoMensagemContaAtrasada()
        {
            MensagemAlerta msg = new MensagemAlerta("Atenção! \nExistencia Conta Atrasada", Resources.reserve_20px);
            alertContaAtrasada.Show(this, msg.titulo, msg.texto, string.Empty, msg.image, msg);
        }

        private void ReloadDataDespesaAtrasada()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(this))
            {
                frmFinanceiro frmFinanceiro = new frmFinanceiro(this);
                frmFinanceiro.ShowDialog();
            }
        }

        private void alertEstoqueBaixo_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e)
        {
            frmConsultarEstoque frmConsultarEstoque = new frmConsultarEstoque(this);
            frmConsultarEstoque.ShowDialog();
        }

        private void alertContaAtrasada_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e)
        {
            frmFinanceiro frmFinanceiro = new frmFinanceiro(this);
            frmFinanceiro.ShowDialog();
        }

        private void alertEstoqueBaixo_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            e.AlertForm.OpacityLevel = 1;
        }

        private void alertContaAtrasada_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            e.AlertForm.OpacityLevel = 1;
        }

        private void ReloadDataEstoqueBaixo()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(this))
            {
                frmConsultarEstoque frmConsultarEstoque = new frmConsultarEstoque(this);
                frmConsultarEstoque.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VerificarAcessoAlertaEstoqueBaixo();

            VerificarAcessoContasAtrasadas();
        }

        private void RepeticaoDeContasFixas()
        {
            foreach (tb_repeticao_despesa item in listaRepeticaoDespesa)
            {
                int diasPeriodicidade = ConverterPeriodicidadeParaDias(item.rp_periodicidade);

                //for (int i = 0; i <= diasPeriodicidade; i++)
                //{
                InserindoDespesaContaFixas(diasPeriodicidade, item.id_repeticao_despesas);
                //}
            }
        }

        private void InserindoDespesaContaFixas(int _diasPeriodicidade, int _id)
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    foreach (tb_despesa item in listaDespesa)
                    {
                        if (_id == item.fk_repeticao_despesa)
                        {
                            byte[] imagem;
                            ImageConverter converter = new ImageConverter();
                            imagem = (byte[])converter.ConvertTo(Resources.delete_20px, typeof(byte[]));

                            int idDespesa = item.id_despesa;
                            DateTime data = item.dp_data;
                            string observacao = item.dp_observacao;
                            decimal subValorTotal = item.dp_sub_valor_total;
                            decimal? desconto = item.dp_desconto;
                            decimal? juros = item.dp_juros;
                            decimal? multa = item.dp_multa;
                            decimal? valorLancamento = item.dp_valor_lancamento;
                            DateTime? pagamento = item.dp_pagamento_em;
                            DateTime? vencimento = item.dp_vencimento;
                            vencimento = vencimento?.AddDays(_diasPeriodicidade);
                            int? parcelas = item.dp_parcelas;
                            bool? repeticao = item.dp_repeticao;
                            int fkRegistro = item.fk_registro;
                            int? fkRepeticao = item.fk_repeticao_despesa;

                            var despesa = new tb_despesa()
                            {
                                dp_data = data,
                                dp_observacao = observacao,
                                dp_sub_valor_total = subValorTotal,
                                dp_vencimento = vencimento,
                                dp_parcelas = parcelas,
                                dp_imagem = imagem,
                                dp_repeticao = false,
                                fk_registro = fkRegistro,
                                fk_repeticao_despesa = fkRepeticao,
                            };

                            db.tb_despesa.Add(despesa);

                            db.SaveChanges();

                            AtualizandoDespesasContasFixas(idDespesa);

                            break;
                        }
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Despesa/Contas que Possuem Tipo de Custo Fixo (Repetição) - Tela Principal - Despesas/Contas Com Repetição | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroDespesaContasFixas(x);
            }
        }

        private void AtualizandoDespesasContasFixas(int _idDespesa)
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var atualizandoDespesa = db.tb_despesa.Where(x => x.id_despesa == _idDespesa);

                    foreach (var item in atualizandoDespesa)
                    {
                        item.dp_repeticao = true;
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Atualizar Despesa/Contas que Possuem Tipo de Custo Fixo (Repetição) - Tela Principal - Despesas/Contas Com Repetição | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoAtualizarDespesaContasFixas(x);
            }
        }

        private int ConverterPeriodicidadeParaDias(string _periodicidade)
        {
            switch (_periodicidade)
            {
                case "Diário":

                    return 1;

                case "Semanal":

                    return 7;

                case "Mensal":

                    return 30;

                case "Anual":

                    return 365;
            }

            return 0;
        }

        private void BuscarDespesaContas()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var dadosDeletarCadastro = (from despesa in db.tb_despesa
                                                join repeticao in db.tb_repeticao_despesa
                                                on despesa.fk_repeticao_despesa equals repeticao.id_repeticao_despesas
                                                join cadastro in db.tb_cadastro_despesa
                                                on repeticao.fk_cadastro_despesa equals cadastro.id_categoria_despesa
                                                where despesa.dp_repeticao == false && cadastro.cd_tipo_custo == "Fixo"
                                                && despesa.dp_vencimento <= DateTime.Today
                                                select new
                                                {
                                                    Despesa = despesa,
                                                    Repeticao = repeticao,
                                                    Cadastro = cadastro
                                                }).ToList();

                    foreach (var item in dadosDeletarCadastro)
                    {
                        int idDespesa = item.Despesa.id_despesa;
                        DateTime data = item.Despesa.dp_data;
                        string observacao = item.Despesa.dp_observacao;
                        decimal subValorTotal = item.Despesa.dp_sub_valor_total;
                        decimal? desconto = item.Despesa.dp_desconto;
                        decimal? juros = item.Despesa.dp_juros;
                        decimal? multa = item.Despesa.dp_multa;
                        decimal? valorLancamento = item.Despesa.dp_valor_lancamento;
                        DateTime? pagamento = item.Despesa.dp_pagamento_em;
                        DateTime? vencimento = item.Despesa.dp_vencimento;
                        int? parcelas = item.Despesa.dp_parcelas;
                        byte[] imagem = item.Despesa.dp_imagem;
                        bool? repeticao = item.Despesa.dp_repeticao;
                        int fkRegistro = item.Despesa.fk_registro;
                        int? fkRepeticao = item.Despesa.fk_repeticao_despesa;

                        listaDespesa.Add(new tb_despesa
                        {
                            id_despesa = idDespesa,
                            dp_data = data,
                            dp_observacao = observacao,
                            dp_sub_valor_total = subValorTotal,
                            dp_desconto = desconto,
                            dp_juros = juros,
                            dp_multa = multa,
                            dp_valor_lancamento = valorLancamento,
                            dp_pagamento_em = pagamento,
                            dp_vencimento = vencimento,
                            dp_parcelas = parcelas,
                            dp_imagem = imagem,
                            dp_repeticao = repeticao,
                            fk_registro = fkRegistro,
                            fk_repeticao_despesa = fkRepeticao,
                        });

                        int idRepeticao = item.Repeticao.id_repeticao_despesas;
                        string periodicidade = item.Repeticao.rp_periodicidade;

                        listaRepeticaoDespesa.Add(new tb_repeticao_despesa
                        {
                            id_repeticao_despesas = idRepeticao,
                            rp_periodicidade = periodicidade
                        });
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Despesas/Contas Com Repetição - Tela Principal - Despesas/Contas Com Repetição | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarDespesaContasComRepeticaoAtrasadas(x);
            }
        }
    }
}