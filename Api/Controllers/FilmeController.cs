using Api.IServices;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("Api/Filme")]
    public class FilmeController : Controller
    {
        IGetAllFilme allFilmes;
        IGetFilmeId filmeId;
        IRemoveFilme removeFilme;
        IUpdateFilme updateFilme;
        IAddFilme addFilme;
        IGetFilmeNome filmeNome;

        public FilmeController(
            IGetAllFilme allFilmes,
            IGetFilmeId filmeId,
            IRemoveFilme removeFilme,
            IUpdateFilme updateFilme,
            IAddFilme addFilme,
            IGetFilmeNome filmeNome)
        {
            this.allFilmes = allFilmes;
            this.filmeId = filmeId;
            this.removeFilme = removeFilme;
            this.updateFilme = updateFilme;
            this.addFilme = addFilme;
            this.filmeNome = filmeNome;
        }
        [HttpGet]
        [Route("AllFilmes")]
        public List<Filme> AllFilmes()
        {
           var filme = allFilmes.Filmes();
            if (filme == null)
            {
                return null;
            }
            return filme;
        }
        [HttpGet]
        [Route("FilmeId")]
        public Filme FilmeId(int id)
        {
           var filme = filmeId.Filme(id);
            if (filme == null)
            {
                return null;
            }
            return filme;
        }
        [HttpDelete]
        [Route("RemoveFilme")]
        public Filme RemoveFilme(int id)
        {
            removeFilme.Remove(id);
            var filme = filmeId.Filme(id);
            return filme;
        }
        [HttpPut]
        [Route("UpdateFilme")]
        public  Filme UpdateFilme(int id,string nome, string duracao, string genero)
        {
           updateFilme.Atualiza(id,nome,duracao,genero);
            var filme = filmeId.Filme(id);
            return filme;
        }
        [HttpPost]
        [Route("AddFilme")]
        public Filme AddFilme(string nome, string duracao, string genero)
        {
           addFilme.Add(nome, duracao, genero);
            var filme = filmeNome.GetFilme(nome);
            return filme ;
        }
    }
}
