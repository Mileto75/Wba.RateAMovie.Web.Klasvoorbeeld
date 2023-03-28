using Microsoft.EntityFrameworkCore;
using Wba.RateAMovie.Core.Entities;

namespace Wba.RateAMovie.Web.Data
{
    public class MovieContext : DbContext
    {
        //define database table
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<ActorMovie> ActorMovie { get; set; }
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent configurations
            //Movie
            modelBuilder.Entity<Movie>()
                .Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(200);
            //User
            modelBuilder.Entity<User>()
                .Property(m => m.Username)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<User>()
                .Property(m => m.Firstname)
                .HasMaxLength(100);
            modelBuilder.Entity<User>()
                .Property(m => m.Lastname)
                .HasMaxLength(100);
            //rating ondelete
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.User)
                .WithMany(u => u.Ratings)
                .OnDelete(DeleteBehavior.SetNull);
            //configure foreignkeys
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Ratings)
                .HasForeignKey(r => r.RatedMovieId);
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.User)
                .WithMany(u => u.Ratings)
                .HasForeignKey(r => r.ReviewerId);
            //configure composite key for actorMovie
            modelBuilder.Entity<ActorMovie>()
                .HasKey(am => new { am.MovieId, am.ActorId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
