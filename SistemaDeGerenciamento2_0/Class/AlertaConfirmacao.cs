using SistemaDeGerenciamento2_0.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Class
{
    public static class AlertaConfirmacao
    {
        public static void ChamandoAlertaSucessoNoCantoInferiorDireito(DevExpress.XtraBars.Alerter.AlertControl _alertControl, Form _tela)
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta("\n   Sucesso!", Resources.salvar_verde50);
            _alertControl.Show(_tela, $"{msg.titulo}", msg.texto, string.Empty, msg.image, msg);
        }
    }
}