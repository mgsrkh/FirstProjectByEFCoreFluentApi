using System;
using System.Collections.Generic;
using ThirdProjectEFCoreFluentApi.DTOs.Tags;

namespace ThirdProjectEFCoreFluentApi.DTOs.Vendors
{
    public class VendorInsertDTO
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public List<TagDTO> Tags { get; set; }
    }
}
