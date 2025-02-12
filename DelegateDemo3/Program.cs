namespace DelegateDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // client dev
            Account acc1 = new Account(); // open
            acc1.Deposit(10000); // tansaction
            Console.WriteLine(acc1.Balance);
            acc1.Withdraw(1000); // transaction
            Console.WriteLine(acc1.Balance);
        }
    }

    // backend dev 1
    class Account //SRP // OCP
    {
        public int Balance { get; private set; }
        public void Deposit(int amount) // SRP
        {
            Balance += amount;
            // write code to send sms
            Notification.SendSMS($"Your account has been credited Rs. {amount}");
        }
        public void Withdraw(int amount)
        {
            Balance -= amount;
            // write code to send sms
            Notification.SendSMS($"Your account has been debited Rs. {amount}");
        }


    }

    // dev 2
    class Notification
    {
        public static void SendSMS(string msg)
        {
            // write code to send sms
            Console.WriteLine($"SMS: {msg}");
        }
    }
}
