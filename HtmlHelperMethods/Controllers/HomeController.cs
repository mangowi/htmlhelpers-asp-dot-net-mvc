using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelperMethods.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var categories = new List<SelectListItem>
            {
                new SelectListItem {Text = "Classic", Value = "C" },
                 new SelectListItem {Text = "Staff Recommends", Value = "S" },
                  new SelectListItem {Text = "Book Club Selection", Value = "BS" },
                   new SelectListItem {Text = "Family", Value = "F" },
                    new SelectListItem {Text = "Popular", Value = "P" }
            };
            ViewBag.Categories = categories;

            return View();
        }

    }
}