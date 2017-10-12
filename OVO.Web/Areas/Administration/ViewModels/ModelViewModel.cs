using System;

namespace OVO.Web.Areas.Administration.ViewModels
{
    public class ModelViewModel
    {
        public Guid Id { get; set; }

        public string ManufacturerName { get; set; }

        public string ModelName { get; set; }

        public bool IsDeleted { get; set; }
    }
}