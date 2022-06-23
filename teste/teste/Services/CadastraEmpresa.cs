using teste.Data;
using teste.Models;
using teste.Services.Iservices;

namespace teste.Services
{
    public class CadastraEmpresa: ICadastraEmpresa
    {
        ApplicationContext context = new ApplicationContext();
        public Empresa Cadastrar( string Cnpj,string Nome , string Uf)
        {
            Empresa empresa = new Empresa(Cnpj,Nome,Uf);
            context.Add(empresa);
            context.SaveChanges();
            return empresa;
        }
    }
}
