using Microsoft.EntityFrameworkCore;
using products.models;

namespace products.data
{
    public class AppDbContext : DbContext
    {
        private readonly DbContextOptions _options;
        public AppDbContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }
        public DbSet<customer>? customers {  get; set; }
        public DbSet<order>? orders { get; set; }
        public DbSet<product>? products { get; set; }
        public DbSet<shpoingcart>? shpoingcarts { get; set; }


    }
}
