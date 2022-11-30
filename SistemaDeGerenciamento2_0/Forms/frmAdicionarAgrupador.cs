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
    public partial class frmAdicionarAgrupador : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        public frmAdicionarAgrupador()
        {
            InitializeComponent();
        }

        private void ChamandoAlertaEstoqueBaixo()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $" {msg.titulo} ", msg.texto, string.Empty, msg.image, msg);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void frmAdicionarSubGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtAgrupador.Text != string.Empty)
            {
                Salvar();

                txtAgrupador.Text = "";
            }
            else
            {
                MensagemAtencao.MensagemPreencherCampos(this);
            }
        }

        private void Salvar()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities3 db = new SistemaDeGerenciamento2_0Entities3())
                {
                    var subGrupo = new tb_grupo() { gp_nome_agrupador = txtAgrupador.Text };
                    db.tb_grupo.Add(subGrupo);
                    db.SaveChanges();

                    ChamandoAlertaEstoqueBaixo();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Agrupador - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroAgrupador(x);
            }
        }

        private void txtAgrupador_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.TeclaDigitadaFoiLetras(e, txtAgrupador);
        }

        private void AlertaSalvar_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            e.AlertForm.OpacityLevel = 1;
        }
    }
}