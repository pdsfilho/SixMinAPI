using Microsoft.EntityFrameworkCore;
using SixMinAPI.Models;

namespace SixMinApi.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Command> Commands => Set<Command>();
    }
}