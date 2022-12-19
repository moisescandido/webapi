namespace Estoque.Repository.Interfaces
{
    public interface IBaseRepository
    {
        public void Adicionar<T>(T entidade) where T : class;
        public void Deletar(int id);
        public void AtualizarPreco(int id, float preco);
    }
}