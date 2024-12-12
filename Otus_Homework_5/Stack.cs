namespace Otus_Homework_5;

public class Stack
{
    private StackItem? _top;

    public int Size { get; private set; }

    public string? Top => _top?.Value;

    public Stack(params string[] values)
    {
        foreach (var value in values) Add(value);
    }

    public void Add(string value)
    {
        _top = new StackItem(value, _top);

        Size++;
    }

    public string? Pop()
    {
        if (Size <= 0 || _top == null) throw new EmptyStackException("Stack is empty");

        var value = Top;

        _top = _top.Previous;

        Size--;

        return value;
    }

    public static Stack Concat(params Stack[] stacks)
    {
        var newStack = new Stack();

        foreach (var stack in stacks) newStack.Merge(stack);

        return newStack;
    }

    private class StackItem
    {
        public string Value { get; }
        public StackItem? Previous { get; }

        public StackItem(string value, StackItem? previous)
        {
            Value = value;
            Previous = previous;
        }
    }
}