﻿namespace Eventures.Models
{
    public class UserEvents
    {
        public string UserId { get; set; }

        public User User { get; set; }


        public string EventId { get; set; }

        public Event Event { get; set; }
    }
}
