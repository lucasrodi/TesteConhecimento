using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace teste.Models
{
    public class FornecedorComCnpj 
    {
        public FornecedorComCnpj(string cnpj, string nomeEmpresa, string nome,
            DateTime horaDeCadastro, int telefoneId, int? telefoneId2, int? telefoneId3, int? telefoneId4)
        {
            Cnpj = cnpj;
            NomeEmpresa = nomeEmpresa;
            Nome = nome;
            HoraDeCadastro = horaDeCadastro;
            TelefoneId = telefoneId;
            TelefoneId2 = telefoneId2;
            TelefoneId3 = telefoneId3;
            TelefoneId4 = telefoneId4;
        }
        public FornecedorComCnpj()
        {

        }
        public int Id { get; set ; }
        [Required]
        [StringLength(14)]
        public string Cnpj { get ; set; }
        public string NomeEmpresa { get; set ; }
        [Required]
        public string Nome { get ; set ; }
        [Required]
        public DateTime HoraDeCadastro { get ; set ; }
        public int TelefoneId { get; set; }
        public int? TelefoneId2 { get; set; }
        public int? TelefoneId3 { get; set; }
        public int? TelefoneId4 { get; set; }

    }
}
