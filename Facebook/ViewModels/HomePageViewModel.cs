using System;
using System.ComponentModel.DataAnnotations;

namespace Facebook.ViewModels
{
    public class HomePageViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string LoginEmail { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Invalid e-mail")]
        [Display(Name = "Email")]
        public string RegisterEmail { get; set; }

        [Required]
        [RegularExpression(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,15})", ErrorMessage = "Invalid password")]
        [Display(Name = "Password")]
        public string RegisterPassword { get; set; }

        [Required]
        [Compare("RegisterPassword")]
        [Display(Name = "Re-type Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Mobile { get; set; }
    }
}
