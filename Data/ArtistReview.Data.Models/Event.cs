namespace ArtistReview.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Common.Models;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Event : BaseModel<int>
    {
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(500)]
        public string Description { get; set; }

        public int PictureId { get; set; }

        [ForeignKey("PictureId")]
        public virtual Picture Picture { get; set; }

        [Required]
        public DateTime BeginEvent { get; set; }

        public DateTime EndEvets { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
