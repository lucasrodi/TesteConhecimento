namespace Api.Models
{
    public class Filme
    {
        public Filme(string nome, string duracao, string genero)
        {
            Nome = nome;
            Duracao = duracao;
            Genero = genero;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Duracao { get; set; }
        public string Genero { get; set; }
       
    }
}
