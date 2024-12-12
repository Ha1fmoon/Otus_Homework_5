namespace Otus_Homework_5;

public class Stack
{
    private List<string> _storage = new List<string>();

    public int Size => _storage.Count;
    public string? Top => _storage.Count > 0 ? _storage[_storage.Count - 1] : null;

    public Stack(params string[] values)
    {
        foreach (var value in values)
        {
            _storage.Add(value);
        }
    }

    public void Add(string value)
    {
        _storage.Add(value);
    }

    public string? Pop()
    {
        try
        {
            var value = Top;
            
            if (value == null) throw new EmptyStackException("Stack is empty");
            
            _storage.RemoveAt(Size - 1);
            
            return value;
        }
        catch (EmptyStackException e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(e.Message);
            Console.ResetColor();
            
            return null;
        }
    }
}