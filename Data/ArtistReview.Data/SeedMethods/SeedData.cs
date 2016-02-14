using ArtistReview.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistReview.Data.SeedMethods
{
    public class SeedData
    {
        public static List<Category> categoryList;
        public static List<Event> eventsList;


        public static void SeedDbCategory(ApplicationDbContext context, List<Image> categoryImg)
        {
            categoryList = new List<Category>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                var category = new Category()
                {
                    Name = "Category" + i,
                    Description = "ArtistReview Category",
                    Image = categoryImg[rnd.Next(0, categoryImg.Count)]
                };

                context.Categories.Add(category);
                context.SaveChanges();
                categoryList.Add(category);
            }

        }

        public static void SeedDbEvents(ApplicationDbContext context, List<Image> artImg, List<Category> listCategory,  List<ApplicationUser> userList)
        {
            eventsList = new List<Event>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                var events = new Event()
                {
                    Name = "Events" + i,
                    Description = "ArtistReview Events",
                    Image = artImg[rnd.Next(0, artImg.Count)],
                    Category = listCategory[rnd.Next(0, listCategory.Count)],
                    User = userList[rnd.Next(0, userList.Count)],
                    BeginEvent = DateTime.UtcNow.AddDays(i)
                };

                context.Events.Add(events);
                context.SaveChanges();
                eventsList.Add(events);
            }

        }

        public static void SeedDbCalendar(ApplicationDbContext context, List<Event> listEvent, List<ApplicationUser> userList)
        {
            eventsList = new List<Event>();
            Random rnd = new Random();

            for (int i = 0; i < userList.Count; i++)
            {
                var calendar = new Calendar()
                {
                    User = userList[i]
                };
                for (int l = 0; l < 5; l++)
                {
                    calendar.Events.Add(listEvent[rnd.Next(0, listEvent.Count)]);
                }

                context.Calendars.Add(calendar);
                context.SaveChanges();
            }

        }
    }
}
