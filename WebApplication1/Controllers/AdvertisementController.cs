using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AdvertisementController : Controller
    {
        private ImageController _imageController;

        public ActionResult RegisterAdvertisement(AdvertisementMessageId? message)
        {
            ViewBag.Message = "Petcare.";
            ViewBag.result =
                message == AdvertisementMessageId.AddAdvertiseSuccess ? "Votre annonce à été créé."
                : message == AdvertisementMessageId.Error ? "Erreur."
                : "";

            return View();
        }
        
        //
        // POST: /Advertisment/RegisterAdvertisment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterAdvertisement(AdvertisementModel model, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                //animal 
                AnimalModel animal = new AnimalModel
                {
                    name = model.animal.race,
                    type = model.animal.type,
                    race = model.animal.race
                };
                          
                if (file != null)
                {                    
                    _imageController = new ImageController();
                    animal.photo = new List<ImageModel> { _imageController.GetImage(file) };
                }                

                using (IDal dal = new Dal())                
                    dal.addAdvertissement(DateTime.Now, model.title, model.description, animal);
                                
                return RedirectToAction("RegisterAdvertisement", new { Message = AdvertisementMessageId.AddAdvertiseSuccess });
            }
            else
                return View(model);
        }

        public enum AdvertisementMessageId
        {
            AddAdvertiseSuccess,
            Error
        }
    }
}