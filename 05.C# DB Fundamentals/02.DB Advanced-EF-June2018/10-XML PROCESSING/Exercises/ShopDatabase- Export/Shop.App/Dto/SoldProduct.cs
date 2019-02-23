using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Shop.App.Dto
{
    [XmlType("sold-products")]
    public class SoldProduct
    {
        [XmlAttribute("count")]
        public int Count { get; set; }

        [XmlElement("product")]
        public ProductDto[] ProductDto { get; set; }
    }
}
