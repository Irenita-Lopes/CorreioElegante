using CorreioElegante.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CorreioElegante.Configs
{
    public class MysqlDbContext : DbContext
    {
        public MysqlDbContext(DbContextOptions<MysqlDbContext> options)
            : base(options)
        {
        }

        public DbSet<Correio> Correios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CorreioConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
