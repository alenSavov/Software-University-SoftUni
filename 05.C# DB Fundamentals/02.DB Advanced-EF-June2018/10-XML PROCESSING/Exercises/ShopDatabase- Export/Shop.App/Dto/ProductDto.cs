using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Shop.App.Dto
{
    [XmlType("product")]
    public class ProductDto
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("price")]
        public decimal Price { get; set; }
    }
}
