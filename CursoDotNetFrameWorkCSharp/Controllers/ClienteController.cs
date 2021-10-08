using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CursoDotNetFrameWorkCSharp.Data;
using CursoDotNetFrameWorkCSharp.Models;

namespace CursoDotNetFrameWorkCSharp.Controllers
{
    public class ClienteController : Controller
    {
        public static readonly AppDbContext context = new AppDbContext();

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

            DateTime now = DateTime.Now;
            cliente.DataCadastro = now;
                context.Clientes.Add(cliente);
                context.SaveChanges();

            return View(cliente);
        } 
    }
}