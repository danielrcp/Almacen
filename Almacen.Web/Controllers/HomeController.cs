using Almacen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almacen.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Categoria c = new Categoria
            {
                ID = 1,
                Nombre = "Bebidas",
                Descripcion = "Categoría de productos líquidos"
            };
            return View(c);
        }
    }
}