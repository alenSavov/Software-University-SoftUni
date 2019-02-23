using PetClinic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PetClinic.DataProcessor.Dto.Import
{
    [XmlType("AnimalAid")]
    public class ProcedureAnimalAidDto
    {
        [XmlElement("Name")]
        public string Name { get; set; }
    }
}
