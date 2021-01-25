using System.Collections.Generic;
using ThirdProjectEFCoreFluentApi.CustomAnnotation;

namespace ThirdProjectEFCoreFluentApi.DTOs.Vendors
{
    public class VendorGridResultDTO
    {
        public VendorGridResultDTO(ICollection<VendorDTO> vendorDTOs)
        {
            VendorDTOs = vendorDTOs;
        }
        [TagsIcollectionAnnotation]
        public ICollection<VendorDTO> VendorDTOs { get; set; }
    }
}
