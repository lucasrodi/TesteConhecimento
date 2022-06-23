using teste.Models;

namespace teste.Services.Iservices
{
    public interface ICadastraEmpresa
    {
        public Empresa Cadastrar(string Cnpj, string Nome, string Uf);
    }
}
