using teste.Data;
using teste.Models;
using teste.Services.Iservices;

namespace teste.Services
{
    public class BuscarEmpresaPorNome: IBuscarEmpresaPorNome
    {
        ApplicationContext context = new ApplicationContext();
        public string NomeEmpresa(string Nome)
        {
            Empresa BuscarEmpresa = context.Empresa.Where(d => d.Nome == Nome).FirstOrDefault();
            var empresa = BuscarEmpresa.Nome;
            return empresa;
        }
        
    }
}
