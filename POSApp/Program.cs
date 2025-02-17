using System.Configuration;

namespace POSApp
{
    internal class Program // UI
    {
        static void Main(string[] args)
        {

            //TaxCalculatorFactory factory1 = new TaxCalculatorFactory();
            ITaxCalculatorStrategy calc1 = TaxCalculatorFactory.Instance.Create();

            Console.WriteLine($"factory1 {TaxCalculatorFactory.Instance.GetHashCode()}");

            //TaxCalculatorFactory factory2 = new TaxCalculatorFactory();
            ITaxCalculatorStrategy calc2 = TaxCalculatorFactory.Instance.Create();

            Console.WriteLine($"factory2 {TaxCalculatorFactory.Instance.GetHashCode()}");
            //ITaxCalculatorStrategy calc = TaxCalculatorFactory.Create();
            BillingSystem bSys = new BillingSystem(calc1);
            bSys.GenerateBill();
        }
    }


    class TaxCalculatorFactory
    {
        private TaxCalculatorFactory()
        {

        }

        //private static TaxCalculatorFactory _instace = null;

        public static readonly TaxCalculatorFactory Instance = new TaxCalculatorFactory();
        //public static TaxCalculatorFactory GetInstance()
        //{
        //    if (_instace == null)
        //        _instace = new TaxCalculatorFactory();

        //    return _instace;
        //}
        public virtual ITaxCalculatorStrategy Create()
        {
            // read the config file
            string calcClass = ConfigurationManager.AppSettings["CALC"];
            // Reflextion
            Type theType = Type.GetType(calcClass);
            ITaxCalculatorStrategy calc = (ITaxCalculatorStrategy)Activator.CreateInstance(theType);
            return calc;
        }
    }

    class BillingSystem
    {
        private ITaxCalculatorStrategy _strategy = null;

        public BillingSystem(ITaxCalculatorStrategy strategy)
        {
            this._strategy = strategy;
        }
        public void GenerateBill()
        {
            // scann all products
            // total the amount
            // apply disc
            // apply coupns

            double amount = 5600.80;
            //TaxCalculator taxCalculator = new TaxCalculator();
            double tax = _strategy.CalculateTax(amount);
            Console.WriteLine(tax);
            // apply tax
            // finally calc tot bill
            // generate and print
            // payment
        }
    }

    public interface ITaxCalculatorStrategy
    {
        double CalculateTax(double amount);
    }

    public class KATaxCalculator : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amount)
        {
            int cgst = 50;
            int sgst = 50;
            int cess = 10;
            int etax = 6;

            double tax = cgst + sgst + etax + cess;
            Console.WriteLine("Using KA Tax Calculator");
            return tax;
        }
    }

    public class UsTaxCalc
    {
        public float ComputeTax(float amt)
        {
            //sdfsdfsdf
            //
            Console.WriteLine("Using US Tax Calculator");
            return 341.35F;
        }
    }

    public class UsTaxCalcAdaptor : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amount)
        {
            UsTaxCalc usTax = new UsTaxCalc();
            float tax = usTax.ComputeTax((float)amount);
            return tax;
        }
    }

    public class TNTaxCalculator : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amount)
        {
            int cgst = 50;
            int sgst = 50;
            int Acess = 12;
            int Btax = 7;

            double tax = cgst + sgst + Btax + Acess;
            Console.WriteLine("Using TN Tax Calculator");
            return tax;
        }
    }

    public class MHTaxCalculator : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amount)
        {
            int cgst = 50;
            int sgst = 50;
            int Acess = 12;
            int Btax = 7;

            double tax = cgst + sgst + Btax + Acess;
            Console.WriteLine("Using MH Tax Calculator");
            return tax;
        }
    }

}
