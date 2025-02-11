namespace SimpleMathClassLibrary
{

    /// <summary>
    /// Calculator is used for general mathematic calculations
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Finds the sum of two int numbers
        /// </summary>
        /// <param name="fno">first int number</param>
        /// <param name="sno">second int number</param>
        /// <returns>the sum of two numbers</returns>
        /// <exception cref="UnableToFindSumException"></exception>
        public static int FindSum(int fno, int sno) // BLL - SRP
        {
            //try
            //{
            //int a = 10;
            //int b = 0;
            //int c = a / b;

            // non-zero
            if (fno == 0 || sno == 0)
            {
                throw new InvalidInputException("Provide non zero input");
            }

            // negative no

            if (sno < 0 || fno < 0)
            {
                throw new InvalidInputException("Provide non negative input");
            }

            // odd numbers
            if (fno % 2 != 0 || fno % 2 != 0)
            {
                throw new InvalidInputException("Provide Even input");
            }

            return fno + sno;
            // }
            //catch (DivideByZeroException ex)
            //{
            //    //Console.WriteLine("");
            //    //throw ex;

            //    //1. Log 

            //    // frameworks: Log4Net, nLog, SeriLog,.....

            //    //2. Ex Convertion

            //    UnableToFindSumException unableToFindSumException = new UnableToFindSumException("Database problem, please try later", ex);
            //    throw unableToFindSumException;
            //}
        }
    }

    public class UnableToFindSumException : ApplicationException
    {
        //public UnableToFindSumException()
        //{

        //}
        //public UnableToFindSumException(string msg) : base(msg)
        //{
        //    //this.Message = msg;
        //}
        public UnableToFindSumException(string msg = null, Exception innerExp = null) : base(msg, innerExp)
        {

        }
    }

    public class InvalidInputException : ApplicationException
    {
        public InvalidInputException(string msg = null) : base(msg)
        {

        }
    }
}

