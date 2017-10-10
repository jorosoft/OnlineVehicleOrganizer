using System.Linq;
using System.Web.Mvc;
using OVO.Services.Contracts;
using OVO.Web.ViewModels.Vehicle;

namespace OVO.Web.Controllers
{
    public class VehicleController : Controller
    {
        public VehicleController()
        {
        }

        public ActionResult Index()
        {
            
            return this.View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Add(VehicleViewModel vehicle)
        {
            return this.View();
        }
    }
}