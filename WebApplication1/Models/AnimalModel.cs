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
        public int id { get; set; }

        [Required]
        [Display(Name = "Nom de l'animal")]
        public string name { get; set; }

        [Display(Name = "Type d'animal")]
        public string type { get; set;}

        [Display(Name = "Race")]
        public string race { get; set; }

        [Display(Name = "Photo")]
        public virtual List<ImageModel> photo { get; set; }
    }
}