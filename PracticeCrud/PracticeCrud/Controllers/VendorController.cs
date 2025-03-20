using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PracticeCrud.Interface;
using PracticeCrud.Models;

namespace PracticeCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorRepository _repository;

        public VendorController(IVendorRepository repository)
        {
            _repository = repository;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendor>>> GetVendor()
        {
            var Vendor = await _repository.GetVendorByIdAsync();
            return Ok(Vendor);
        }
        
            
    }

    

    
}
