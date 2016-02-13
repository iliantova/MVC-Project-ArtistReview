namespace ArtistReview.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using ArtistReview.Data.Models;
    using Common.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Joke> Jokes { get; set; }

        public IDbSet<JokeCategory> JokesCategories { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Profil>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Calendar>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<ApplicationUser>()
                .HasOptional(y => y.Profil)
                .WithRequired(x => x.User);

            modelBuilder.Entity<ApplicationUser>()
                .HasRequired(y => y.Calendar)
                .WithRequiredPrincipal(y => y.User);

            modelBuilder.Entity<Category>()
             .HasOptional(c => c.Picture)
             .WithOptionalPrincipal()
             .WillCascadeOnDelete(false);
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }
    }
}
