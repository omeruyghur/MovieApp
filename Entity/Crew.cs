namespace MovieApp.Entity
{
    public class Crew
    {
        //yonetmen Tablosu
        //yonetmen oyuncu çoka çok
        public int CrewId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public string Job { get; set; }
    }
}