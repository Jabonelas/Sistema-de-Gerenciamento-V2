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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //frmCupomFiscal blankControl = new frmCupomFiscal();
            //       this.Controls.Add(blankControl);

            frmCupomFiscal frmCupomFiscal = new frmCupomFiscal();
            frmCupomFiscal.CreateDocument();

            frmCupomFiscal.Landscape = true;
            //frmCupomFiscal.ShowPreviewDialog();
            frmCupomFiscal.ExportToPdf(@"c:\Área de Trabalho");
        }
    }
}