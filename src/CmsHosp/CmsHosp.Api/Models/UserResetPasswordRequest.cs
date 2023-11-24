using System.ComponentModel.DataAnnotations;

namespace CmsHosp.Api.Models
{
    public class UserResetPasswordRequest
    {
        [Required]
        public string Token { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "Lütfen en az 6 karakter giriniz!")]
        public string Password { get; set; } = string.Empty;
        [Required, Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
