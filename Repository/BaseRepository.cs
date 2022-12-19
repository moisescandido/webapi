using Estoque.Context;
using Estoque.Repository.Interfaces;

namespace Estoque.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly ProdutoContext _context;
        public BaseRepository(ProdutoContext contexto)
        {
            _context = contexto;
        }
        public void Adicionar<T>(T entidade) where T : class
        {
            _context.Add(entidade);
            _context.SaveChanges();
        }

        public void AtualizarPreco(int id, float preco)
        {
            var produto = _context.Produtos.FirstOrDefault(x => x.Id == id);
            produto.Preco = preco;
            _context.Update(produto);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            var produto = _context.Produtos.Find(id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }
    }
}