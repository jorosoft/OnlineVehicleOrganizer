using System;

namespace OVO.Web.ViewModels.Vehicle
{
    public class ModelViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ManufacturerViewModel Manufacturer { get; set; }
    }
}