using DevExpress.XtraEditors;
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
    public partial class frmCadastroAgrupador : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private bool isExiteAgrupadorCadastradoComMesmoNome = false;

        public frmCadastroAgrupador()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtAgrupador.Text != string.Empty)
            {
                VerificarExistenciaAgrupador();

                if (isExiteAgrupadorCadastradoComMesmoNome == false)
                {
                    Salvar();

                    txtAgrupador.Text = string.Empty;
                }
                else
                {
                    MensagemAtencao.MensagemValorJaExistente();
                }
            }
            else
            {
                MensagemAtencao.MensagemPreencherCampos();
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

        private void VerificarExistenciaAgrupador()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
                {
                    var agrupador = db.tb_grupo.Where(x => x.gp_nome_agrupador.Equals(txtAgrupador.Text))
                                .Select(x => x.gp_nome_agrupador)
                                .ToList();

                    if (agrupador.Count > 0)
                    {
                        isExiteAgrupadorCadastradoComMesmoNome = true;
                    }
                    else
                    {
                        isExiteAgrupadorCadastradoComMesmoNome = false;
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Agrupador - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarAgrupador(x);
            }
        }

        private void Salvar()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5())
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