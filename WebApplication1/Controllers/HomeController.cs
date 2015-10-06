using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // méthode retournant un resultat de type ViewResult dérivé de ActionResult
            // elle doit contenir le nom de la vue à rendre. Par default si c'est pas présé on recherche la vue avec le meme nom que l'action
            return View();
        }

        public ActionResult About()
        {
            // une proprieté automatiquement présent dans le controller; elle est automatiquement passée à la vue
            ViewBag.Message = "Petcare.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Petcare.";

            return View();
        }
    }
}