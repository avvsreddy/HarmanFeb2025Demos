namespace DelegateDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // client dev
            Account acc1 = new Account(); // open

            acc1.alert += Notification.SendSMS; // Subscription
            acc1.alert += Notification.SendEmail; // Subscribe
            acc1.alert -= Notification.SendSMS; // Unsubscribe
            acc1.alert += Notification.SendWhatsApp;

            //acc1.Subscribe(Notification.SendSMS);
            //acc1.Subscribe(Notification.SendEmail);

            acc1.Deposit(10000); // tansaction
            //acc1.alert("Your account has been credited $99999999999999.99");
            Console.WriteLine(acc1.Balance);
            //acc1.Withdraw(1000); // transaction
            Console.WriteLine(acc1.Balance);
        }
    }

    // backend dev 1

    public delegate void AlertDelegate(string msg);
    class Account //SRP // OCP
    {
        public int Balance { get; private set; }
        public event AlertDelegate alert;// = new AlertDelegate(Notification.SendSMS);

        //public void Subscribe(AlertDelegate alert)
        //{
        //    this.alert += alert;
        //}

        //public void Unsubscribe(AlertDelegate alert)
        //{
        //    this.alert -= alert;
        //}

        public void Deposit(int amount) // SRP
        {
            Balance += amount;
            // write code to send sms
            //Notification.SendSMS($"Your account has been credited Rs. {amount}");
            if (alert != null)
            {
                alert($"Your account has been credited Rs. {amount}");
            }
        }
        public void Withdraw(int amount)
        {
            Balance -= amount;
            // write code to send sms
            //Notification.SendSMS($"Your account has been debited Rs. {amount}");
            if (alert != null)
            {
                alert($"Your account has been debited Rs. {amount}");
            }
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
        public static void SendEmail(string msg)
        {
            // write code to send sms
            Console.WriteLine($"EMail: {msg}");
        }

        public static void SendWhatsApp(string msg)
        {
            // write code to send sms
            Console.WriteLine($"WhatsApp: {msg}");
        }
    }
}
