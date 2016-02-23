namespace ArtistReview.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using ArtistReview.Data.Common.Models;

    public class Calendar : BaseModel<int>
    {
        public Calendar()
        {
            this.Events = new HashSet<Event>();
        }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
