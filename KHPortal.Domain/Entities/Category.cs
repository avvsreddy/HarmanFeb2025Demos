namespace KHPortal.Domain.Entities
{
    public class Category // Entity Class
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
