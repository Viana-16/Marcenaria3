namespace API.DTO.Produto
{
    public class CreateProdutosDTO
    {
        public string Nome { get; set; }
        public int Preco { get; set; }
        public int Validade { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
