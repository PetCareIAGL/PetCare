using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public interface IDal : IDisposable
    {
        List<AdvertisementModel> getAllAdvertissements();
        void CreateAdvertissement(DateTime date, string title, string description, AnimalModel animal);
        void addImage(byte[] image, string description);
    }
}