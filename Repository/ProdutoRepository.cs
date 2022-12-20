using Estoque.Context;
using Estoque.Models.Entities;
using Estoque.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Estoque.Repository
{
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        private readonly ProdutoContext _context;
        public ProdutoRepository(ProdutoContext contexto) : base(contexto)
        {
            _context = contexto;
        }

        public async Task<Produto> GetById(int id)
        {
            return await _context.Produtos.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}