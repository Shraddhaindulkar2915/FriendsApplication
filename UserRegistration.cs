using System.ComponentModel.DataAnnotations;
namespace FriendApp.Models
{
    public class UserRegistration
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        
    }
}
