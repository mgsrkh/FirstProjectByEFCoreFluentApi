using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThirdProjectEFCoreFluentApi.Models
{

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}
