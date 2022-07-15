using Api.Data;
using Api.IServices;
using Api.Models;

namespace Api.Services
{
    public class AddFilme: IAddFilme
    {
        IApplicationContext context;
        public AddFilme(IApplicationContext context)
        {
            this.context = context;
        }
        public AddFilme()
        {

        }
        public void Add(string nome,string duracao,string genero)
        {
           context.Filmes.Add(new Filme(nome, duracao, genero));
           context.SaveChanges();
        }
      
       
    }
}
