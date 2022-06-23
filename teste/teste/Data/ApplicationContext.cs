using Microsoft.EntityFrameworkCore;
using teste.Models;

namespace teste.Data
{
    public class ApplicationContext: DbContext
    {
        private string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TesteDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<FornecedorComCnpj> FornecedorComCnpj { get; set; }
        public DbSet<FornecedorComCpf> FornecedorComCpf { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }
        
    }
}
