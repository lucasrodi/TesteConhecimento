using teste.Data;
using teste.Models;
using teste.Services.Iservices;

namespace teste.Services
{
    public class BuscarFornecedoresComCnpj : IBuscarFornecedores<FornecedorComCnpj>
    {
        ApplicationContext context = new ApplicationContext();
        public List<FornecedorComCnpj> BuscarFornecedor(string Cnpj)
        {
            var fornecedorComCnpj = context.FornecedorComCnpj.Where(t => t.Cnpj == Cnpj).ToList();

            return fornecedorComCnpj;
        }
    }
}
