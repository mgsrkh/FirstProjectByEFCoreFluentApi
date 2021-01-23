using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ThirdProjectEFCoreFluentApi.Models;

namespace ThirdProjectEFCoreFluentApi.Models
{
    [Table("Torfeh_vendor")]
    public class Vendor
    {
        public Vendor()
        {
            Tags = new HashSet<Tag>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        [StringLength(128)]
        public string Title { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Date { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
