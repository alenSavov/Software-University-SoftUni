using PetClinic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace PetClinic.DataProcessor.Dto.Import
{
    [XmlType("Procedure")]
    public class ProceduresDto
    {
        [XmlElement("Vet")]
        [Required]
        public Vet Vet { get; set; }

        [XmlElement("Animal")]
        [Required]
        public string Animal { get; set; }

        [XmlElement("DateTime")]
        [Required]
        public string DateTime { get; set; }

        [Required]
        [XmlArray("AnimalAids")]
        public ProcedureAnimalAidDto[] AnimalAids { get; set; }
    }
}
