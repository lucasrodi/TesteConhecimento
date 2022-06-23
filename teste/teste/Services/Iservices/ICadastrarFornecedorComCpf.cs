using teste.Models;

namespace teste.Services.Iservices
{
    public interface ICadastrarFornecedorComCpf
    {
        public FornecedorComCpf Cadastrar(string Cpf, string Rg, DateTime DataNascimento, string NomeEmpresa, string Nome,
                DateTime DataDeCadastro, int Telefone, int Telefone2, int Telefone3, int Telefone4);
    }
}
