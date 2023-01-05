using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class frmCadastroCategoriaDespesa : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        private int idDespesa = 0;

        public frmCadastroCategoriaDespesa()
        {
            InitializeComponent();
        }

        private frmTelaPrincipal frmTelaPrincipal;

        public frmCadastroCategoriaDespesa(int _idDespesa, frmTelaPrincipal _frmTelaPrincipal)
        {
            InitializeComponent();

            idDespesa = _idDespesa;

            frmTelaPrincipal = _frmTelaPrincipal;

            ReloadData();
        }

        private void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(frmTelaPrincipal))
            {
                PreencherCampos();
            }
        }

        private void PreencherCampos()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    var dadosDespesa = db.tb_cadastro_despesa.Where(x => x.id_categoria_despesa == idDespesa).ToList();

                    foreach (var item in dadosDespesa)
                    {
                        cmbCategoriaAgrupadora.Text = item.cd_categoria_agrupadora;
                        txtCategoria.Text = item.cd_categoria;
                        cmbCusto.Text = item.cd_tipo_custo;
                    }
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar Dados Despesa | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarDadosDespesa(x);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MensagemAtencao.MensagemCancelar(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (idDespesa != 0)
            {
                AlterarDadosDespesa();
            }
            else
            {
                Salvar();
            }
        }

        private void AlterarDadosDespesa()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    var dadosDespesa = db.tb_cadastro_despesa.Where(x => x.id_categoria_despesa.Equals(idDespesa)).ToList();

                    foreach (var item in dadosDespesa)
                    {
                        item.cd_categoria_agrupadora = cmbCategoriaAgrupadora.Text;
                        item.cd_categoria = txtCategoria.Text;
                        item.cd_tipo_custo = cmbCusto.Text;
                    }

                    db.SaveChanges();

                    ChamandoAlertaSucessoNoCantoInferiorDireito();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void Salvar()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Entities db = new SistemaDeGerenciamento2_0Entities())
                {
                    var dadosCadastroDespesa = new tb_cadastro_despesa
                    {
                        cd_categoria_agrupadora = cmbCategoriaAgrupadora.Text,
                        cd_categoria = txtCategoria.Text,
                        cd_tipo_custo = cmbCusto.Text
                    };

                    db.tb_cadastro_despesa.Add(dadosCadastroDespesa);
                    db.SaveChanges();

                    ChamandoAlertaSucessoNoCantoInferiorDireito();

                    LimpandoComponentes();
                }
            }
            catch (Exception x)
            {
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Cadastrar Despesa | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoAtualizarDespesa(x);
            }
        }

        private void LimpandoComponentes()
        {
            LimparCampos.LimpaCampos(this.Controls);
        }

        private void ChamandoAlertaSucessoNoCantoInferiorDireito()
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n   Sucesso!", Resources.salvar_verde50);
            AlertaSalvar.Show(this, $"{msg.titulo}", msg.texto, string.Empty, msg.image, msg);
        }

        private void frmCadastroCategoriaDespesa_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmCadastroCategoriaDespesa_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void txtCategoria_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitarApenasLetrasOuNumeros(e, txtCategoria);
        }
    }
}