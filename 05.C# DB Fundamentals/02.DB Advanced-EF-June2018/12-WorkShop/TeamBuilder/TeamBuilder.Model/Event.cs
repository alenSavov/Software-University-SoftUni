using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeamBuilder.Model
{
   public class Event
    {
        public Event()
        {
            this.ParticipatingEventTeams = new List<EventTeam>();
        }

        [Key]
        [MinLength(0)]
        public int EventId { get; set; }

        [MaxLength(25)]
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }
        
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [ForeignKey("Creator")]
        [MinLength(0)]
        public int CreatorId { get; set; }
        public virtual User Creator { get; set; }

        public virtual ICollection<EventTeam> ParticipatingEventTeams { get; set; }
    }
}
