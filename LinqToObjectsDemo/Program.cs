namespace LinqToObjectsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Get all products name and display
            var result1 = from p in Product.GetProducts()
                          select new { Name = p.Name, Rate = p.Price, CName = p.Category.Name };

            //foreach (var p in result1) { Console.WriteLine(p.Name + " " + p.Rate + " " + p.CName); }

            //2. Get expensive product name
            var expensiveProduct = (from p in Product.GetProducts()
                                    orderby p.Price descending
                                    select p.Name).FirstOrDefault();
            //Console.WriteLine(expensiveProduct);

            //3. get the total of all product price

            var totalSum = (from p in Product.GetProducts()
                            select p.Price).Sum();

            Console.WriteLine(totalSum);
        }
    }
}

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public int Price { get; set; }
    public bool InStock { get; set; }
    public string Country { get; set; }
    public Category Category { get; set; }

    public static List<Product> GetProducts()
    {
        List<Category> categories = new List<Category>
        {
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Home Appliances" },
            new Category { Id = 3, Name = "Clothing" }
        };

        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Brand = "Dell", Price = 800, InStock = true, Country = "USA", Category = categories[0] },
            new Product { Id = 2, Name = "Smartphone", Brand = "Samsung", Price = 700, InStock = true, Country = "South Korea", Category = categories[0] },
            new Product { Id = 3, Name = "Washing Machine", Brand = "LG", Price = 500, InStock = false, Country = "Germany", Category = categories[1] },
            new Product { Id = 4, Name = "T-Shirt", Brand = "Nike", Price = 40, InStock = true, Country = "Vietnam", Category = categories[2] },
            new Product { Id = 5, Name = "Refrigerator", Brand = "Whirlpool", Price = 900, InStock = true, Country = "USA", Category = categories[1] }
        };
        return products;
    }
}

class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
}