using teste.Models;

namespace teste.Services.Iservices
{
    public interface IBuscarEmpresaPorNomeLista<T>
    {
        public T Buscar(string Nome);
    }
}
