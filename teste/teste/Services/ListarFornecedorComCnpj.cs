using teste.Data;
using teste.Models;
using teste.Services.Iservices;

namespace teste.Services
{
    public class ListarFornecedorComCnpj : IListarFornecedor<FornecedorComCnpj>
    {
        ApplicationContext context = new ApplicationContext();
        public FornecedorComCnpj Listar(string Cnpj)
        {
            var fornecedor = context.FornecedorComCnpj.Where(c => c.Cnpj == Cnpj).FirstOrDefault();
            if (fornecedor == null)
            {
                return null;

            }
            return fornecedor;
        }
    }
}
