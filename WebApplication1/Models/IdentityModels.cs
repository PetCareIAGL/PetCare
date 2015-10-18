using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Adress { get; set; }
        public virtual ImageModel Image { get; set; }

        [ForeignKey("UserId")]
        public virtual ICollection<AdvertisementModel> Adversitements { get; set; }    
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //public MyDbContext() : base("MyConnectionString") { }
        public ApplicationDbContext()
            : base("petcare", throwIfV1Schema: false)
            //: base("MyConnectionString") 
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<WebApplication1.Models.AdvertisementModel> AdvertisementModels { get; set; }
    }
}