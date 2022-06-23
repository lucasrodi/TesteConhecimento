using teste.Data;
using teste.Models;
using teste.Services.Iservices;

namespace teste.Services
{
    public class CadastrarFornecedorComCpf: ICadastrarFornecedorComCpf
    {
        ApplicationContext context = new ApplicationContext();
        public FornecedorComCpf Cadastrar(string Cpf, string Rg, DateTime DataNascimento, string NomeEmpresa, string Nome,
             DateTime DataDeCadastro, int Telefone, int Telefone2, int Telefone3, int Telefone4)
        {
            FornecedorComCpf fornecedor = new FornecedorComCpf(Cpf, Rg, DataNascimento, NomeEmpresa, Nome, DataDeCadastro, Telefone, Telefone2, Telefone3, Telefone4);
            context.Add(fornecedor);
            context.SaveChanges();
            return fornecedor;
        }
       
    }
}
