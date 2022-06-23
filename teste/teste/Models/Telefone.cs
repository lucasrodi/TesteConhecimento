namespace teste.Models
{
    public class Telefone
    {
        public Telefone(string? telefones )
        {
            Telefones = telefones;
            
        }
        public Telefone()
        {
                
        }
        public int Id { get; set; }
 
        public string? Telefones { get; set; }
       

    }
}
