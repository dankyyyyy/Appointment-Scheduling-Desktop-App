using AppointmentSchedulerUI.Exceptions;
using AppointmentSchedulerUILibrary.UIRegex;
using System.ComponentModel.DataAnnotations;

namespace AppointmentSchedulerUILibrary
{
    public class LoginCredential
    {

        [Required]
        [StringLength(50, ErrorMessage = UIErrorMessages.LengthExceeded)]
        [RegularExpression(EmailRegex.Pattern, ErrorMessage = UIErrorMessages.InvalidEmail)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = UIErrorMessages.LengthExceeded)]
        [RegularExpression(PasswordRegex.Pattern, ErrorMessage = UIErrorMessages.InvalidPassword)]
        public string Password { get; set; }
    }
}