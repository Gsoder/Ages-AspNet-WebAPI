using Ages_The_Game.Data.Map;
using Ages_The_Game.Models;
using Microsoft.EntityFrameworkCore;

namespace Ages_The_Game.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        
            ChangeTracker.LazyLoadingEnabled = true;
        
        }
        public DbSet<ImagensModels> ItensDaLista { get; set; }
        public DbSet<ListaImagensModels> Lista { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.ApplyConfiguration(new ListaImagensMap());
            modelBuilder.ApplyConfiguration(new ImagensMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
