namespace LinqDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // get all evens

            //3
            var evens = (from number in numbers
                         where IsEven(number)
                         select number).ToList();

            //2
            numbers.Add(10);

            //4
            //foreach (var e in evens) { Console.WriteLine(e); }
        }


        public static bool IsEven(int a)
        {
            Console.WriteLine("In IsEven");
            return a % 2 == 0;
        }

    }
}
