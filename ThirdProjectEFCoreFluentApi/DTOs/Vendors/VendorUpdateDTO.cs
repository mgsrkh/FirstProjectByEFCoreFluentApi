using System;
using System.Collections.Generic;
using ThirdProjectEFCoreFluentApi.DTOs.Tags;

namespace ThirdProjectEFCoreFluentApi.DTOs.Vendors
{
    public class VendorUpdateDTO
    {
        public VendorUpdateDTO()
        {
            Tags = new List<TagDTO>();            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public List<TagDTO> Tags { get; set; }
    }
}
