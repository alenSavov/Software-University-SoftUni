
using Mish_Mash.Models.Enums;
using System.Collections.Generic;

namespace Mish_Mash.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public ICollection<UserInChannel> Chennels { get; set; }

        public Role Role { get; set; }
    }
}
