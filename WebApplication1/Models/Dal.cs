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

        void IDal.addAdvertissement(DateTime date_param, string title_param, string description_param, AnimalModel animal_param)
        {
            bdd.advertissements.Add(new AdvertisementModel { date = date_param, title = title_param, description = description_param, animal = animal_param });
            
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

        public List<PersonModel> getAllPersons()
        {
            return bdd.persons.ToList<PersonModel>();
        }

        public void addPerson(string name_param, string lastname_param, DateTime birthday_param, string email_param, string address_param, string phone_param, string login_param, string password_param, ImageModel image_param)
        {
            bdd.persons.Add(new PersonModel {
                image = image_param, name = name_param, address = address_param,
                birthday = birthday_param, email = email_param, lastname = lastname_param,
                login = login_param, password = password_param, phone = phone_param
            });
            bdd.SaveChanges();
        }

        public void deleteAnimal(PersonModel person)
        {
            bdd.persons.Remove(person);
        }

        public List<ImageModel> getAllImages()
        {
            throw new NotImplementedException();
        }

        public void addImage(string description_param, byte[] image_param)
        {
            bdd.images.Add(new ImageModel {image = image_param, description = description_param});
            bdd.SaveChanges();
        }

        public void deleteImage(ImageModel image)
        {
            bdd.images.Remove(image);
        }
    }
}