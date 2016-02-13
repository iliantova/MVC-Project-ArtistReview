namespace ArtistReview.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;
    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //// Schools = new List<School>();
            //var fileName = "picture.jpg";
            //string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension  
            //string myfile = fileName; //appending the name with id  
            //                          // store the file inside ~/project folder(Img)  
            //var path = Path.Combine(System.Web.Hosting.HostingEnvironment.MapPath("~/Img"), myfile);
            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //for (int i = 0; i < 2; i++)
            //{
            //    var picture = new Picture()
            //    {
            //        ImagePath = path,
            //        Name = name
            //    };
            //    context.Pictures.Add(picture);
            //    context.SaveChanges();
            //    //Schools.Add(school);
            //}

            //var user = new ApplicationUser
            //{
            //    UserName = "user" + "p" + "@artist.com",
            //    PasswordHash = new PasswordHasher().HashPassword("user" + "p"),
            //    SecurityStamp = Guid.NewGuid().ToString("D"),
            //    FirstName = "FirstName" + "P",
            //    LastName = "LastName" + "P",
            //    Email = "user" + "p" + "@artist.com",
            //    PictureId = 1
            //};

            //userManager.Create(user);
        }
    }
}