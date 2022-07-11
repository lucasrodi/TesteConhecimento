using Api.Data;
using Api.IServices;

namespace Api.Services
{
    public class RemoveFilme:IRemoveFilme
    {
        IApplicationContext context;
        IGetFilmeNome getFilme;

        public RemoveFilme(IApplicationContext context, IGetFilmeNome getFilme)
        {
            this.context = context;
            this.getFilme = getFilme;
        }
        public RemoveFilme()
        {

        }

        public void Remove(string nome)
        {
            context.Filmes.Remove(getFilme.GetFilme(nome));
        }
    }
}
