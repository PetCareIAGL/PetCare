using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{   
    public class ImageModel
    {
        [Key]
        public int IdImage { get; set; } //primary key will be auto increament

        public byte[] Image { get; set; } //This is will saved as varcharbindary(max) into the database

        public string Description { get; set; }
    }

    public class ImageContext : DbContext
    {
        public ImageContext()
            //: base("MyConnectionString") //connection string name in the database
            : base("DefaultConnection")
        {

        }

        public DbSet<ImageModel> ImageModel { get; set; }
    }
}