namespace Estoque.Models.DTOs
{
    public class ProdutoDTO
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public float Preco { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
    }
}