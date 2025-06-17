using Microsoft.EntityFrameworkCore;
using aspnetcore_person_api.Models;

namespace aspnetcore_person_api.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Person> Person => Set<Person>();
    }
}
