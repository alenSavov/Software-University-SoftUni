using System;

namespace IRunes.App.Models
{
    public class User : BaseEntity<string>
    {
        public string Username { get; set; }

        public string HashedPassword { get; set; }

        public string Email { get; set; }
    }
}
