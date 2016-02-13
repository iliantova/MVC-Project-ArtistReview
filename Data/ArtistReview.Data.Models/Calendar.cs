namespace ArtistReview.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using ArtistReview.Data.Common.Models;

    public class Calendar : BaseModel<string>
    {
        public Calendar()
        {
            this.Events = new HashSet<Event>();
        }

        [Key, ForeignKey("User")]
        public new string Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
