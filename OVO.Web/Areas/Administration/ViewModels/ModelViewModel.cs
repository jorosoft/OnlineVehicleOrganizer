using System;
using System.Collections.Generic;

namespace OVO.Web.Areas.Administration.ViewModels
{
    public class ModelViewModel
    {
        public Guid Id { get; set; }

        public IEnumerable<ManufacturerViewModel> Manufacturers { get; set; }

        public string ModelName { get; set; }

        public string ManufacturerName { get; set; }

        public bool IsDeleted { get; set; }
    }
}