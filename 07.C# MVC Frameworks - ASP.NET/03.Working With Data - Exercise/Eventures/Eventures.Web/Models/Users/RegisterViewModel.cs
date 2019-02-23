using System.ComponentModel.DataAnnotations;

namespace Eventures.Web.Models.Users
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression("[a-zA-z0-9-_.*~]")]
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        [MinLength(5)]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression("[0-9]{10}")]
        public string Ucn { get; set; }
    }
}
