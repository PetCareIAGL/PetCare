using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    /**
     * contexte permettant d’accéder à ces données (Entity Framework)
     * gère récupération, le stockage, la mise à jour des  instances Person dans une BDD 
     */
    public class BddContext : DbContext
    {
        ///public BddContext() : base("DefaultConnection") { } //: base("MyConnectionString") //connection string name in the database        
        public BddContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<AnimalModel> animals { get; set; }

        public DbSet<AdvertisementModel> advertissements { get; set; }

        public DbSet<PersonModel> persons { get; set; }

        public DbSet<ImageModel> images { get; set; }
    }
}