using DataTable.Models;
using Microsoft.EntityFrameworkCore;

namespace DataTable.Context
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> Options) : base(Options)
        { }

        public DbSet<Empresas> Empresas { get; set; }
    }
}
