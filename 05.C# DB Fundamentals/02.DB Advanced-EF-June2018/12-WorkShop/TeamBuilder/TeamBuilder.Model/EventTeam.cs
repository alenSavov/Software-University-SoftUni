using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeamBuilder.Model
{
   public class EventTeam
    {
        [ForeignKey("Event")]
        [MinLength(0)]
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        [ForeignKey("Team")]
        [MinLength(0)]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
