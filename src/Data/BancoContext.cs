using EvolvOS.Models;
using Microsoft.EntityFrameworkCore;

namespace EvolvOS.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
        }
        public DbSet<MateriaModel> Materias { get; set; }
    }
}
