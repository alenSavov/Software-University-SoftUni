using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetClinic.Models
{
    public class ProcedureAnimalAid
    {
        [Key]
        public int ProcedureId { get; set; }
        [Required]
        public Procedure Procedure { get; set; }

        [Key]
        public int AnimalAidId { get; set; }
        [Required]
        public AnimalAid AnimalAid { get; set; }

    }
}
