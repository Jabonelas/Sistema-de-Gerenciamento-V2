using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento2_0.Class
{
    public class LogConexaoBanco
    {
        public static void EscreverArquivoDeLogStringConexaoBanco(string _dadosConexao)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\israe\source\repos\SistemaDeGerenciamento2_0\SistemaDeGerenciamento2_0\LogConexaoBanco.txt");
            sw.WriteLine(_dadosConexao);
            sw.Close();
        }
    }
}