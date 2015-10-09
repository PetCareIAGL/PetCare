using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public interface IDal : IDisposable
    {
        // advertissement actions
        List<AdvertisementModel> getAllAdvertissements();
        void addAdvertissement(DateTime date, string title, string description, AnimalModel animal);
        void deleteAdvertissement(AdvertisementModel advertissement);

        // animal actions
        List<AnimalModel> getAllAnimals();
        void addImage(byte[] image, string description);
        void deleteAnimal(AnimalModel animal);

        // person actions
        List<PersonModel> getAllPersons();
        void addPerson(String name, string lastname, DateTime birthday, string email, string address, string phone, string login, string password, ImageModel image);
        void deleteAnimal(PersonModel person);

        // image actions
        List<ImageModel> getAllImages();
        void addImage(String description, Byte[] image);
        void deleteImage(ImageModel image);
    }
}
 