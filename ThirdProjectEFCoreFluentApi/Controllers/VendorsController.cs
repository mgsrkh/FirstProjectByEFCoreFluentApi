using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using ThirdProjectEFCoreFluentApi.ApplicationServices.IServices;
using ThirdProjectEFCoreFluentApi.DTOs.Vendors;
using ThirdProjectEFCoreFluentApi.Models;

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
            var result = _vendorService.GetVendorsById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult InsertVendor([FromBody] VendorInsertResponseDTO dto)
        {
            var vendorInsertResponse = _vendorService.Insert(dto);

            return Created(new Uri($"/api/Vendors/{vendorInsertResponse.Id}", UriKind.Relative), vendorInsertResponse);
        }

        [HttpPut]
        public IActionResult UpdateVendor(VendorUpdateDTO dto)
        {
            var vendorUpdateResponse = _vendorService.Update(dto);

            if (vendorUpdateResponse)
            {
                return Ok(vendorUpdateResponse);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPatch("{id}")]
        public StatusCodeResult PatchVendor([FromBody] JsonPatchDocument<Vendor> patch, [FromRoute] int id)
        {
            var jsonPatchApply = _vendorService.GetVendorByIdForJsonPatchDoc(id);

            patch.ApplyTo(jsonPatchApply);

            var savePatched = _vendorService.SavePatchChanges(jsonPatchApply);
            if (savePatched > 0)
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
