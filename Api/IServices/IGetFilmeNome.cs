using Api.Models;

namespace Api.IServices
{
    public interface IGetFilmeNome
    {
        public Filme GetFilme(string nome);
    }
}
