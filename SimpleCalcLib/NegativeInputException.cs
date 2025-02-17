
namespace SimpleCalcLib
{
    [Serializable]
    public class NegativeInputException : ApplicationException
    {
        //public NegativeInputException()
        //{
        //}

        //public NegativeInputException(string? message) : base(message)
        //{
        //}

        public NegativeInputException(string? message = null, Exception? innerException = null) : base(message, innerException)
        {
        }
    }
}