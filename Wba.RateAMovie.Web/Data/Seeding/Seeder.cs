using Microsoft.EntityFrameworkCore;
using Wba.RateAMovie.Core.Entities;

namespace Wba.RateAMovie.Web.Data.Seeding
{
    public static class Seeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var companies = new Company[]
                {
                    new Company {Id = 1,Name = "Warner Bros" }
                };
            var movies = new Movie[]
            {
                new Movie {Id = 1,Title="Deadpool",CompanyId = 1},
            };
            var actors = new Actor[]
            {
                new Actor {Id = 1,Firstname="Ryan",Lastname="Reynolds"}
            };
            var directors = new Director[]
            {
                new Director {Id = 1,Firstname="Jacques",Lastname="Vermeire"}
            };
            var ratings = new Rating[]
            {
                new Rating{Id=1,RatedMovieId=1,ReviewerId=1,Score=5 }
            };
            var users = new User[]
            {
                new User{Id=1,Firstname="Jarno",Lastname="Caenepeel",Username="jarno.caenepeel@lotr.com" }
            };
            var actorMovie = new ActorMovie[]
                {
                    new ActorMovie{MovieId=1,ActorId=1}
                };
            //directors
            var movieDirectors = new[]
            {
                new{DirectorsId=1,MoviesId=1 }
            };
            //input data
            modelBuilder.Entity<Company>
                ().HasData(companies);
            modelBuilder.Entity<Movie>()
                .HasData(movies);
            modelBuilder.Entity<Actor>()
                .HasData(actors);
            modelBuilder.Entity<Director>()
                .HasData(directors);
            modelBuilder.Entity<User>()
                .HasData(users);
            modelBuilder.Entity<Rating>()
                .HasData(ratings);
            modelBuilder.Entity<ActorMovie>()
                .HasData(actorMovie);
            modelBuilder.Entity($"{nameof(Director)}{nameof(Movie)}")
                .HasData(movieDirectors);

        }
    }
}
