using Api.Data;
using Api.IServices;

namespace Api.Services
{
    public class UpdateFilme: IUpdateFilme
    {
        IGetFilmeId getFilme;
        IApplicationContext context;

        public UpdateFilme(IGetFilmeId getFilme, IApplicationContext context)
        {
            this.getFilme = getFilme;
            this.context = context;
        }
        public UpdateFilme()
        {

        }
        public void Atualiza(int id,string nome , string duracao,string genero)
        {
            var filme = getFilme.Filme(id);
            filme.Nome = nome;
            filme.Duracao = duracao;
            filme.Genero = genero;
            context.Filmes.Update(filme);
        }
    }
}
