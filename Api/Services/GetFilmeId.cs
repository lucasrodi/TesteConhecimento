using Api.Data;
using Api.IServices;
using Api.Models;

namespace Api.Services
{
    public class GetFilmeId: IGetFilmeId
    {
        IApplicationContext context;

        public GetFilmeId(IApplicationContext context)
        {
            this.context = context;
        }
        public GetFilmeId()
        {

        }

        public  Filme Filme(int id)
        {
            var filme = context.Filmes.Where(d => d.Id == id).FirstOrDefault();
            if (filme == null)
            {
                throw new Exception("Filme Não encontrado");
            }
            return filme;
        } 
    }
}
