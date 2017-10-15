using System;
using System.ComponentModel.DataAnnotations;

namespace OVO.Web.ViewModels.Vehicle
{
    public class ModelViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }

        public ManufacturerViewModel Manufacturer { get; set; }
    }
}