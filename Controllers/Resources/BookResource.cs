namespace MyTestApp.Controllers.Resources
{
    public class BookResource
    {
      

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ReleaseDate { get; set; }
        public int AuthorId { get; set; }
        public string Author { get; set; } 
    }
}