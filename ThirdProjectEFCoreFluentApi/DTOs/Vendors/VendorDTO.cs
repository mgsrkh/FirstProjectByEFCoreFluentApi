using System;
using System.Collections.Generic;
using ThirdProjectEFCoreFluentApi.DTOs.Tags;

namespace ThirdProjectEFCoreFluentApi.DTOs.Vendors
{
    public class VendorDTO
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public ICollection<TagDTO> Tags { get; set; }
        //public TagDTO Tag { get; set; }

    }
}
