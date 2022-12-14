using SistemaDeGerenciamento2_0.Forms;
using System;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTelaPrincipal());
            //Application.Run(new frmEntradaNF());
            //Application.Run(new frmNovoUsuario());
            //Application.Run(new frmCadastroUsuario());
        }
    }
}