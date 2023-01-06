using SistemaDeGerenciamento2_0.Class;
using SistemaDeGerenciamento2_0.Context;
using SistemaDeGerenciamento2_0.Models;
using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmCadastroAgrupador : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        public frmCadastroAgrupador()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            if (txtAgrupador.Text != string.Empty)
            {
                if (IsNomeAgrupadorExiste() == false)
                {
                    ConexaoSalvar();

                    txtAgrupador.Text = string.Empty;

                    txtAgrupador.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
                else
                {
                    MensagemAtencao.MensagemJaExistente("Agrupador");
                }
            }
            else
            {
                txtAgrupador.BackColor = Color.LightGray;

                MensagemAtencao.MensagemPreencherCampos();

                txtAgrupador.Focus();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void frmAdicionarSubGrupo_KeyDown(object sender, KeyEventArgs e)
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

        private void frmAdicionarSubGrupo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmAdicionarSubGrupo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void ChamandoAlertaSucessoNoCantoInferiorDireito()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n   Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $"{msg.titulo}", msg.texto, string.Empty, msg.image, msg);
        }

        private void FecharTela()
        {
            if (txtAgrupador.Text != string.Empty)
            {
                MensagemAtencao.MensagemCancelar(this);
            }
            else
            {
                this.Close();
            }
        }

        private bool IsNomeAgrupadorExiste()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var IsExisteAgrupador = db.tb_grupo.Where(x => x.gp_nome_agrupador.Equals(txtAgrupador.Text)).Any();

                    return IsExisteAgrupador;
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Agrupador - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarAgrupador(x);

                return false;
            }
        }

        private void ConexaoSalvar()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var subGrupo = new tb_grupo() { gp_nome_agrupador = txtAgrupador.Text };
                    db.tb_grupo.Add(subGrupo);
                    db.SaveChanges();

                    ChamandoAlertaSucessoNoCantoInferiorDireito();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Agrupador - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroAgrupador(x);
            }
        }

        private void AlertaSalvar_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            e.AlertForm.OpacityLevel = 1;
        }
    }
}