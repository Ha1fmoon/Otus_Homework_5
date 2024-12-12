namespace Otus_Homework_5;

public static class StackExtensions
{
    public static void Merge(this Stack stack, Stack secondStack)
    {
        while (secondStack.Size > 0) stack.Add(secondStack.Pop());
    }
}