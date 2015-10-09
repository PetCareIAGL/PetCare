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
        // GET: Advertisement
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegisterAdvertisement()
        {
            ViewBag.Message = "Petcare.";

            return View();
        }

        //
        // POST: /Advertisment/RegisterAdvertisment
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterAdvertise(AdvertisementModel model, HttpPostedFileBase file)
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

                if (file != null && file.ContentLength > 0)
                {
                    var imgModel = new ImageModel
                    {
                        description = System.IO.Path.GetFileName(file.FileName)
                    };
                    using (var reader = new System.IO.BinaryReader(file.InputStream))
                    {
                        imgModel.image = reader.ReadBytes(file.ContentLength);
                    }
                    animal.photo = new List<ImageModel> { imgModel };
                }
                
                using (IDal dal = new Dal())
                {
                    dal.addAdvertissement(DateTime.Now, model.title, model.description, null);
                    List<AdvertisementModel> advertissements = dal.getAllAdvertissements();
                }                                
            }
            return View(model);
        }
    }
}