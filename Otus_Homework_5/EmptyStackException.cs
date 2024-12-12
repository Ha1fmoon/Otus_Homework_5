namespace Otus_Homework_5;

public class EmptyStackException : Exception
{
    public EmptyStackException(string message) : base(message)
    {
    }
}