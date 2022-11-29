using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento2_0
{
    internal class LogErros
    {
        public static void EscreverArquivoDeLog(string erro)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\israe\source\repos\SistemaDeGerenciamento2_0\SistemaDeGerenciamento2_0\LogErros.txt");
            sw.WriteLine(erro);
            sw.Close();
        }
    }
}