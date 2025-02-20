using EFDemoApp.Models;

namespace EFDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductsDbContext db = new ProductsDbContext();

            CoolProductsDbContext db = new CoolProductsDbContext();
            var products = db.Products;

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }

            // increase 100 to all products price

            //var allProducts = db.Products.ToList();
            //foreach (var item in allProducts)
            //{
            //    item.Price += 100;
            //}

            //db.SaveChanges();

            // SQL: update products set price = price + 100;
            //db.Database.ExecuteSqlRaw("update products set price = price + 1");

        }

        //private static void Loadings(ProductsDbContext db)
        //{
        //    var result = from p in db.Products//.Include("Category")      //.Include(p => p.Category)
        //                 select p;


        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item.Name + " " + item.Price + " " + item.Category.CategoryName);
        //    }
        //}

        //private static void GetProductNameAndCategoryName(ProductsDbContext db)
        //{
        //    // Get all products name and category name
        //    var result = from p in db.Products
        //                 select new { PName = p.Name, CName = p.Category.CategoryName };

        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item.PName + "\t" + item.CName);
        //    }
        //}

        //private static void NewProductWithOldCat(ProductsDbContext db)
        //{
        //    // get the existing category
        //    var cat = db.Categories.Find(1);
        //    Product p = new Product { Name = "I Phone", Brand = "Apple", Price = 90000, Category = cat };

        //    db.Products.Add(p);
        //    db.SaveChanges();
        //}

        //private static void NewProductNewCategory(ProductsDbContext db)
        //{
        //    Category category = new Category { CategoryName = "Mobiles", CategoryDescription = "Premium Mobiles" };

        //    Product product = new Product { Name = "Galaxy S22", Brand = "Samsung", Price = 90000, Category = category };


        //    db.Products.Add(product);
        //    // db.Categories.Add(category);
        //    db.SaveChanges();
        //}

        //private static void Delete()
        //{
        //    // Get the object to delete
        //    ProductsDbContext db = new ProductsDbContext();
        //    var productToDelete = db.Products.Find(3);
        //    db.Products.Remove(productToDelete);
        //    db.SaveChanges();
        //}

        //private static void Update()
        //{
        //    // Get the product to edit
        //    ProductsDbContext db = new ProductsDbContext();
        //    var productToEdit = (from p in db.Products
        //                         where p.ProductId == 1
        //                         select p).FirstOrDefault();

        //    var productToUpdate = db.Products.Find(1);

        //    productToEdit.Price = 79999;
        //    db.SaveChanges();
        //}

        //private static void Select()
        //{
        //    ProductsDbContext db = new ProductsDbContext();

        //    var products = from p in db.Products
        //                   select p;

        //    foreach (var product in products)
        //    {
        //        Console.WriteLine(product.Name);
        //    }
        //}

        //private static void Save()
        //{
        //    // save product data
        //    Product p = new Product();
        //    //p.ProductId = 1; 
        //    p.Name = "Samsumg S 24+";
        //    p.Price = 99999;

        //    ProductsDbContext db = new ProductsDbContext();
        //    db.Products.Add(p);
        //    db.SaveChanges(); // Create/Update/Delete
        //}
    }
}
