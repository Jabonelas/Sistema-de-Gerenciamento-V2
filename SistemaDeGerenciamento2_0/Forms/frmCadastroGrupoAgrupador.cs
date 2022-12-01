using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraEditors;
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
    public partial class frmCadastroGrupoAgrupador : DevExpress.XtraEditors.XtraForm
    {
        private int X = 0;
        private int Y = 0;

        public frmCadastroGrupoAgrupador()
        {
            InitializeComponent();

            PreencherGridView();
        }

        private List<GrupoClass> ListaGrupoAgrupador = new List<GrupoClass>();

        private class GrupoClass
        {
            public string nomeGrupo { get; set; }
            public string nomeAgrupador { get; set; }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarGrupo_Click(object sender, EventArgs e)
        {
            frmCadastroGrupo frmAdicionarGrupo = new frmCadastroGrupo();
            frmAdicionarGrupo.ShowDialog();
        }

        private void btnAdicionarSubGrupo_Click(object sender, EventArgs e)
        {
            frmCadastroAgrupador frmAdicionarSubGrupo = new frmCadastroAgrupador();
            frmAdicionarSubGrupo.ShowDialog();
        }

        private void frmCadastroGrupoSubGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmCadastroGrupoSubGrupo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmCadastroGrupoSubGrupo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmCadastroGrupoAgrupador_Activated(object sender, EventArgs e)
        {
            PreencherGridView();
        }

        private void PreencherGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Grupo");
            dt.Columns.Add("Agrupador");

            SistemaDeGerenciamento2_0Entities5 db = new SistemaDeGerenciamento2_0Entities5();

            ListaGrupoAgrupador = db.tb_grupo.Where(x => !string.IsNullOrEmpty(x.gp_nome_grupo))
                .Select(x => new GrupoClass { nomeGrupo = x.gp_nome_grupo, nomeAgrupador = x.gp_nome_agrupador })
                .ToList();

            foreach (var item in ListaGrupoAgrupador)
            {
                dt.Rows.Add(item.nomeGrupo, item.nomeAgrupador);
            }

            gdvGruposAgrupadores.DataSource = dt;
            gdvGruposAgrupadores.Refresh();
        }
    }
}