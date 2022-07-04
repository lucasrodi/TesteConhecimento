using Api.Data;
using Api.IServices;
using Api.Models;

namespace Api.Services
{
    public class GetFilmeNome: IGetFilmeNome
    { IApplicationContext context;

        public GetFilmeNome(IApplicationContext context)
        {
            this.context = context;
        }
        public GetFilmeNome()
        {

        }

        public Filme GetFilme(string nome )
        {
            return context.Filmes.Where(d=> d.Nome == nome).FirstOrDefault();
        }
    }
}
