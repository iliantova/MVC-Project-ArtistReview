namespace ArtistReview.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Common.Models;

    public class Profil : BaseModel<string>
    {
        public Profil()
        {
            this.Pictures = new HashSet<Picture>();
        }

        [Required]
        [MinLength(3)]
        [MaxLength(2000)]
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Key, ForeignKey("User")]
        public new string Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
