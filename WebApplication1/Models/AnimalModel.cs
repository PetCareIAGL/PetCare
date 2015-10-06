using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class AnimalModel
    {
        [Key]
        public int idAnimal { get; set; }
        public string name { get; set; }
        public string type { get; set;}
        public string race { get; set; }

        public class AnimalDBContext : DbContext
        {
            public DbSet<AnimalModel> Animals { get; set; }
        }
    }
}