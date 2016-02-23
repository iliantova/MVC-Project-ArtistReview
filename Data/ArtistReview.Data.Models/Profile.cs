namespace ArtistReview.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Common.Models;

    public class Profile : BaseModel<int>
    {
        public Profile()
        {
            this.Images = new HashSet<Image>();
        }

       // [Required]
        [MinLength(3)]
        [MaxLength(2000)]
        public string Description { get; set; }

        public string Site { get; set; }

        public string FaceBook { get; set; }

        public string Contact { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
