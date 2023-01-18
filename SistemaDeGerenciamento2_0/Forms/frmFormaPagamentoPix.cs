using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.BarCode;
using QRCoder;
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
//using QRCodeGenerator = DevExpress.XtraPrinting.BarCode.QRCodeGenerator;






namespace SistemaDeGerenciamento2_0.Forms
{
    public partial class frmFormaPagamentoPix : DevExpress.XtraEditors.XtraForm
    {
        public frmFormaPagamentoPix()
        {
            InitializeComponent();
        }

        public frmFormaPagamentoPix(string _valor)
        {
            InitializeComponent();
        }

        private void QRCodeImagem()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(txtTeste.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pcbQRCode.Image = qrCodeImage;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QRCodeImagem();
        }
    }
}