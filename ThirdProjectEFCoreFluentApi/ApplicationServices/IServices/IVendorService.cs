using Microsoft.AspNetCore.JsonPatch;
using ThirdProjectEFCoreFluentApi.DTOs.Vendors;

namespace ThirdProjectEFCoreFluentApi.ApplicationServices.IServices
{
    public interface IVendorService
    {
        VendorDTO GetAll(int id);
        bool Insert(VendorInsertDTO dto);
        bool Update(VendorUpdateDTO dto);
        bool Delete(int id);
        bool Patch(int id);
        bool GetByIdForPatch(VendorPatchDTO dto, int id);
        bool GetByIdForJsonPatch(JsonPatchDocument<VendorDTO> vendorPatch, int id);
    }
}
