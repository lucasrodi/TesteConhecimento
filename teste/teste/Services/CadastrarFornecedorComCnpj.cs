using teste.Data;
using teste.Models;
using teste.Services.Iservices;

namespace teste.Services
{
    public class CadastrarFornecedorComCnpj: ICadastrarFornecedorComCnpj
    {
        ApplicationContext context = new ApplicationContext();
        public FornecedorComCnpj Cadastrar(string Cnpj, string NomeEmpresa, string Nome,
            DateTime DataDeCadastro, int Telefone, int Telefone2, int Telefone3, int Telefone4)
        {
            FornecedorComCnpj fornecedor = new FornecedorComCnpj(Cnpj, NomeEmpresa, Nome, DataDeCadastro, Telefone, Telefone2, Telefone3, Telefone4);
            context.Add(fornecedor);
            context.SaveChanges();
            return fornecedor;
        }
        
    }
}
