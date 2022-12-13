using System.IO;

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