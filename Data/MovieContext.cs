using Microsoft.EntityFrameworkCore;
using MovieApp.Entity;

namespace MovieApp.Data
{
    public class MovieContext : DbContext
    {
        //1.baglantı şekli
        //appstting içersinde connection ayar yapılır
        // startup içersinde ayar yapılır
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Crew> Crews { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     //Fluen Api Tanımlamaları
        //     modelBuilder.Entity<Movie>().Property(b => b.Name).IsRequired();
        //     modelBuilder.Entity<Movie>().Property(b => b.Name).HasMaxLength(50);
        //     modelBuilder.Entity<Movie>().Property(b => b.Description).IsRequired();
        //     modelBuilder.Entity<Movie>().Property(b => b.Description).HasMaxLength(1000);
        //     modelBuilder.Entity<Movie>().Property(b => b.ImageUrl).IsRequired();


        //     modelBuilder.Entity<Genre>().Property(b => b.Name).IsRequired();
        //     modelBuilder.Entity<Genre>().Property(b => b.Name).HasMaxLength(20);

        //     modelBuilder.Entity<User>().Property(b => b.UserName).IsRequired();
        //     modelBuilder.Entity<User>().Property(b => b.Email).IsRequired();
        //     modelBuilder.Entity<User>().Property(b => b.Password).IsRequired();
        //     modelBuilder.Entity<User>().Property(b => b.ImageUrl).IsRequired();


        //     modelBuilder.Entity<Person>().Property(b => b.PersonName).IsRequired();
        //     modelBuilder.Entity<Person>().Property(b => b.Byografhy).IsRequired();
        //     modelBuilder.Entity<Person>().Property(b => b.Byografhy).HasMaxLength(500);
        //     modelBuilder.Entity<Person>().Property(b => b.Imdb).IsRequired();

        //     modelBuilder.Entity<Cast>().Property(b => b.Name).IsRequired();



        // }


        //2. ALternatip baglantı
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Data Source=MovieDb");
        // }
    }
}