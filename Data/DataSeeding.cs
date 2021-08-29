using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Entity;

namespace MovieApp.Data
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scop = app.ApplicationServices.CreateScope();
            var context = scop.ServiceProvider.GetService<MovieContext>();
            context.Database.Migrate();
            var genres = new List<Genre>()
                        {
                                new Genre(){ Name="Macera"},
                                new Genre(){ Name="Romantic"},
                                new Genre(){ Name="Aksiyon"},
                                new Genre(){ Name="Savaş"},
                                new Genre(){ Name="Komedi"},
                                new Genre(){ Name="Aile"},
                                new Genre(){Name="Genşlik"}
                        };

            var movies = new List<Movie>()
                            {
                                 new Movie {
                                Name="Hard Kill",
                                Description="The work of billionaire tech CEO Donovan Chalmers is so valuable that he hires mercenaries to protect it, and a terrorist group kidnaps his daughte...",
                                //Players=new string[] { "Bruce Willis", "Jesse Metcalfe"},
                                ImageUrl="6.jpg",
                                 Genres=new List<Genre>(){genres[0],new Genre(){Name="Yeni Tür"},genres[1]}
                            },
                                new Movie {
                                Name="Jiu Jitsu",
                                Description="Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of alien invaders. But when a celebrated war hero goes down in defeat, the fate of the planet and mankind hangs in the balance.",
                                //Players=new string[] { "Nicolas Cage", "Alain Moussi"},
                                ImageUrl="1.jpg",
                                Genres=new List<Genre>(){genres[0],genres[1]}
                            },
                            new Movie {
                                Name="Fatman",
                                Description="A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a neglected and precocious 12 year old, hires a hit m...",
                                //Players=new string[] { "Mel Gibson", "Walton Goggins","Michelle Lan"},
                                ImageUrl="2.jpg",
                                Genres=new List<Genre>(){genres[4],genres[1]}
                            },
                            new Movie {
                                Name="The Dalton Gang",
                                Description="When their brother Frank is killed by an outlaw, brothers Bob Dalton, Emmett Dalton and Gray Dalton join their local sheriff's department. When the...",
                                //Players=new string[] { "oyuncu 1","oyuncu 2"},
                                ImageUrl="3.jpg",
                                Genres=new List<Genre>(){genres[1],genres[1]}
                            },
                                new Movie {
                                Name="Tenet",
                                Description="Armed with only one word - Tenet - and fighting for the survival of the entire world, the Protagonist journeys through a twilight world of internat...",
                                //Players=new string[] { "Robert Pattinson", "Elizabeth Debicki"},
                                ImageUrl="4.jpg",
                                Genres=new List<Genre>(){genres[3],genres[2]}
                            },
                            new Movie {
                                Name="The Craft: Legacy",
                                Description="An eclectic foursome of aspiring teenage witches get more than they bargained for as they lean into their newfound powers.",
                                //Players=new string[] { "Cailee Spaeny", "Zoey Luna"},
                                ImageUrl="5.jpg",
                                Genres=new List<Genre>(){genres[2],genres[1]}
                            },
                           };
            var users = new List<User>()
            {
                new User(){UserName="Usera",Email="Usera@gmail.com",Password="123",ImageUrl="person1.jpg"},
                new User(){UserName="Userb",Email="Userb@gmail.com",Password="123",ImageUrl="person2.jpg"},
                new User(){UserName="Userc",Email="Userc@gmail.com",Password="123",ImageUrl="person3.jpg"},
                new User(){UserName="Userd",Email="Userb@gmail.com",Password="123",ImageUrl="person4.jpg"}
            };
            var people = new List<Person>()
            {
                new Person(){PersonName="personnel 1",Byografhy="tanitim 1",User=users[0]},
                new Person(){PersonName="personel 2",Byografhy="tanitim 2",User=users[1]}
            };
            var crews = new List<Crew>()
            {
                new Crew(){Movie=movies[0],Person=people[0],Job="Yönetmen"},
                new Crew(){Movie=movies[0],Person=people[1],Job="Yönetmen Yard"},
            };
            var casts = new List<Cast>()
            {
                new Cast() {Movie=movies[0], Person=people[0],Name="Oyuncu Adı 1",Character="Karakter 1"},
                new Cast() {Movie=movies[0], Person=people[1],Name="Oyuncu Adı 2",Character="Karakter 2"},
            };




            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Movies.Count() == 0)
                {
                    context.Movies.AddRange(movies);
                }
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(genres);
                }
                if (context.Users.Count() == 0)
                {
                    context.Users.AddRange(users);
                }
                if (context.People.Count() == 0)
                {
                    context.People.AddRange(people);
                }
                if (context.Crews.Count() == 0)
                {
                    context.Crews.AddRange(crews);
                }
                if (context.Casts.Count() == 0)
                {
                    context.Casts.AddRange(casts);
                }
                context.SaveChanges();

            }
        }
    }
}