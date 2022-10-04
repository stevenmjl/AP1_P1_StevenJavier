using Microsoft.EntityFrameworkCore;
using AP1_P1_StevenJavier.Models;

namespace AP1_P1_StevenJavier.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Aportes> Aportes { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
    }
}
