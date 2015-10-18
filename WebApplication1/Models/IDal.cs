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
        void addAdvertissement(DateTime date, string title, string description, AnimalModel animal, string userId);
        void deleteAdvertissement(AdvertisementModel advertissement);
        List<AdvertisementModel> getAdvertissementsByKeyword(string keyword);

        // animal actions
        List<AnimalModel> getAllAnimals();
        void addImage(byte[] image, string description);
        void deleteAnimal(AnimalModel animal);
        
        // image actions
        List<ImageModel> getAllImages();
        void addImage(String description, Byte[] image);
        void deleteImage(ImageModel image);
    }
}
 