using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThirdProjectEFCoreFluentApi.Models
{
    [Table("Torfeh_Tag")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        [StringLength(128)]
        public string Value { get; set; }
        [Required]
        [ForeignKey("VendorId")]
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}
