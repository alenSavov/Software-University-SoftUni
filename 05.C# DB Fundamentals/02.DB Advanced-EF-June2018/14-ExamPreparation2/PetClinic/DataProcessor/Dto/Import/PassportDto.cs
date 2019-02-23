using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetClinic.DataProcessor.Dto.Import
{
    public class PassportDto
    {
        [Key]
        [RegularExpression("^[a-zA-z]{7}[0-9]{3}$")]
        public string SerialNumber { get; set; }

        [Required]
        [MinLength(3), MaxLength(30)]
        public string OwnerName { get; set; }

        [Required]
        [RegularExpression(@"^[0]{1}[0-9]{9}$")]
        public string OwnerPhoneNumber { get; set; }

        [Required]
        public string RegistrationDate { get; set; }
    }
}
