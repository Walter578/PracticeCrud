using Microsoft.EntityFrameworkCore;
using PracticeCrud.Models;

namespace PracticeCrud.Interface
{
    public interface IVendorRepository
    {
        Task<IEnumerable<Vendor>> GetVendorByIdAsync();
    }
}
