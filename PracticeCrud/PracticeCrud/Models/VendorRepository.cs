using Microsoft.EntityFrameworkCore;
using PracticeCrud.Data;
using PracticeCrud.Interface;

namespace PracticeCrud.Models
{
    public class VendorRepository : IVendorRepository
    {
        private readonly AppDbContext _context;
        public VendorRepository(AppDbContext context) {  _context = context; }

        //public async Task<Vendor> GetVendorByIdAsync(int id) => await _context.vendors.FindAsync(id);

        public async Task<IEnumerable<Vendor>> GetVendorByIdAsync() => await _context.vendors.Take(100).ToListAsync();
    }
}
