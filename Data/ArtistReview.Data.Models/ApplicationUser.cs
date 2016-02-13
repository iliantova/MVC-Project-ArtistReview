namespace ArtistReview.Data.Models
{
    using System.Collections.Generic;    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
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
        }

        [MinLength(2)]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Range(0, 120)]
        public int Age { get; set; }

        public int PictureId { get; set; }

        [ForeignKey("PictureId")]
        public virtual Picture Picture { get; set; }

        // [ForeignKey("Profil")]
        // public int ProfilId { get; set; }
        public virtual Profil Profil { get; set; }

        // [ForeignKey("Calendar")]
        // public int CalendarId { get; set; }
        public virtual Calendar Calendar { get; set; }

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
