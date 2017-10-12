using System;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace OVO.Web.Controllers
{
    public class LanguageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Change(string languageAbbreviation)
        {
            if (languageAbbreviation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(languageAbbreviation);
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(languageAbbreviation);

                var cookie = new HttpCookie("Language");
                cookie.Value = languageAbbreviation;
                Response.Cookies.Add(cookie);
            }            

            return this.RedirectToAction("Index", "Home");
        }
    }
}