using teste.Services.Iservices;

namespace teste.Services
{
    public class CadastrarVarioTelefones: ICadastrarVarioTelefones
    {
        public int[] Cadastrar(string Telefone, string Telefone2, string Telefone3, string Telefone4)
        {
            CadastraTelefone telefone = new CadastraTelefone();
            var telefone1 = telefone.CadastrarTelefone(Telefone);
            CadastraTelefone telefoneC2 = new CadastraTelefone();
            var telefone2 = telefoneC2.CadastrarTelefone(Telefone2);
            CadastraTelefone telefoneC3 = new CadastraTelefone();
            var telefone3 = telefoneC3.CadastrarTelefone(Telefone3);
            CadastraTelefone telefoneC4 = new CadastraTelefone();
            var telefone4 = telefoneC4.CadastrarTelefone(Telefone4);
            int[] arrayDeId = new int[4];
            arrayDeId[0] = telefone1;
            arrayDeId[1] = telefone2;
            arrayDeId[2] = telefone3;
            arrayDeId[3] = telefone4;
            return arrayDeId;
        }
    }
}
