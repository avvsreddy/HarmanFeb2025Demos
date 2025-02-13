using System.Xml.Linq;

namespace LinqToXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xml = XDocument.Load("XMLFile1.xml");

            // select all titles and display

            var titles = from book in xml.Descendants("book")
                         where double.Parse(book.Element("price").Value) <= 5
                         select book.Element("title").Value;


            // select title and price then display

            var titlesNprice = from book in xml.Descendants("book")
                               where double.Parse(book.Element("price").Value) <= 5
                               select new
                               {
                                   Title = book.Element("title").Value,
                                   Price = double.Parse(book.Element("price").Value),
                                   Author = book.Element("author").Value
                               };


            foreach (var title in titlesNprice)
            {
                Console.WriteLine(title.Title);
                Console.WriteLine();
                Console.WriteLine(title.Price);
                Console.WriteLine(title.Author);
            }
        }
    }

    //class TitleAndPrice
    //{
    //    public string Title { get; set; }
    //    public double Price { get; set; }
    //}
}
