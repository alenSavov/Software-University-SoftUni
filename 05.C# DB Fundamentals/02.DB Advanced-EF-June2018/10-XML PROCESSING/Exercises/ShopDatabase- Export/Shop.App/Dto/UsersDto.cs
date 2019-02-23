using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Shop.App.Dto
{
    [XmlRoot("users")]
    public class UsersDto
    {
        [XmlAttribute("count")]
        public int Count { get; set; }
        
        [XmlElement("user")]
        public UserDto[] User { get; set; }

        
    }
}
