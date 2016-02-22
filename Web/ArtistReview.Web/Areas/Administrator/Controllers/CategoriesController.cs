using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtistReview.Web.Areas.Administrator.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Administrator/Categories
        public ActionResult Index()
        {
            return View();
        }

    }
}