using System.ComponentModel.DataAnnotations;

namespace CmsHosp.Api.Models
{
    public class UserRegisterRequest
    {
        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string LastName { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty;
        [Required, Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
