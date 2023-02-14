using System.Collections.Generic;
using System.IO;

namespace SistemaDeGerenciamento2_0
{
    internal class LogErros
    {
        public static void EscreverArquivoDeLog(string _dadoErro)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\israe\source\repos\SistemaDeGerenciamento2_0\SistemaDeGerenciamento2_0\LogErros.txt");
            sw.WriteLine(_dadoErro);
            sw.Close();
        }
    }
}