namespace ArtistReview.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SeedMethods;
    using System.IO;
    using Models;
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {

            //var fileName = "images1.jpg";
            //string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension  
            //string myfile = fileName; //appending the name with id  
            //                          // store the file inside ~/project folder(Img)  
            //var path = Path.Combine(System.Web.Hosting.HostingEnvironment.MapPath("~/proba"), myfile);
            //var picture = new Image()
            //{
            //    ImagePath = path,
            //    Name = name
            //};
            ////picture.Name = name + picture.Id;
            //context.Images.Add(picture);
            //context.SaveChanges();

            //path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath.ToString();
            //picture = new Image()
            //{
            //    ImagePath = path,
            //    Name = name
            //};
            ////picture.Name = name + picture.Id;
            //context.Images.Add(picture);
            //context.SaveChanges();
            ////categoryImg.Add(picture);
            ////if (context.Users.Any())
            ////{
            ////    return;
            ////}

            SeedImages.SeedDbImages(context);

            SeedUsers.SeedDbUsers(context, SeedImages.userImg);

            SeedData.SeedDbCategory(context, SeedImages.categoryImg);

            SeedUsers.SeedDbProfil(context, SeedImages.artImg, SeedData.categoryList, SeedUsers.Users);

            SeedData.SeedDbEvents(context, SeedImages.artImg, SeedData.categoryList, SeedUsers.Users);

            SeedData.SeedDbCalendar(context, SeedData.eventsList, SeedUsers.Users);
        }
    }
}
