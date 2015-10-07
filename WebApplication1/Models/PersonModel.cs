using System;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class PersonModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public DateTime birthday { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public virtual ImageModel image { get; set; }
    }
}