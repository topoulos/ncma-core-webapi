namespace Ncma.Api2.Dtos {
    using System.ComponentModel.DataAnnotations;

    public class RegisterDto {
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength (100, ErrorMessage = "PASSWORD_MIN_LENGTH", MinimumLength = 6)]
        public string Password { get; set; }
    }

}