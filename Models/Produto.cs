namespace MinimalApiCatalogo.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string? Nome { get; set; }

        public string? Decricao { get; set; }

        public decimal preco { get; set; }

        public string? ImagemUrl { get; set; }

        public DateTime DataCompra { get; set; }

        public int Estoque { get; set; }

        //relacionamento 1 pra n
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }  
    }
}
