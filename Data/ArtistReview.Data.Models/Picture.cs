namespace ArtistReview.Data.Models
{
    using ArtistReview.Data.Common.Models;
    using System.Collections.Generic;
    public class Picture : BaseModel<int>
    {
        public Picture()
        {
            this.Users = new HashSet<ApplicationUser>();
        }
        public string ImagePath { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
