using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using Microsoft.AspNet.Identity;

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

            if (!Request.IsAuthenticated)
            {
                ViewBag.status = "Vous devez être connecté pour créer une annonce.";
            }
            return View();
        }

        //
        // POST: /Advertisment/RegisterAdvertisment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterAdvertisement(AdvertisementModel model, HttpPostedFileBase file)
        {
            if (Request.IsAuthenticated)
            {
                if (ModelState.IsValid)
                {
                    string userId = User.Identity.GetUserId();

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
                        dal.addAdvertissement(DateTime.Now, model.title, model.description, animal, userId);

                    return RedirectToAction("RegisterAdvertisement", new { Message = AdvertisementMessageId.AddAdvertiseSuccess });
                }
                else
                    return View(model);
            }
            else
                return RedirectToAction("Login", "Account");
        }

        public ActionResult ConsultAdvertisementView()
        {
            IDal dal = new Dal();
            List<AdvertisementModel> advertissements = dal.getAllAdvertissements();            
            return View(advertissements);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConsultAdvertisementView(AdvertisementModel model)
        {
            return View(model);
        }

        public enum AdvertisementMessageId
        {
            AddAdvertiseSuccess,
            Error
        }

        // GET: Advertisement
        public ActionResult Index()
        {
            return View();
        }

        // GET: Advertisement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
       
        // GET: Advertisement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Advertisement/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Advertisement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Advertisement/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
