using Estoque.Models.Entities;

namespace Estoque.Repository.Interfaces
{
    public interface IProdutoRepository : IBaseRepository
    {
        public void AtualizarPreco(int id, float preco);
        Produto GetById(int id);
    }
}