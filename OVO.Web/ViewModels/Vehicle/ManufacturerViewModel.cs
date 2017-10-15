using System;
using System.ComponentModel.DataAnnotations;

namespace OVO.Web.ViewModels.Vehicle
{
    public class ManufacturerViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }
    }
}