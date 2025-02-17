namespace SimpleCalcLib
{
    public class Calculator
    {

        public Calculator()
        {

        }
        IResultLogger logger;
        public Calculator(IResultLogger logger)
        {
            this.logger = logger;
        }

        public int Sum(int a, int b)
        {
            // non negative, non zero, non odd numbers - thow exp
            // save the result into file and return it.
            if (a < 0 || b < 0)
                throw new NegativeInputException();

            if (a == 0 || b == 0)
                throw new ZeroInputException();

            if (a % 2 != 0 || b % 2 != 0)
                throw new OddInputException();

            // save into file

            int result = a + b;
            //FileLogger.SaveResult(a, b, result);
            logger.SaveResult(a, b, result);

            return result;
        }
    }

    public interface IResultLogger
    {
        void SaveResult(int i1, int i2, int result);
    }

    public class FileLogger : IResultLogger
    {
        public void SaveResult(int i1, int i2, int result)
        {
            string data = $"{i1} + {i1} = {result}"; // 10 + 20 = 30
            File.WriteAllText("Z:\\result.txt", data);
        }
    }
}
