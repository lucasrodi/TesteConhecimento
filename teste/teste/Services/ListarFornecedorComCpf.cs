using teste.Data;
using teste.Models;

namespace teste.Services.Iservices
{
    public class ListarFornecedorComCpf: IListarFornecedor<FornecedorComCpf>
    {
        ApplicationContext context = new ApplicationContext();
        public FornecedorComCpf Listar(string cpf)
        {
            var fornecedor = context.FornecedorComCpf.Where(c => c.Cpf == cpf).FirstOrDefault();
            if(fornecedor == null)
            {
                return null;
                  
            }
            return fornecedor;
        }

        
    }
}
