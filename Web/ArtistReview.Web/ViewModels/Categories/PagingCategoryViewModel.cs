using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtistReview.Web.ViewModels.Categories
{
    public class PagingCategoryViewModel
    {
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public IEnumerable<DetailsCategoryViewModel> Categories { get; set; }
    }
}