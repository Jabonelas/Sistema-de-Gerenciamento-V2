using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.BarCode;
using QRCoder;
using SistemaDeGerenciamento2_0.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCodeGenerator = QRCoder.QRCodeGenerator;

namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmFormaPagamentoPix : DevExpress.XtraEditors.XtraForm
    {
        private string CNPJ = string.Empty;

        public frmFormaPagamentoPix()
        {
            InitializeComponent();
        }

        private frmLogin frmLogin;

        public frmFormaPagamentoPix(string _valor)
        {
            InitializeComponent();

            BuscarCNPJ();

            QRCodeImagem();

            lblNomeUsuario.Text = frmLogin.UsuarioLogado.ToUpper();
        }

        private void BuscarCNPJ()
        {
            try
            {
                using (SistemaDeGerenciamento2_0Context db = new SistemaDeGerenciamento2_0Context())
                {
                    var cnpj = db.tb_registro.Where(x => x.rg_tipo_cadastro == "Empresa").Select(x => x.rg_cnpj).FirstOrDefault();

                    CNPJ = cnpj;

                    lblChavePix.Text = CNPJ;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void QRCodeImagem()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(CNPJ, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pcbQRCode.Image = qrCodeImage;
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {
        }
    }
}