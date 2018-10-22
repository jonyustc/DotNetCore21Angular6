namespace MyTestApp.Controllers.Resources
{
    public class PostResource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int BlogId { get; set; }
        public string BlogUrl { get; set; }
    }
}