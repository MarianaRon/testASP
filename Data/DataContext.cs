using Microsoft.EntityFrameworkCore;

namespace testASP.Data
{

    public class DataContext : DbContext
    { 
        public DbSet<Entities.User> Users { get; set; }
        //делегуємо конструктор базовому класу, який приймає Options
        public DataContext(DbContextOptions options) : base(options)
        { }
        // Забеспечити підключення
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("testASP");


        }

    }
}