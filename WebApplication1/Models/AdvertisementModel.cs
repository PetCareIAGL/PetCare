using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class AdvertisementModel
    {
        [Key]
        public int id { get; set; }
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public String title { get; set; }
        public String description { get; set; }
        public virtual AnimalModel animal { get; set; }
    }
}