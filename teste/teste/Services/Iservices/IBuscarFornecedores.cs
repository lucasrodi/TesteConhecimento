namespace teste.Services.Iservices
{
    public interface IBuscarFornecedores<T>
    {
        public List<T> BuscarFornecedor(string Nome);
      
    }
}
