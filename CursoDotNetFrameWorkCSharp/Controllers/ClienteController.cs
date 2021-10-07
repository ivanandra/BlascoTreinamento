using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CursoDotNetFrameWorkCSharp.Models;

namespace CursoDotNetFrameWorkCSharp.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        [Route(template:"novo-cliente")]
        public ActionResult Cliente()
        {
            return View();
        }

       [HttpPost]
       [Route(template:"novo-cliente")]
        public ActionResult Cliente(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);
            //Alguma regra de negócio + gravar no banco
            return View(cliente);
        } 
    }
}