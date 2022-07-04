namespace Api.IServices
{
    public interface IUpdateFilme
    {
        public void Atualiza(int id,string nome, string duracao, string genero);
    }
}
