﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Shop.App.Dto
{
    [XmlType("user")]
    public class UserDto
    {
        [XmlAttribute("first-name")]
        public string FirstName { get; set; }

        [XmlAttribute("last-name")]
        public string LastName { get; set; }

        [XmlAttribute("age")]
        public string Age { get; set; }

        [XmlElement("sold=products")]
        public SoldProduct SoldProducts { get; set; }
    }
}
