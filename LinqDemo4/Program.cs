using System.Xml.Linq;

namespace LinqDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>() { "One", "Two", "Three", "Four", "Five", "Six" };

            XDocument doc = XDocument.Load("XMLFile1.xml");

            // get all short words

            // Linq to Objects
            //var shortWords = from word in list
            //                 where word.Length <= 3
            //                 select word;

            // Linq to XML
            var shortWords = from word in doc.Descendants("word")
                             where word.Value.Length <= 3
                             select word.Value;

            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }

        }
    }
}
