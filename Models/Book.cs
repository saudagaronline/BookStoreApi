namespace BookStoreApi.Models
{
    //Make A Book Class
    public class Book
    {
        public int id { get; set; }
        public string? BookName { get; set; }
        public string? Category { get; set; }
        public long Price { get; set; }
        public string? Author { get; set; }
    }}
