namespace Soccer.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Entities;
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

       public DbSet<TeamEntity> Teams { get; set; }
    }
}
