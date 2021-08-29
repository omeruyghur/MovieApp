namespace MovieApp.Entity
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string Byografhy { get; set; }
        public string Imdb { get; set; }
        public string HomePage { get; set; }
        public string PlaceOfBirth { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }

}