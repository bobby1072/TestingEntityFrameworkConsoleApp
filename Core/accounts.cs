using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class DbAccount
    {
        public int id { get; set; }
        public string account_name { get; set; }
        public float balance { get; set; }
    }
    public class BlogDbContext: DbContext
    {
        public DbSet<DbAccount> accounts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=localhost;Port=4444;Database=test;User ID=postgres;Password=postgres;SslMode=Disable");
    }
}

