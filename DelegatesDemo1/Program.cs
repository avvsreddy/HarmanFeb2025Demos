namespace DelegatesDemo1
{

    //class MyDelegate : Delegate
    //{

    //}

    delegate void MyDelegate(string str); // Step1: Declaration

    internal class Program
    {
        static void Main(string[] args)
        {
            // call directly
            // name
            // sign
            // 
            //Greeting("Good Morning");

            // indirectly
            //Delegate obj = new Delegate();
            //MyDelegate obj = new MyDelegate(Greeting);
            Program p = new Program();
            MyDelegate obj = new MyDelegate(p.Hello); // Step 2: Instantiation and initialization
            obj += Greeting; // Subscription
            obj -= p.Hello; // Unsubscription
            //obj.Invoke("Hello"); // Step 3: Invocation
            obj("helloooo");
        }

        static void Greeting(string text)
        {
            Console.WriteLine($"Greeting: {text}");
        }

        void Hello(string text)
        {
            Console.WriteLine($"Hello {text}");
        }
    }
}
