using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace Shop.App.Dto
{
    [XmlType("category")]
    public class CategoryDto
    {
        [StringLength(15, MinimumLength = 3)]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
