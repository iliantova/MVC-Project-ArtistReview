﻿namespace ArtistReview.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            return this.View();
        }
    }
}