using System;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Web.Models.Events
{
    public class CreateEventsViewModel
    {
        [Required]
        [MinLength(10)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Start { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime End { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int TotalTickets { get; set; }

        [Required]
        [RegularExpression(@"^\d+\.\d{18,2}$")]
        public decimal PricePerTicket { get; set; }

        [Required]
        [MinLength(1)]
        public string Place { get; set; }
    }
}
