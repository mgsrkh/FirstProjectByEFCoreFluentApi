using System.Collections.Generic;

namespace ThirdProjectEFCoreFluentApi.DTOs.Vendors
{
    public class VendorGridResultDTO
    {
        public VendorGridResultDTO(ICollection<VendorDTO> vendorDTOs)
        {
            VendorDTOs = vendorDTOs;
        }
        public ICollection<VendorDTO> VendorDTOs { get; set; }
    }
}
