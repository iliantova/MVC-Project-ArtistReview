using ArtistReview.Web.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtistReview.Web.ViewModels.Categories
{
    public class CategoryViewModel
    {
        public IEnumerable<DetailsCategoryViewModel> Categories { get; set; }
    }
}