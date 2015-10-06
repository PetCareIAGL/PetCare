using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class AdvertisementModel
    {
        [Key]
        public int idAdvertisement { get; set; }
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public String title { get; set; }
        public String description { get; set; }

        public virtual AnimalModel animal { get; set; }

        public class AdvertisementDBContext : DbContext
        {
            public DbSet<AdvertisementModel> Advertisement { get; set; }
        }
    }
}