using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoDotNetFrameWorkCSharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route(template:"contato")]
        public ActionResult Contact()
        {
            
            return View();
        }

        [Route(template:"sobre-nos")]
        public JsonResult About()
        {
            return Json(data:"text: 'asshole'", JsonRequestBehavior.AllowGet);
        }

        [Route(template:"google")]
        public RedirectResult RedirectResult()
        {
            return new RedirectResult(url: "https://www.google.com");
        }

        [Route(template:"asshole")]
        public ContentResult ContentResult()
        {
            return Content("Asshole!");
        }

    }
}