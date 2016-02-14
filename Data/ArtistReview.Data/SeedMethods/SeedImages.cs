namespace ArtistReview.Data.SeedMethods
{
    using System.Collections.Generic;
    using System.IO;
    using ArtistReview.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class SeedImages
    {
        public static List<Image> categoryImg;
        public static List<Image> userImg;
        public static List<Image> artImg;

        public static void SeedDbImages(ApplicationDbContext context)
        {
                categoryImg = new List<Image>();

            for (int i = 1; i <= 8; i++)
            {
                var fileName = "images" + i + ".jpg";
                string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension  
                string myfile = fileName; //appending the name with id  
                                          // store the file inside ~/project folder(Img)  
                var path = Path.Combine("~/Assets/Img", myfile);

                var picture = new Image()
                {
                    ImagePath = path
                };
                picture.Name = name + picture.Id;
                context.Images.Add(picture);
                context.SaveChanges();
                categoryImg.Add(picture);
            }

            userImg = new List<Image>();

            for (int i = 0; i < 1; i++)
            {
                var fileName = "userimages.jpg";
                string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension  
                string myfile = fileName; //appending the name with id  
                                          // store the file inside ~/project folder(Img)  
                var path = Path.Combine("~/Assets/UserImg", myfile);

                var picture = new Image()
                {
                    ImagePath = path
                };
                picture.Name = name + picture.Id;
                context.Images.Add(picture);
                context.SaveChanges();
                userImg.Add(picture);
            }

            artImg = new List<Image>();

            for (int i = 1; i <= 13; i++)
            {
                var fileName = "art" + i + ".jpg";
                string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension  
                string myfile = fileName; //appending the name with id  
                                          // store the file inside ~/project folder(Img)  
                var path = Path.Combine("~/Assets/ArtImg", myfile);

                var picture = new Image()
                {
                    ImagePath = path
                };
                picture.Name = name + picture.Id;
                context.Images.Add(picture);
                context.SaveChanges();
                artImg.Add(picture);
            }
        }
}
}
