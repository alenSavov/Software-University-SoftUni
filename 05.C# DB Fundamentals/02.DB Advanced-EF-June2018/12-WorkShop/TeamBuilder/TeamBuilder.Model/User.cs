﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TeamBuilder.Model.Enums;

namespace TeamBuilder.Model
{
    public class User
    {
        public User()
        {
            this.CreatedEvents = new List<Event>();
            this.MemberOf = new List<UserTeam>();
            this.CreateUserTeams = new List<UserTeam>();
            this.ReceivedInvitations = new List<Invitation>();
        }

        [Key]
        [MinLength(0)]
        public int UserId { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string Username { get; set; }

        [MaxLength(25)]
        public string FirstName { get; set; }

        [MaxLength(25)]
        public string LastName { get; set; }

        [StringLength(30, MinimumLength = 6)]
        [Required]
        public string Password { get; set; }

        [MinLength(0)]
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public bool IsDeleted { get; set; }


        public virtual ICollection<Event> CreatedEvents { get; set; }

        public virtual ICollection<UserTeam> MemberOf { get; set; }

        public virtual ICollection<UserTeam> CreateUserTeams { get; set; }

        public virtual ICollection<Invitation> ReceivedInvitations { get; set; }
    }
}
