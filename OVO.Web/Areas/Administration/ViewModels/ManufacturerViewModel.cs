using System;
using System.ComponentModel.DataAnnotations;

namespace OVO.Web.Areas.Administration.ViewModels
{
    public class ManufacturerViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }
    }
}