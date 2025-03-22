using PracticeCrud.Models;

namespace PracticeCrud.Interface
{
    public interface IVendorRepository
    {
        Task<Vendor> GetVendorByIdAsync(int id);            
        Task<IEnumerable<Vendor>> GetAllVendorsAsync();     

        Task<Vendor> CreateVendorAsync(Vendor vendor);      
        Task<bool> UpdateVendorAsync(Vendor vendor);        
        Task<bool> DeleteVendorByIdAsync(int vendorId);     
    }
}
