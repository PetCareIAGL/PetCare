using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class AdvertisementModel
    {
        [Key]
        public int id { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [Required]
        [Display(Name = "Titre")]
        public String title { get; set; }

        [Required]
        [Display(Name = "Description")]
        public String description { get; set; }

        public virtual AnimalModel animal { get; set; }

        //[Required]
        //[ForeignKey("UserId")]
        //public virtual ApplicationIdentity user { get; set; }
        public string UserId { get; set; }
    }
}