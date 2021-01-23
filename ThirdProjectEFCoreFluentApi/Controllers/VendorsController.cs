using Microsoft.AspNetCore.Mvc;
using ThirdProjectEFCoreFluentApi.ApplicationServices.IServices;
using ThirdProjectEFCoreFluentApi.DTOs.Vendors;

namespace ThirdProjectEFCoreFluentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorsController : ControllerBase
    {
        private readonly IVendorService _vendorService;

        public VendorsController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }
        [HttpGet("{id}")]
        public IActionResult GetVendors([FromRoute] int id)
        {
            var result = _vendorService.GetAll(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult InsertVendor([FromBody] VendorInsertDTO dto)
        {
            var result = _vendorService.Insert(dto);

            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult UpdateVendor(VendorUpdateDTO dto)
        {
            var result = _vendorService.Update(dto);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        //[HttpPatch("{id}")]
        //public StatusCodeResult PatchVendor([FromBody] JsonPatchDocument<VendorDTO> patch, [FromRoute] int id)
        //{
        //    var res = _vendorService.GetByIdForJsonPatch(patch, id);
        //    if (res)
        //    {
        //        return Ok();
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}
        [HttpPatch("{id}")]
        public IActionResult PatchVendor([FromBody] VendorPatchDTO patch, [FromRoute] int id)
        {
            var result = _vendorService.GetByIdForPatch(patch, id);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVendor([FromRoute] int id)
        {
            var result = _vendorService.Delete(id);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
