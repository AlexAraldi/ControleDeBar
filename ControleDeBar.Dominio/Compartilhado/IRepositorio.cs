
namespace ControleDeBar.Dominio.Compartilhado
{
    public interface IRepository<T> where T : EntidadeBase<T>
    {
        void CadastrarRegistro(T novoRegistro);
        void EditarRegistro(Guid idRegistro, T registroEditado);
        void ExcluirRegistro(Guid idRegistro);
        List<T> SelecionarRegistros();
        T? GetById(int id);
        public T SelicionarRegistroPorid(Guid idRegistro);

    }
}
