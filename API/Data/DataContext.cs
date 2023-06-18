using API.Entitites;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    // INHERITANCE -> public class ClassName : BaseClassName
    public class DataContext : DbContext
    {
        //Inherit the base class constructor
        //https://learn.microsoft.com/en-us/dotnet/api/system.data.entity.dbcontext?view=entity-framework-6.2.0
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-classes
        public DbSet<AppUser> Users { get; set; }
    }
}