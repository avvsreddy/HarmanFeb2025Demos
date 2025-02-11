using SimpleMathClassLibrary;
namespace ExceptionsDemo1
{
    internal class Program // UI
    {
        static void Main(string[] args) // UI   SRP
        {
            // Accept 2 ints, find sum and display ... 
            // Non-Zero, Non-Negative, Non-Odd

            while (true)
            {
                try
                {
                    int fno, sno, sum;
                    Console.Write("Enter First Number: ");
                    fno = int.Parse(Console.ReadLine());
                    Console.Write("Enter Second Number: ");
                    sno = int.Parse(Console.ReadLine());

                    // open db conn
                    // write / read
                    // ex 
                    // close db conn

                    //sum = fno + sno; // BL
                    sum = Calculator.FindSum(fno, sno);

                    Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Enter only numbers");
                }
                //catch (OverflowException ex)
                //{
                //    Console.WriteLine("Enter only small numbers");
                //}

                catch (Exception ex) // Catch All Block
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // resource management
                    // close the db
                    Console.WriteLine("I am in finally");
                }
            }
        }


    }



}
