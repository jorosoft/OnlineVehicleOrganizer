using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OVO.Web.Areas.Administration.ViewModels
{
    public class ModelViewModel
    {
        public Guid Id { get; set; }

        public IEnumerable<ManufacturerViewModel> Manufacturers { get; set; }

        [Required(ErrorMessage = "Required")]
        public string ModelName { get; set; }

        [Required(ErrorMessage = "Required")]
        public string ManufacturerName { get; set; }

        public bool IsDeleted { get; set; }
    }
}