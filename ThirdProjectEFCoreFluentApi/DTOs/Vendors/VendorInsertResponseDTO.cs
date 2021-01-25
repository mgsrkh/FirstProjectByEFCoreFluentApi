using System.ComponentModel.DataAnnotations;

namespace ThirdProjectEFCoreFluentApi.DTOs.Vendors
{
    public class VendorInsertResponseDTO : VendorInsertDTO
    {
        [Required]
        public int Id { get; set; }
    }
}
