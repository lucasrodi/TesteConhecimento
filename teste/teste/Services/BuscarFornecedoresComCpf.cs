using teste.Data;
using teste.Models;
using teste.Services.Iservices;

namespace teste.Services
{
    public class BuscarFornecedoresComCpf : IBuscarFornecedores<FornecedorComCpf>
    {
        ApplicationContext context = new ApplicationContext();

        public List<FornecedorComCpf> BuscarFornecedor(string Cpf)
        {
            var fornecedorComCpf = context.FornecedorComCpf.Where(t => t.Cpf == Cpf).ToList();
            return fornecedorComCpf;

        }


    }
}
