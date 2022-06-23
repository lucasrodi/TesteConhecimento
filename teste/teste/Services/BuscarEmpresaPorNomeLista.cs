using teste.Data;
using teste.Models;
using teste.Services.Iservices;

namespace teste.Services
{
    public class BuscarEmpresaPorNomeLista :IBuscarEmpresaPorNomeLista<List<Empresa>>
    {
        ApplicationContext context = new ApplicationContext();

        public List<Empresa> Buscar(string Nome)
        {
            var empresa = context.Empresa.Where(t=>t.Nome == Nome).ToList();

            return empresa;
        }
    }
}
