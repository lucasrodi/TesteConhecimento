
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace teste.Models
{
    public class FornecedorComCpf 
    {
        public FornecedorComCpf(string cpf, string rg, DateTime dataNascimento,
            string nomeEmpresa, string nome,
            DateTime horaDeCadastro, int telefoneId, int? telefoneId2, int? telefoneId3, int? telefoneId4)
        {
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            NomeEmpresa = nomeEmpresa;
            Nome = nome;
            HoraDeCadastro = horaDeCadastro;
            TelefoneId = telefoneId;
            TelefoneId2 = telefoneId2;
            TelefoneId3 = telefoneId3;
            TelefoneId4 = telefoneId4;
        }
        public FornecedorComCpf()
        {

        }
        public int Id { get ; set ; }
        public string Cpf { get ; set ; }   
        public string Rg { get ; set ; }

        public DateTime DataNascimento { get ; set ; }
        public string? NomeEmpresa { get; set ; } 
        public string Nome { get; set ; }
        public DateTime HoraDeCadastro { get; set ; }
        public int TelefoneId { get; set ; }
        public int? TelefoneId2 { get; set; }
        public int? TelefoneId3 { get; set; }
        public int? TelefoneId4 { get; set; }

    }
}
