using Api.Data;
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


        public FilmeController(
            IGetAllFilme allFilmes,
            IGetFilmeId filmeId,
            IRemoveFilme removeFilme,
            IUpdateFilme updateFilme,
            IAddFilme addFilme)
        {
            this.allFilmes = allFilmes;
            this.filmeId = filmeId;
            this.removeFilme = removeFilme;
            this.updateFilme = updateFilme;
            this.addFilme = addFilme;
        }
        [HttpGet]
        [Route("AllFilmes")]
        public ActionResult<List<Filme>> AllFilmes()
        {
            try
            {
                var filme = allFilmes.Filmes();
                return Ok(filme);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("FilmeId")]
        public ActionResult<Filme> FilmeId( 
            int id)
        {
            try
            {
                var filme = filmeId.Filme(id);
                return Ok(filme);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete]
        [Route("RemoveFilme")]
        public ActionResult<Filme> RemoveFilme(
            int id )
        {
            try
            {
                removeFilme.Remove(id);
                return Ok();

            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("UpdateFilme")]
        public ActionResult<Filme> UpdateFilme(int id,
             string nome,
             string duracao, 
             string genero)
        {
            try
            {
                updateFilme.Atualiza(id, nome, duracao, genero);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                
            }
        }
        [HttpPost]
        [Route("AddFilme")]
        public ActionResult<Filme> AddFilme(
            string nome,
            string duracao,
            string genero)
        {
            try
            {
                addFilme.Add(nome, duracao, genero); 
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
          
            
        }
    }
}
