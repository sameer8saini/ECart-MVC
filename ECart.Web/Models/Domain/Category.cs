namespace ECart.Web.Models.Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UrlHandle { get; set; }
        public string FeaturedImageUrl { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
