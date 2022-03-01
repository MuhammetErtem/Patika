using Microsoft.EntityFrameworkCore;
using Patika.DAL.Entities;

namespace Patika.DAL.DbContexts
{
    public class SqlContext:DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> opt):base(opt)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Portfolio>().HasOne(ho => ho.Country).WithMany(wm => wm.Portfolios).OnDelete(DeleteBehavior.SetNull);
        }

        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Blog> Blog { get; set; }

        public DbSet<PortfolioPicture> PortfolioPicture { get; set; }

    }
}
