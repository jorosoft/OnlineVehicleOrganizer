using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OVO.Data.Models;

namespace OVO.Web.Areas.Administration.Controllers
{
    public class ManufacturersController : Controller
    {        
        public ActionResult All()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Guid manufacturerId)
        {
            return View();
        }

        public ActionResult Edit(Guid manufacturerId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Manufacturer manufacturer)
        {
            return View();
        }

        public ActionResult Delete(Guid manufacturerId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Manufacturer manufacturer)
        {
            return View();
        }        
    }
}