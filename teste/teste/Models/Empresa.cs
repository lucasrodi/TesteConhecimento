using System.ComponentModel.DataAnnotations;

namespace teste.Models
{
    public class Empresa
    {
        public Empresa(string uf, string nome, string cnpj)
        {
            Uf = uf;
            Nome = nome;
            Cnpj = cnpj;
        }
        public Empresa()
        {

        }
        public int Id { get; set; }
        [Required]
        public string Uf { get; set; } 
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cnpj { get; set; }
    }
}
