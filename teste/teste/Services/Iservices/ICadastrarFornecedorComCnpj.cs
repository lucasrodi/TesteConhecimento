using teste.Models;

namespace teste.Services.Iservices
{
    public interface ICadastrarFornecedorComCnpj
    {
        public FornecedorComCnpj Cadastrar(string Cnpj, string NomeEmpresa, string Nome,
            DateTime DataDeCadastro, int Telefone, int Telefone2, int Telefone3, int Telefone4);
    }
}
