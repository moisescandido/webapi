using Estoque.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Context
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
    }
}