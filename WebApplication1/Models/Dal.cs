using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
   public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        /**
         * Supprimer instance
         */
        public void Dispose()
        {
            bdd.Dispose();
        }

        List<AdvertisementModel> IDal.getAllAdvertissements()
        {
            return bdd.advertissements.ToList();
        }

        void IDal.CreateAdvertissement(DateTime date_param, string title_param, string description_param, AnimalModel animal_param)
        {
            bdd.advertissements.Add(new AdvertisementModel { date = date_param, title = title_param, description = description_param, animal = animal_param });
            
            // persister les modifications en base de données
            bdd.SaveChanges();
        }

        public void addImage(byte[] image_param, string description_param)
        {
            bdd.images.Add(new ImageModel { image = image_param, description = description_param });
        }
    }
}