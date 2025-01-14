namespace GeneralLabSolutions.Domain.Extensions.Helpers.Dtos.DtosConsolidados
{
    // DTO para histórico de produtos vendidos
    //public class ProdutoHistoricoDto
    //{
    //    public Guid Id { get; set; }
    //    public DateTime DataVenda { get; set; }
    //    public decimal ValorTotal { get; set; }
    //    public string Status { get; set; } = string.Empty;
    //    public int QuantidadeVendida { get; set; }
    //}

        public class ProdutoHistoricoDto
        {
            public Guid ProdutoId { get; set; }
            public string Nome { get; set; } = string.Empty;
            public int QuantidadeVendida { get; set; }
            public decimal ValorTotalVendido { get; set; }
        }


}