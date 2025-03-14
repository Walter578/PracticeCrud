using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace PracticeCrud.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }
    }
}
