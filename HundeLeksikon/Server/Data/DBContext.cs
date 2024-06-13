using HundeLeksikon.Shared;
using Microsoft.EntityFrameworkCore;

namespace HundeLeksikon.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }
        
        public DbSet<HundeData> HundeData { get; set;}

    }
}
