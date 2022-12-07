using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraLayout.Filtering.Templates;
using SistemaDeGerenciamento2_0.Class;
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
    public partial class frmCadastroGrupo : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private bool isExiteGrupoComMesmoNomeEAgrupadorCadastrado = false;

        public frmCadastroGrupo()
        {
            InitializeComponent();

            PreencherComboBoxAgrupador();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeGrupo.Text != string.Empty && cmbAgrupador.Text != string.Empty)
            {
                verificarExistenciaGrupoComMesmoNomeEAgrupador();

                if (isExiteGrupoComMesmoNomeEAgrupadorCadastrado == false)
                {
                    ConexaoSalvar();

                    txtNomeGrupo.BackColor = Color.FromArgb(0, 255, 255, 255);

                    cmbAgrupador.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
                else
                {
                    MensagemAtencao.MensagemJaExistente("Grupo e Agrupador");
                }
            }
            else
            {
                txtNomeGrupo.BackColor = Color.LightGray;

                cmbAgrupador.BackColor = Color.LightGray;

                MensagemAtencao.MensagemPreencherCampos();

                txtNomeGrupo.Focus();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void frmAdicionarGrupo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmAdicionarGrupo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmAdicionarGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela();
            }
        }

        private void PreencherComboBoxAgrupador()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    List<string> listaSubGrupo = new List<string>();

                    listaSubGrupo = db.tb_grupo.Select(x => x.gp_nome_agrupador).Distinct().ToList();

                    listaSubGrupo.ForEach(x => cmbAgrupador.Properties.Items.Add(x));
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Agrupador na tela Grupo - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarAgrupadorTelaGrupo(x);
            }
        }

        private void FecharTela()
        {
            if (txtNomeGrupo.Text == string.Empty && cmbAgrupador.Text == string.Empty)
            {
                this.Close();
            }
            else
            {
                MensagemAtencao.MensagemCancelar(this);
            }
        }

        private void verificarExistenciaGrupoComMesmoNomeEAgrupador()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    var grupo = db.tb_grupo.Where(x => x.gp_nome_grupo.Equals(txtNomeGrupo.Text))
                        .Where(x => x.gp_nome_agrupador.Equals(cmbAgrupador.Text))
                        .ToList();

                    if (grupo.Count > 0)
                    {
                        isExiteGrupoComMesmoNomeEAgrupadorCadastrado = true;
                    }
                    else
                    {
                        isExiteGrupoComMesmoNomeEAgrupadorCadastrado = false;
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Grupo e Agrupador - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarGrupoEAgrupador(x);
            }
        }

        private void ConexaoSalvar()
        {
            try
            {
                var grupoProduto = new tb_grupo() { gp_nome_grupo = txtNomeGrupo.Text, gp_nome_agrupador = cmbAgrupador.Text };

                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    db.tb_grupo.Add(grupoProduto);
                    db.SaveChanges();

                    ChamandoAlertaSucessoNoCantoInferiorDireito();

                    txtNomeGrupo.Text = string.Empty;
                    cmbAgrupador.Text = string.Empty;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Grupo - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroGrupo(x);
            }
        }

        private void ChamandoAlertaSucessoNoCantoInferiorDireito()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n   Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $"{msg.titulo}", msg.texto, string.Empty, msg.image, msg);
        }

        private void cmbAgrupador_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetras(e, cmbAgrupador);
        }
    }
}