using Estoque.Models.Entities;

namespace Estoque.Repository.Interfaces
{
    public interface IProdutoRepository : IBaseRepository
    {
        public Task<Produto> GetById(int id);
    }
}