using System;

namespace SistemaDeGerenciamento2_0.Class
{
    public class DadosNotaFiscalEntrada
    {
        public int numeroNFEntrada { get; set; }
        public decimal quantidade { get; set; }
        public string codigoProduto { get; set; }

        public string codigoBarras { get; set; }
        public int indiceProduto { get; set; }
        public string cnpj { get; set; }
        public string razaoSocial { get; set; }
        public string descricao { get; set; }
        public string unidade { get; set; }
        public decimal valorUnitario { get; set; }
        public decimal valorTotal { get; set; }
        public DateTime dataEmissao { get; set; }
        public DateTime dataLancamento { get; set; }
        public int FKProduto { get; set; }
        public int FKNFEntrada { get; set; }
    }
}