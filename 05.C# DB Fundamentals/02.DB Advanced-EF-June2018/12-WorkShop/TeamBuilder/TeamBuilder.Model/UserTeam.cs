using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeamBuilder.Model
{
    public class UserTeam
    {       
        [ForeignKey("User")]
        public int Userd { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
