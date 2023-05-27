using Microsoft.EntityFrameworkCore;

namespace WebAppPiac.Models
{
    public class MyDatabaseContext:DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options):base (options)
        {
        }
        public MyDatabaseContext() { }

        public DbSet<Gyumolcs> Gyumolcs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;database=piac2;user=root;password=;ssl mode=none;");
            }
        }

    }
}
