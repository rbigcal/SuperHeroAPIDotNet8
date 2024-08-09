using Microsoft.EntityFrameworkCore;
using SuperHeroAPI_DotNet8.Core.Entities;

namespace SuperHeroAPI_DotNet8.Core.Data {
    public class DataContext : DbContext {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
