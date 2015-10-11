using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // méthode retournant un resultat de type ViewResult dérivé de ActionResult
            // elle doit contenir le nom de la vue à rendre. Par default si c'est pas présé on recherche la vue avec le meme nom que l'action

            using (IDal dal = new Dal())
            {
                //dal.addAdvertissement(DateTime.Now, "Chien méchant", "La description", null);
                //List<AdvertisementModel> advertissements = dal.getAllAdvertissements();

                //ViewBag.Message = "Titre = " + advertissements[0].title;
            }
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