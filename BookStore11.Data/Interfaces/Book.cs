namespace BookStore11.Data.Interfaces
{
    public class Book
    {
        public int Id { get; internal set; }
        public string Title { get; internal set; }
        public string Author { get; internal set; }
        public int PublicationYear { get; internal set; }
        public string CallNumber { get; internal set; }
    }
}