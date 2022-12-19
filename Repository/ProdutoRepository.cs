using Estoque.Context;
using Estoque.Models.Entities;
using Estoque.Repository.Interfaces;

namespace Estoque.Repository
{
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        private readonly ProdutoContext _context;
        public ProdutoRepository(ProdutoContext contexto) : base(contexto)
        {
            _context = contexto;
        }

        public Produto GetById(int id)
        {
            return _context.Produtos.FirstOrDefault(x => x.Id == id);
        }
    }
}