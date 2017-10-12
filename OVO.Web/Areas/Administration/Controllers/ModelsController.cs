using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OVO.Data.Models;

namespace OVO.Web.Areas.Administration.Controllers
{
    public class ModelsController : Controller
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
        public ActionResult Add(Guid modelId)
        {
            return View();
        }

        public ActionResult Edit(Guid modelId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Model model)
        {
            return View();
        }

        public ActionResult Delete(Guid modelId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Model model)
        {
            return View();
        }
    }
}