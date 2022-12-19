namespace Estoque.Models.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public float Preco { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
    }
}