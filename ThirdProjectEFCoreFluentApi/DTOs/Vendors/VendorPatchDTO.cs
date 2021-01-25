using System;
using System.ComponentModel.DataAnnotations;
using ThirdProjectEFCoreFluentApi.CustomAnnotation;
using ThirdProjectEFCoreFluentApi.DTOs.Tags;

namespace ThirdProjectEFCoreFluentApi.DTOs.Vendors
{
    public class VendorPatchDTO
    {
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        [Required]
        [MaxLength(128)]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [TagsIcollectionAnnotation]
        public TagDTO Tags { get; set; }
    }
}
