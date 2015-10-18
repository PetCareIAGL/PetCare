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
         * Supprimer l'instance
         */
        public void Dispose()
        {
            bdd.Dispose();
        }

        List<AdvertisementModel> IDal.getAllAdvertissements()
        {
            return bdd.advertissements.ToList<AdvertisementModel>();            
        }

        void IDal.addAdvertissement(DateTime date_param, string title_param, string description_param, AnimalModel animal_param, string userId)
        {
            bdd.advertissements.Add(new AdvertisementModel { date = date_param, title = title_param, description = description_param, animal = animal_param, UserId = userId });            
            // persister les modifications en base de données
            bdd.SaveChanges();
        }

        public void addImage(byte[] image_param, string description_param)
        {
            bdd.images.Add(new ImageModel { image = image_param, description = description_param });
            bdd.SaveChanges();
        }

        public void deleteAdvertissement(AdvertisementModel advertissement)
        {
            bdd.advertissements.Remove(advertissement);
        }

        public List<AnimalModel> getAllAnimals()
        {
            return bdd.animals.ToList<AnimalModel>();
        }

        public void deleteAnimal(AnimalModel animal)
        {
            bdd.animals.Remove(animal);
        }

        public int addAnimal(AnimalModel animal)
        {
            bdd.animals.Add(new AnimalModel { name = animal.name, race = animal.race, type = animal.type, photo = animal.photo });
            return bdd.SaveChanges();
        }

        public List<ImageModel> getAllImages()
        {
            throw new NotImplementedException();
        }

        public void addImage(string description_param, byte[] image_param)
        {
            ImageModel img = new ImageModel { image = image_param, description = description_param };
            bdd.images.Add(img);
            bdd.SaveChanges();
        }
       
        public void deleteImage(ImageModel image)
        {
            bdd.images.Remove(image);
        }

        List<AdvertisementModel> IDal.getAdvertissementsByKeyword(string keyword)
        {
            return bdd.advertissements.Where(advertissement => advertissement.title.Contains(keyword)).ToList<AdvertisementModel>();
        }
    }
}