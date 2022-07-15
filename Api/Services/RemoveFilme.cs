using Api.Data;
using Api.IServices;

namespace Api.Services
{
    public class RemoveFilme:IRemoveFilme
    {
        IApplicationContext context;
        IGetFilmeId getFilme;

        public RemoveFilme(IApplicationContext context, IGetFilmeId getFilme)
        {
            this.context = context;
            this.getFilme = getFilme;
        }
        public RemoveFilme()
        {

        }

        public void Remove(int id)
        {
            var filme = getFilme.Filme(id);
            context.Filmes.Remove(filme);
            context.SaveChanges();
        }
    }
}
