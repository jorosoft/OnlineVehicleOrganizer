using System.ComponentModel.DataAnnotations;

namespace OVO.Web.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = nameof(OVO.Web.Resources.Lang.Email), ResourceType = typeof(OVO.Web.Resources.Lang))]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = nameof(OVO.Web.Resources.Lang.Password), ResourceType = typeof(OVO.Web.Resources.Lang))]
        public string Password { get; set; }

        [Display(Name = nameof(OVO.Web.Resources.Lang.RememberMe), ResourceType = typeof(OVO.Web.Resources.Lang))]
        public bool RememberMe { get; set; }
    }
}