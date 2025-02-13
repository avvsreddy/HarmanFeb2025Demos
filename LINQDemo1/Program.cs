namespace LINQDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // get all even numbers and store in a separate array then display


            // sql: select number from numbers where number mod 2 = 0;
            // table: numbers
            // col: number

            // LINQ to Objects

            // Linq Expression
            var evenNumbers = from number in numbers where number % 2 == 0 select number;

            // Linq Statement / Extension methods

            var evenNumbers2 = numbers.Where(n => n % 2 == 0).Select(n => n);
            var evenNumbers3 = numbers.Where(IsEven).Select(n => n);


            //int[] evens[numbers.Length];
            List<int> evens = new List<int>();

            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                    evens.Add(i);
            }

            foreach (int i in evens)
            {
                Console.WriteLine(i);
            }

        }

        public static bool IsEven(int n)
        {
            return (n % 2 == 0);
        }
    }
}
