using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtistReview.Web.ViewModels.Profiles
{
    public class PaginProfileViewModel
    {
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public IEnumerable<DetailsProfileViewModel> Profiles { get; set; }
    }
}