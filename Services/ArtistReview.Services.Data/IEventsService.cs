using ArtistReview.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistReview.Services.Data
{
    public interface IEventsService
    {
        IQueryable<Event> GetAll();

        Event GetById(int id);

        IQueryable<Event> GetByCategory(int id);
    }
}
