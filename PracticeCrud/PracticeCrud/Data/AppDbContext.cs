using Microsoft.EntityFrameworkCore;
using PracticeCrud.Models;

namespace PracticeCrud.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        

        public DbSet<Vendor> vendors { get; set; }
    }
}
