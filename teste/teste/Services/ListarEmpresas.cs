using teste.Data;
using teste.Models;
using teste.Services.Iservices;

namespace teste.Services
{
    public class ListarEmpresas: IListarEmpresas
    {
        public List<Empresa> Listar() { 
        ApplicationContext context = new ApplicationContext();
        List<Empresa> empresas = new List<Empresa>();
        empresas.Add(context.Empresa.FirstOrDefault());
            return empresas;
        }
    }
}
