using Microsoft.EntityFrameworkCore;
using PracticeCrud.Data;

namespace PracticeCrud.Models
{
    public class VendorRepository 
    {
        private readonly AppDbContext _context;
        public VendorRepository(AppDbContext context) {  _context = context; }

        //public async Task<Vendor> GetVendorByIdAsync(int id) => await _context.vendors.FindAsync(id);

        public async Task<IEnumerable<Vendor>> GetVendorByIdAsync() => await _context.vendors.Take(100).ToListAsync();
    }
}
