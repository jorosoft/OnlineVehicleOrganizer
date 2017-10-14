using System.Web.Mvc;

namespace OVO.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }        

        public ActionResult Contact()
        {
            return this.View();
        }
    }
}