using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ProyectoEstacionamientos.Models;

namespace ProyectoEstacionamientos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult LoginUsuarios(UsuariosModels model)
        {
            try
            {
                using(ESTACIONAMIENTOSEntities db= new ESTACIONAMIENTOSEntities())
                {

                    
                    var oUser = (from d in db.Usuarios join c in db.Clientes on d.idcliente equals c.idcliente
                                 where d.idcliente == model.Cliente && d.usuario == model.Usuario && d.clave == model.Clave
                                 select d).FirstOrDefault();

                    if (oUser != null)
                    {
                        DatosUsuarios.Cliente = oUser.idcliente;
                        DatosUsuarios.Nivel = Convert.ToInt32(oUser.nivel);
                        DatosUsuarios.Nombre = oUser.Clientes.nombre;
                        FormsAuthentication.SetAuthCookie(oUser.usuario, true);
                        return RedirectToAction("ClientesDashboard", "Access");

                    }
                    else
                    {
                        ViewData["Error"] = "Datos Incorrectos";
                        return View("Login");

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}