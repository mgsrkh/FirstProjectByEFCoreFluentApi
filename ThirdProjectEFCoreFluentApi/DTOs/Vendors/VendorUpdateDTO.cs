using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThirdProjectEFCoreFluentApi.CustomAnnotation;
using ThirdProjectEFCoreFluentApi.DTOs.Tags;

namespace ThirdProjectEFCoreFluentApi.DTOs.Vendors
{
    public class VendorUpdateDTO
    {
        public VendorUpdateDTO()
        {
            Tags = new List<TagDTO>();            
        }
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        [StringLength(128)]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [TagsIcollectionAnnotation]
        public List<TagDTO> Tags { get; set; }
    }
}
