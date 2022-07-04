using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public interface IApplicationContext
    {
        DbSet<Filme> Filmes { get; set; }
    }
}