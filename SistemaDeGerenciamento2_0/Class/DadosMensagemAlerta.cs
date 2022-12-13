using System.Drawing;

namespace SistemaDeGerenciamento2_0.Class
{
    internal class DadosMensagemAlerta
    {
        public string titulo { get; set; }
        public string texto { get; set; }
        public Bitmap image { get; set; }
        public string descricao { get; set; }

        public DadosMensagemAlerta(string _tituloAlerta, Bitmap _imagemAlerta)
        {
            this.titulo = _tituloAlerta;
            //this.texto = "Sucesso!!";
            this.image = _imagemAlerta;
        }
    }
}