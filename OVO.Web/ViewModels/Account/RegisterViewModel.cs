using System.ComponentModel.DataAnnotations;

namespace OVO.Web.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = nameof(OVO.Web.Resources.Lang.Email), ResourceType = typeof(OVO.Web.Resources.Lang))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = nameof(OVO.Web.Resources.Lang.Password), ResourceType = typeof(OVO.Web.Resources.Lang))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = nameof(OVO.Web.Resources.Lang.PassConfirm), ResourceType = typeof(OVO.Web.Resources.Lang))]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}