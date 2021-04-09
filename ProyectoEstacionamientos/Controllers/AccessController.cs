using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProyectoEstacionamientos.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access

        [Authorize]        
        public ActionResult ClientesDashboard()
        {
            return View();
        }
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}