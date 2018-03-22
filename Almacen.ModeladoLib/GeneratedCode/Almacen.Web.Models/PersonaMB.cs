using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace Almacen.Web.Models
{
    public class PersonaMB : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var Request = controllerContext.HttpContext.Request;
            var Persona = new Persona();
            Persona.Nombre = Request.Form["Nombre"];
            Persona.CodigoPostal = int.Parse(Request.Form["CodigoPostal"]);
            Persona.DominioIngles = byte.Parse(Request.Form["DominioIngles"]);
            Persona.Correo = Request.Form["Correo"];
            Persona.Habilidades = Request.Form["Habilidades"].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(h => h.Trim()).ToArray();
            if (Persona.Habilidades.Count() <=1)
            {
                bindingContext.ModelState.AddModelError("Habilidades","Debe proporcionar más de una habilidad");
            }
            return Persona;
        }
    }
}
