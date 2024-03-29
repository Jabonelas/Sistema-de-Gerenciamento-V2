﻿using DevExpress.Utils.Extensions;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraSplashScreen;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Forms;
using SistemaDeGerenciamento2_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento2_0.Class
{
    internal class PermissoesUsuario
    {
        private frmTelaPrincipal frmTelaPrincipal;

        public List<tb_permissoes> listaPermissoesUsuario = new List<tb_permissoes>();

        public void ReloadData(frmTelaPrincipal _frmTelaPrincipal, string _usuario)
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(_frmTelaPrincipal))
            {
                listaPermissoesUsuario.Clear();

                BuscarPermissoesUsuario(_usuario);

                frmTelaPrincipal = _frmTelaPrincipal;
            }
        }

        public void BuscarPermissoesUsuario(string _usuario)
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var acessosUsuario = db.tb_permissoes.Join(db.tb_registro, permissao => permissao.id_permissoes, registro => registro.fk_permissoes, (permissao, registro) => new
                    {
                        Permissao = permissao,
                        Registro = registro,
                    }).Where(x => x.Permissao.id_permissoes == x.Registro.fk_permissoes && x.Registro.rg_login == _usuario);

                    acessosUsuario.ForEach(x => listaPermissoesUsuario.Add(x.Permissao));
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Permissões Usuários | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarPermissoes(x);
            }
        }

        public void VerificarAcessoContasAtrasada(string _Cadastro, frmTelaPrincipal _frmTelaPrincipal)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_alerta_contas_atrasadas);

            if (IsUsuarioPossuiAcesso == true && _Cadastro == "Contas Atrasadas")
            {
                frmTelaPrincipal.ContasAtrasadas();
            }
        }

        public void VerificarAcessoEstoqueBaixo(string _Cadastro, frmTelaPrincipal _frmTelaPrincipal)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_alerta_estoque_baixo);

            if (IsUsuarioPossuiAcesso == true && _Cadastro == "Estoque Baixo")
            {
                frmTelaPrincipal.ProdutosComEstoqueBaixo();
            }
        }

        public void VerificarAcessoVisaoGeral(string _Cadastro, frmTelaPrincipal _frmTelaPrincipal)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_visao_geral);

            if (IsUsuarioPossuiAcesso == true && _Cadastro == "Visao Geral")
            {
                frmTelaPrincipal.TelaVisaoGeral();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(_frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoHistoricoDeVenda(string _Cadastro, frmTelaPrincipal _frmTelaPrincipal)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_historico_venda);

            if (IsUsuarioPossuiAcesso == true && _Cadastro == "Historico de Venda")
            {
                frmHistoricoVenda frmHistoricoVenda = new frmHistoricoVenda();
                frmHistoricoVenda.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(_frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoIndicadoresDeVenda(string _Cadastro, frmTelaPrincipal _frmTelaPrincipal)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_indicadores_venda);

            if (IsUsuarioPossuiAcesso == true && _Cadastro == "Indicadores de Venda")
            {
                frmIndicadorVenda frmIndicadorVenda = new frmIndicadorVenda(frmTelaPrincipal);
                frmIndicadorVenda.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(_frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoRelatorioFaturamento(string _Cadastro, frmTelaPrincipal _frmTelaPrincipal)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_visualizar_faturamento);

            if (IsUsuarioPossuiAcesso == true && _Cadastro == "Faturamento Por Dia")
            {
                frmFaturamentoPorDia frmFaturamentoPorDia = new frmFaturamentoPorDia(frmTelaPrincipal);
                frmFaturamentoPorDia.ShowDialog();
            }
            else if (IsUsuarioPossuiAcesso == true && _Cadastro == "Faturamento Por Vendedor")
            {
                frmFaturamentoPorVendedor frmFaturamentoPorVendedor = new frmFaturamentoPorVendedor(frmTelaPrincipal);
                frmFaturamentoPorVendedor.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(_frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoFinanceiroPagarContas(string _Cadastro, frmFinanceiro _frmFinanceiro)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_pagar_contas);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmPagamentoDespesa frmPagamentoDespesa = new frmPagamentoDespesa(_frmFinanceiro.idDespesa, _frmFinanceiro.parcela,
                _frmFinanceiro.nomeEmpresa, _frmFinanceiro.categoria, _frmFinanceiro.valor, _frmFinanceiro.vencimento);
                frmPagamentoDespesa.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(_frmFinanceiro, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoFinanceiroImportarXML(string _Cadastro)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_importar_xml);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmEntradaNF frm = new frmEntradaNF(frmTelaPrincipal);
                frm.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoFinanceiroCategoria(string _Cadastro)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_cadastrar_despesa);

            if (IsUsuarioPossuiAcesso == true)
            {
                AcessoTelaDespesa();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoFinanceiroDespesa(string _Cadastro)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_cadastrar_despesa);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmFinanceiro frmFinanceiro = new frmFinanceiro(frmTelaPrincipal);
                frmFinanceiro.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarCancelarVendaTelaPDV(string _Cadastro)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_cancelar_venda);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmPDV.permissaoCancelarVenda = true;
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarRemoverItemTelaPDV(string _Cadastro)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_remover_venda);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmPDV.permissaoRemoverItem = true;
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoPDV(string _Cadastro)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_acesso_pdv);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmPDV frmPDV = new frmPDV(frmTelaPrincipal);
                frmPDV.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoCadastro(string _Cadastro)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_efetuar_cadastro);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmCadastroRegistros frmCadastroRegistros = new frmCadastroRegistros(_Cadastro, frmTelaPrincipal);
                frmCadastroRegistros.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoTodosCadastros(string _Cadastro)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_visualizar_cadastro_completo);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmCadastro frmCadastro = new frmCadastro(frmTelaPrincipal);
                frmCadastro.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _Cadastro);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoCadastroProduto()
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_adicionar_produto);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmCadastroProduto frmCadastroProduto = new frmCadastroProduto();
                frmCadastroProduto.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, "Adiconar Produto");
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoTodosProdutos()
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_visualizar_todos_produtos);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmProdutos frmProdutos = new frmProdutos(frmTelaPrincipal);
                frmProdutos.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, "Todos Produtos");
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoEditarProduto(string _codigoProduto)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_editar_produto);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmCadastroProduto frmCadastroProduto = new frmCadastroProduto(_codigoProduto);
                frmCadastroProduto.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, "Editar Produto");
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoConfigUsuario(string _tela)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_criar_editar_usuario);

            if (IsUsuarioPossuiAcesso == true)
            {
                TelaConfiguracoes(_tela);
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _tela);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoConfigEmpresa(string _tela)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_configuracoes_empresa);

            if (IsUsuarioPossuiAcesso == true)
            {
                TelaConfiguracoes(_tela);
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _tela);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoConfigEmpresaTelaAcessoRapido(string _tela)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_configuracoes_empresa);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmDadosEmpresa frmDadosEmpresa = new frmDadosEmpresa(frmTelaPrincipal);
                frmDadosEmpresa.btnFechar.Visible = true;
                frmDadosEmpresa.btnSalvar.TabIndex = 0;
                frmDadosEmpresa.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _tela);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoConfigPerfil(string _tela)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_configuracoes_perfil);

            if (IsUsuarioPossuiAcesso == true)
            {
                TelaConfiguracoes(_tela);
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _tela);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoConfigFinanceira(string _tela)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_configuracoes_financeira);

            if (IsUsuarioPossuiAcesso == true)
            {
                TelaConfiguracoes(_tela);
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _tela);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoConfigFinanceiraTelaAcessoRapido(string _tela)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_configuracoes_financeira);

            if (IsUsuarioPossuiAcesso == true)
            {
                frmConfiguracaoFinanceira frmConfiguracaoFinanceira = new frmConfiguracaoFinanceira(frmTelaPrincipal);
                frmConfiguracaoFinanceira.AutoScroll = false;
                frmConfiguracaoFinanceira.btnCancelar.Visible = true;
                frmConfiguracaoFinanceira.KeyPreview = true;
                frmConfiguracaoFinanceira.btnFechar.Visible = true;
                frmConfiguracaoFinanceira.ShowDialog();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _tela);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void VerificarAcessoConfigDespesa(string _tela)
        {
            bool IsUsuarioPossuiAcesso = false;

            listaPermissoesUsuario.ForEach(x => IsUsuarioPossuiAcesso = x.pm_configuracoes_despesa);

            if (IsUsuarioPossuiAcesso == true)
            {
                AcessoTelaDespesa();
            }
            else
            {
                frmConfirmarAcesso frmConfirmarAcesso = new frmConfirmarAcesso(frmTelaPrincipal, _tela);
                frmConfirmarAcesso.ShowDialog();
            }
        }

        public void AcessoTelaDespesa()
        {
            frmTelaPrincipal.pnlTelaPrincipal.Controls.Clear();
            frmDespesas frmDespesas = new frmDespesas(frmTelaPrincipal);
            frmDespesas.TopLevel = false;
            frmTelaPrincipal.pnlTelaPrincipal.Controls.Add(frmDespesas);
            frmTelaPrincipal.pnlTelaPrincipal.Tag = frmDespesas;
            frmDespesas.Show();
        }

        public void TelaConfiguracoes(string _tela)
        {
            frmTelaPrincipal.pnlTelaPrincipal.Controls.Clear();
            frmConfiguracoes frmConfiguracoes = new frmConfiguracoes(frmTelaPrincipal, _tela);
            frmConfiguracoes.TopLevel = false;
            frmTelaPrincipal.pnlTelaPrincipal.Controls.Add(frmConfiguracoes);
            frmTelaPrincipal.pnlTelaPrincipal.Tag = frmConfiguracoes;
            frmConfiguracoes.Show();
        }
    }
}