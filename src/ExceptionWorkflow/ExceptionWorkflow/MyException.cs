namespace ExceptionWorkflow
{
    public class MyException : System.Exception
    {
        public MyException(string ms)
            : base(ms)
        {
        }
    }
}