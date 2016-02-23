namespace ArtistReview.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using SeedMethods;
 
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {

            SeedImages.SeedDbImages(context);

            SeedUsers.SeedDbUsers(context, SeedImages.userImg);

            SeedData.SeedDbCategory(context, SeedImages.categoryImg);

            SeedUsers.SeedDbProfil(context, SeedImages.artImg, SeedData.categoryList, SeedUsers.Users);

            SeedData.SeedDbEvents(context, SeedImages.artImg, SeedData.categoryList, SeedUsers.Users);

            SeedData.SeedDbCalendar(context, SeedData.eventsList, SeedUsers.Users);
        }
    }
}
