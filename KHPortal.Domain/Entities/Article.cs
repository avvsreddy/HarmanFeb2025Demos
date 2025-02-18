namespace KHPortal.Domain.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string ArticleUrl { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public bool IsApproved { get; set; }
        public string PostedBy { get; set; }
        public DateTime DateSubmited { get; set; }

    }
}
