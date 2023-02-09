using SistemaDeGerenciamento2_0.Forms;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Thread.CurrentThread.CurrentUICulture
                = CultureInfo.CreateSpecificCulture("pt-BR");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmTelaPrincipal());
            //Application.Run(new frmLogin());
            Application.Run(new frmVisaoGeral());
        }
    }
}