namespace pickmeamovieAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public List<string> Quotes { get; set; } = new List<string>();
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
