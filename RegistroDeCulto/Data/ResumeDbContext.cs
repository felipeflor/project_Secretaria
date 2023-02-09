using Microsoft.EntityFrameworkCore;
using RegistroDeCulto.Models;

namespace RegistroDeCulto.Data
{
    public class RegistroDbContext : DbContext
    {
        public RegistroDbContext(DbContextOptions<RegistroDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Culto> Culto { get; set; }
    }
}
