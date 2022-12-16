using System.Collections.Generic;

namespace SistemaDeGerenciamento2_0.Class
{
    public static class Estados
    {
        public static List<EstadoClass> listaEstados = new List<EstadoClass>();

        public class EstadoClass
        {
            public string Sigla { get; set; }
            public string NomeEstado { get; set; }
        }

        public static void PreechendoListaEstado()
        {
            listaEstados.Clear();

            listaEstados.Add(new EstadoClass { Sigla = "AC", NomeEstado = "Acre" });
            listaEstados.Add(new EstadoClass { Sigla = "AL", NomeEstado = "Alagoas" });
            listaEstados.Add(new EstadoClass { Sigla = "AP", NomeEstado = "Amapá" });
            listaEstados.Add(new EstadoClass { Sigla = "AM", NomeEstado = "Amazonas" });
            listaEstados.Add(new EstadoClass { Sigla = "BA", NomeEstado = "Bahia" });
            listaEstados.Add(new EstadoClass { Sigla = "CE", NomeEstado = "Ceará" });
            listaEstados.Add(new EstadoClass { Sigla = "DF", NomeEstado = "Distrito Federal" });
            listaEstados.Add(new EstadoClass { Sigla = "ES", NomeEstado = "Espírito Santo" });
            listaEstados.Add(new EstadoClass { Sigla = "GO", NomeEstado = "Goiás" });
            listaEstados.Add(new EstadoClass { Sigla = "MA", NomeEstado = "Maranhão" });
            listaEstados.Add(new EstadoClass { Sigla = "MT", NomeEstado = "Mato Grosso" });
            listaEstados.Add(new EstadoClass { Sigla = "MS", NomeEstado = "Mato Grosso do Sul" });
            listaEstados.Add(new EstadoClass { Sigla = "MG", NomeEstado = "Minas Gerais" });
            listaEstados.Add(new EstadoClass { Sigla = "PA", NomeEstado = "Pará" });
            listaEstados.Add(new EstadoClass { Sigla = "PB", NomeEstado = "Paraíba" });
            listaEstados.Add(new EstadoClass { Sigla = "PR", NomeEstado = "Paraná" });
            listaEstados.Add(new EstadoClass { Sigla = "PE", NomeEstado = "Pernambuco" });
            listaEstados.Add(new EstadoClass { Sigla = "PI", NomeEstado = "Piauí" });
            listaEstados.Add(new EstadoClass { Sigla = "RJ", NomeEstado = "Rio de Janeiro" });
            listaEstados.Add(new EstadoClass { Sigla = "RN", NomeEstado = "Rio Grande do Norte", });
            listaEstados.Add(new EstadoClass { Sigla = "RS", NomeEstado = "Rio Grande do Sul", });
            listaEstados.Add(new EstadoClass { Sigla = "RO", NomeEstado = "Rondônia", });
            listaEstados.Add(new EstadoClass { Sigla = "RR", NomeEstado = "Roraima", });
            listaEstados.Add(new EstadoClass { Sigla = "SC", NomeEstado = "Santa Catarina", });
            listaEstados.Add(new EstadoClass { Sigla = "SP", NomeEstado = "São Paulo", });
            listaEstados.Add(new EstadoClass { Sigla = "SE", NomeEstado = "Sergipe", });
            listaEstados.Add(new EstadoClass { Sigla = "TO", NomeEstado = "Tocantins", });
            listaEstados.Add(new EstadoClass { Sigla = "", NomeEstado = "", });
        }
    }
}