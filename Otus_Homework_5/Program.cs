namespace Otus_Homework_5;

class Program
{
    static void Main(string[] args)
    {
        // BASIC CHECK
        var s = new Stack("a", "b", "c");

        // size = 3, Top = 'c'
        Console.WriteLine($"Size = {s.Size}, Top = '{s.Top}'");

        var deleted = s.Pop();

        // Top 'c' Size = 2
        Console.WriteLine($"Top element has been removed: '{deleted}' Size = {s.Size}");
        
        s.Add("d");

        // size = 3, Top = 'd'
        Console.WriteLine($"Size = {s.Size}, Top = '{s.Top}'");

        s.Pop();
        s.Pop();
        s.Pop();
        
        // size = 0, Top = null
        Console.WriteLine($"Size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
        
        s.Pop();
        
        // EXCEPTION AND RETURN VALUE CHECK
        var temp = s.Pop();
        
        Console.WriteLine($"temp = {(temp == null ? "null" : temp)}");
        
        // ADDITIONAL TASK 1 BASIC CHECK
        s = new Stack("a", "b", "c");
        
        s.Merge(new Stack("1", "2", "3"));

        // "a", "b", "c", "3", "2", "1" <- top
        Console.WriteLine($"Size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
    }
}