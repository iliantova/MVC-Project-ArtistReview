namespace ArtistReview.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Common.Models;

    public class Event : BaseModel<int>
    {
        //[Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        //[Required]
        [MinLength(3)]
        [MaxLength(500)]
        public string Description { get; set; }

        public int ImageId { get; set; }

        [ForeignKey("ImageId")]
        public virtual Image Image { get; set; }

        //[Required]
        public DateTime? BeginEvent { get; set; }

        public DateTime? EndEvent { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
        public object Images { get; set; }
    }
}
