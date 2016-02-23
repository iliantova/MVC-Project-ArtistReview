namespace ArtistReview.Web.ViewModels.Events
{
    using System.Collections.Generic;
    public class EventsViewModel
    {
        public IEnumerable<DetailsEventViewModel> Events { get; set; }
    }
}