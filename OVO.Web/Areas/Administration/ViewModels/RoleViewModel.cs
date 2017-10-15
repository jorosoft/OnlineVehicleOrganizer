using System.ComponentModel.DataAnnotations;

namespace OVO.Web.Areas.Administration.ViewModels
{
    public class RoleViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }
    }
}