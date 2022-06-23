
using teste.Data;
using teste.Models;

namespace teste.Services
{
    public class CadastraTelefone
    {
        Telefone telefone = new Telefone();
        ApplicationContext context = new ApplicationContext();

        public int CadastrarTelefone(string telefoneParametro)
        {
            telefone.Telefones = telefoneParametro;
            context.Telefones.Add(telefone);
            context.SaveChanges();
            return telefone.Id;
        }
    }
}
