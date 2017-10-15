using System.Collections.Generic;

namespace OVO.Web.ViewModels.Vehicle
{
    public class VehicleExtendedViewModel
    {
        public IEnumerable<ManufacturerViewModel> Manufacturers { get; set; }

        public IEnumerable<ModelViewModel> Models { get; set; }

        public VehicleViewModel Vehicle { get; set; }
    }
}