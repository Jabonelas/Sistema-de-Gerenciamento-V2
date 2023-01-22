using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.BarCode;
using QRCoder;
using SistemaDeGerenciamento2_0.Class;
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

        private decimal valorPagoNoProduto = 0;
        private decimal valorJuros = 0;
        private decimal valorFinalPago = 0;

        private string numeroNF;

        private frmLogin frmLogin;

        private frmPagamento frmPagamento;

        private frmTelaPrincipal frmTelaPrincipal;

        private PermissoesUsuario permissoesUsuario = new PermissoesUsuario();

        public frmFormaPagamentoPix(string _valorFinalPago, string _numeroNF, decimal _valorPagoNoProduto,
            decimal _valorJuros, frmTelaPrincipal _frmTelaPrincipal, frmPagamento _frmPagamento)
        {
            InitializeComponent();

            lblValorTotal.Text = _valorFinalPago;

            numeroNF = _numeroNF;

            valorPagoNoProduto = _valorPagoNoProduto;

            valorJuros = _valorJuros;

            frmTelaPrincipal = _frmTelaPrincipal;

            frmPagamento = _frmPagamento;

            valorFinalPago = Convert.ToDecimal(_valorFinalPago.Replace("R$", ""));

            lblValorTotal.Text = _valorFinalPago;

            lblNomeUsuario.Text = frmLogin.UsuarioLogado.ToUpper();

            BuscarCNPJ();

            QRCodeImagem();
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
                LogErros.EscreverArquivoDeLog($"{DateTime.Now} - Erro ao Buscar CNPJ da empresa na tela de pagamento Pix - | {x.Message} | {x.StackTrace}");

                MensagemErros.ErroAoBuscarCNPJDaEmpresaTelaPagamentoPix(x);
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

        private void btn1FinalizarVenda_Click(object sender, EventArgs e)
        {
            NFSaida.NotaFiscalSaida(numeroNF, valorPagoNoProduto, valorJuros, valorFinalPago, "Pix");

            AlterarEstoque.AlterandoEstoque();

            btn1CancelarVenda.Enabled = false;
            btn1FinalizarVenda.Enabled = false;
        }
    }
}