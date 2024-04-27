namespace HomeWork11.ThirdTask.Engines
{
    public class EmptyTankException : Exception
    {
        public EmptyTankException()
        {

        }

        public EmptyTankException(string message)
            : base(message)
        {

        }

        public EmptyTankException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
