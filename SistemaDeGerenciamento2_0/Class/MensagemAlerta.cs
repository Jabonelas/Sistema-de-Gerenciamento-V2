using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento2_0.Class
{
    internal class MensagemAlerta
    {
        public string titulo { get; set; }
        public string texto { get; set; }
        public Bitmap image { get; set; }
        public string descricao { get; set; }

        public MensagemAlerta(string _tituloAlerta, Bitmap _imagemAlerta)
        {
            this.titulo = _tituloAlerta;
            this.texto = $"\nClick Aqui Para Verificar!";
            this.image = _imagemAlerta;
        }
    }
}