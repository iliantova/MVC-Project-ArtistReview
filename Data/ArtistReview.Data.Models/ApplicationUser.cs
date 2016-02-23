namespace ArtistReview.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Events = new HashSet<Event>();
            this.Profil = new HashSet<Profile>();
            this.Calendar = new HashSet<Calendar>();
        }

        [MinLength(2)]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Range(0, 120)]
        public int Age { get; set; }

         public virtual Image Images { get; set; }


        public virtual ICollection<Calendar> Calendar { get; set; }

        public virtual ICollection<Profile> Profil { get; set; }

        public virtual ICollection<Event> Events { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }
    }
}
