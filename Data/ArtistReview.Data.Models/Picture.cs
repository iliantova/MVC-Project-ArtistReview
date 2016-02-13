namespace ArtistReview.Data.Models
{
    using ArtistReview.Data.Common.Models;
    using System.Collections.Generic;
    public class Picture : BaseModel<int>
    {
        public Picture()
        {
            this.Events = new HashSet<Event>();
            this.Profils = new HashSet<Profil>();
            this.Categoty = new HashSet<Category>();
        }
        public string ImagePath { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Event> Events { get; set; }

        public virtual ICollection<Profil> Profils { get; set; }

        public virtual ICollection<Category> Categoty { get; set; }
    }
}
