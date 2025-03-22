using Microsoft.EntityFrameworkCore;
using PracticeCrud.Data;
using PracticeCrud.Interface;

namespace PracticeCrud.Models
{
    public class VendorRepository : IVendorRepository
    {
        private readonly AppDbContext _context;

        public VendorRepository(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IEnumerable<Vendor>> GetAllVendorsAsync()
        {
            return await _context.vendors.Take(100).ToListAsync();
        }

        
        public async Task<Vendor> GetVendorByIdAsync(int id)
        {
            return await _context.vendors.FindAsync(id);
        }

        
        public async Task<Vendor> CreateVendorAsync(Vendor vendor)
        {
            _context.vendors.Add(vendor);
            await _context.SaveChangesAsync();
            return vendor;
        }

        
        public async Task<bool> UpdateVendorAsync(Vendor vendor)
        {
            _context.Entry(vendor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendorExists(vendor.BusinessEntityID))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        
        public async Task<bool> DeleteVendorByIdAsync(int vendorId)
        {
            var vendor = await _context.vendors.FindAsync(vendorId);
            if (vendor == null)
            {
                return false;
            }

            _context.vendors.Remove(vendor);
            await _context.SaveChangesAsync();
            return true;
        }

        private bool VendorExists(int id)
        {
            return _context.vendors.Any(e => e.BusinessEntityID == id);
        }
    }
}
