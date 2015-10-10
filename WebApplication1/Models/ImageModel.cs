using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class ImageModel
    {
        [Key]
        public int id { get; set; } //primary key will be auto increament

        public byte[] image { get; set; } //This is will saved as varcharbindary(max) into the database

        public string description { get; set; }
    }
}