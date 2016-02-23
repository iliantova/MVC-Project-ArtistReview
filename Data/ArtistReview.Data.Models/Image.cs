namespace ArtistReview.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ArtistReview.Data.Common.Models;

    public class Image : BaseModel<int>
    {
        public Image()
        {
            this.Users = new HashSet<ApplicationUser>();
            this.Profils = new HashSet<Profile>();
            this.Events = new HashSet<Event>();
            this.Category = new HashSet<Category>();
        }

        public string ImagePath { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

        public virtual ICollection<Profile> Profils { get; set; }

        public virtual ICollection<Event> Events { get; set; }

        public virtual ICollection<Category> Category { get; set; }
    }
}
