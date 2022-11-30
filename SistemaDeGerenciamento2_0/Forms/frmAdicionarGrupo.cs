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
    public partial class frmAdicionarGrupo : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        public frmAdicionarGrupo()
        {
            InitializeComponent();

            PreencherComboBoxAgrupador();
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

        private void PreencherComboBoxAgrupador()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities3 db = new SistemaDeGerenciamento2_0Entities3())
                {
                    List<string> listaSubGrupo = new List<string>();

                    listaSubGrupo = db.tb_grupo.Select(x => x.gp_nome_agrupador).Distinct().ToList();

                    listaSubGrupo.ForEach(x => cmbAgrupador.Properties.Items.Add(x));
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Agrupador - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroAgrupador(x);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdicionarGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void txtNomeGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.TeclaDigitadaFoiLetras(e, txtNomeGrupo);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeGrupo.Text != string.Empty || cmbAgrupador.Text != string.Empty)
            {
                Salvar();
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
                var grupoProduto = new tb_grupo() { gp_nome_grupo = txtNomeGrupo.Text, gp_nome_agrupador = cmbAgrupador.Text };

                using (SistemaDeGerenciamento2_0Entities3 db = new SistemaDeGerenciamento2_0Entities3())
                {
                    db.tb_grupo.Add(grupoProduto);
                    db.SaveChanges();

                    ChamandoAlertaEstoqueBaixo();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Grupo - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoCadastroGrupo(x);
            }
        }

        private void ChamandoAlertaEstoqueBaixo()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $" {msg.titulo} ", msg.texto, string.Empty, msg.image, msg);
        }
    }
}