using Api.Data;
using Api.IServices;
using Api.Models;

namespace Api.Services
{
    public class GetAllFilme : IGetAllFilme
    {
        IApplicationContext context;

        public GetAllFilme(IApplicationContext context)
        {
            this.context = context;
        }

        public List<Filme> Filmes()
        {
            return context.Filmes.ToList();
        }
    }
}
