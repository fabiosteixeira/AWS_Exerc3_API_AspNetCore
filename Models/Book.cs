namespace LibraryAPI.Models
{
    public class Book {
        public long Id { get; set; }
        public long Isbn { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Editor { get; set; }
    }
}