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
        public async Task<ActionResult<IEnumerable<Vendor>>> GetAllVendors()
        {
            var vendors = await _repository.GetAllVendorsAsync();
            return Ok(vendors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vendor>> GetVendor(int id)
        {
            var vendor = await _repository.GetVendorByIdAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }
            return Ok(vendor);
        }

        [HttpPost]
        public async Task<ActionResult<Vendor>> CreateVendor(Vendor vendor)
        {
            var newVendor = await _repository.CreateVendorAsync(vendor);
            return CreatedAtAction(nameof(GetVendor), new { id = newVendor.BusinessEntityID }, newVendor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVendor(int id, Vendor vendor)
        {
            if (id != vendor.BusinessEntityID)
            {
                return BadRequest();
            }

            var updated = await _repository.UpdateVendorAsync(vendor);

            if (!updated)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendor(int id)
        {
            var deleted = await _repository.DeleteVendorByIdAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
