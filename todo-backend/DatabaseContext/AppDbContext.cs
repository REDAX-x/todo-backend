
using Microsoft.EntityFrameworkCore;
using todo_backend.Models;

namespace todo_backend.Database_Context
    
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}
