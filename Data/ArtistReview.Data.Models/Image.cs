﻿using ArtistReview.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistReview.Data.Models
{
    public class Image : BaseModel<int>
    {
        public Image()
        {
            this.Users = new HashSet<ApplicationUser>();
            this.Profils = new HashSet<Profil>();
            this.Events = new HashSet<Event>();
        }
        public string ImagePath { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

        public virtual ICollection<Profil> Profils { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
