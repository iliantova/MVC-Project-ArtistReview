namespace ArtistReview.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Models;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Category : BaseModel<int>
    {
        public Category()
        {
            this.Events = new HashSet<Event>();
            this.Profils = new HashSet<Profil>();
        }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(500)]
        public string Description { get; set; }

        public int PictureId { get; set; }

        public virtual Picture Picture { get; set; }

        public virtual ICollection<Event> Events { get; set; }

        public virtual ICollection<Profil> Profils { get; set; }
    }
}
