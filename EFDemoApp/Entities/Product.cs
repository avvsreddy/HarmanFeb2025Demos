namespace EFDemoApp.Entities
{
    // [Table("tbl_products")]
    public class Product // Entity Class
    {
        //[Key]
        public int ProductId { get; set; }
        //[Required]
        //[StringLength(50)]
        //[MaxLength(50)]
        //[Column("productname")]
        public string Name { get; set; }
        public int Price { get; set; }

        public string Brand { get; set; }
        //[NotMapped]
        //public int Profit { get; set;

        public virtual Category Category { get; set; }
        //[ForeignKey("Category")]
        //public int CategoryId { get; set; }
        public virtual List<Supplier> Suppliers { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public virtual List<Product> Products { get; set; }
    }

    public class Supplier : Person
    {
        //public int SupplierID { get; set; }



        public string GST { get; set; }
        public int Rating { get; set; }

        public virtual List<Product> Products { get; set; }
    }

    public abstract class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }

    public class Customer : Person
    {
        public int Discount { get; set; }
    }
}
