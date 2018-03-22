using Almacen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almacen.Web.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index() => View();
        [HttpPost]
        public ActionResult Index(Persona persona)
        {
            ActionResult Resultado;
            if (ModelState.IsValid)
            {
                Resultado = Content("Datos correctos");
            }
            else
            {
                Resultado = View(persona);
            }
            return Resultado;
        }
    }
}