namespace ArtistReview.Data.SeedMethods
{
    using System;
    using System.Collections.Generic;
    using ArtistReview.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class SeedUsers
    {
        public static List<ApplicationUser> Users;
        public static ApplicationUser Admin;

        public static void SeedDbUsers(ApplicationDbContext context, List<Image> userImages)
        {
            Users = new List<ApplicationUser>();

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!roleManager.RoleExists("Admin"))
            {
                roleManager.Create(new IdentityRole("Admin"));
            }

            var admin = new ApplicationUser
            {
                UserName = "admin@artist.com",
                PasswordHash = new PasswordHasher().HashPassword("admin"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FirstName = "Admin",
                LastName = "Adminski",
                Email = "admin@artist.com"
            };

            Admin = admin;
            userManager.Create(admin);
            userManager.AddToRole(admin.Id, "Admin");

            if (!roleManager.RoleExists("User"))
            {
                roleManager.Create(new IdentityRole("User"));
            }

            for (int i = 0; i < 20; i++)
            {
                var user = new ApplicationUser
                {
                    UserName = "user" + i + "@artist.com",
                    PasswordHash = new PasswordHasher().HashPassword("user" + i),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    FirstName = "FirstName" + i,
                    LastName = "LastName" + i,
                    Email = "user" + i + "@artist.com",
                    Images = userImages[0]
                };

                userManager.Create(user);
                userManager.AddToRole(admin.Id, "User");
                Users.Add(user);
            }
        }

        public static void SeedDbProfil(ApplicationDbContext context, List<Image> artImg, List<Category> listCategory, List<ApplicationUser> userList)
        {
            Random rnd = new Random();

            for (int i = 0; i < userList.Count; i++)
            {
                var profil = new Profil()
                {
                    Description = "ArtistReview Profils",
                    Category = listCategory[rnd.Next(0, listCategory.Count)],
                    User = userList[i],
                    Contact = "Telerik Academy",
                    Sait = "http://telerikacademy.com/",
                    FaceBook = "https://www.facebook.com/TelerikAcademy/?fref=ts"
                };
                for (int j = 0; j < 5; j++)
                {
                    profil.Images.Add(artImg[rnd.Next(0, artImg.Count)]);
                }

                context.Profils.Add(profil);
                context.SaveChanges();
            }
        }
    }
}
