using System;

namespace OVO.Web.Areas.Administration.ViewModels
{
    public class ManufacturerViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }
    }
}