using System.ComponentModel.DataAnnotations;

namespace BelfastWF_bkend.Models
{
    public class UserModel
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage ="email")]
        public string email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password, ErrorMessage ="password")]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Compare("password")]
        public string confirmPassword { get; set; }
    }
}