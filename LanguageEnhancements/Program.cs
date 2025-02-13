namespace LanguageEnhancements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linq supported language enhancements
            //1. Local variable type inference

            //var a = 0;
            //var str = "hello";

            //Dictionary<int, List<string>> keyValuePairs1 = new Dictionary<int, List<string>>();


            //var keyValuePairs2 = new Dictionary<int, List<string>>();

            //var result = SomeMethod();

            // 2. Object Initialization Syntax

            Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "I Phone";
            p1.Price = 96000;
            p1.Brand = "Apple";
            //Product p2 = new Product(2, "Galaxy s25", 90000, "Samsung");
            Product p2 = new Product { Id = 2, Name = "Galaxy s25", Price = 90000, Brand = "Samsung" };
            //Product p3 = new Product(3, "Galaxy Watch");
            Product p3 = new Product { Id = 3, Name = "Galaxy Watch" };

            //3 Anonymous Types

            var emp = new { Id = 101, Name = "RAmesh", Salary = 670000 };
            Console.WriteLine(emp.Name);
            //emp.Name = "sdfsdf";

            //4. Extension Methods

            string data = "some confidential data";
            string upperData = data.ToUpper();
            string encryptData1 = data.Encrypt();
            string encryptData2 = Util.Encrypt(data);

            int x = 100;
            x.Encrypt();

            Program prg = new Program();
            prg.Encrypt();
        }
    }


    //class MyString : String
    //{

    //}

    public static class Util
    {
        public static string Encrypt(this Object data)
        {
            return "3434SDFSDF@##^%^#$TSFSDFGSDFGD@$%#$^#$";
        }
    }


    //class Employee
    //{
    //    public int Id { get; set; }

    //    public string Name { get; set; }
    //    public int Salary { get; set; }
    //}

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }

        //public Product()
        //{

        //}
        //public Product(int id, string name, int price, string brand):this(id,name)
        //{
        //    //this.Id = id;
        //    //this.Name = name;
        //    this.Price = price;
        //    this.Brand = brand;
        //}
        //public Product(int id, string name)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //}
    }
}
