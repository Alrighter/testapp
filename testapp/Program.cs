namespace MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(Order(input));
    }

    public static string Order(string order)
    {
        return string.IsNullOrEmpty(order) ? string.Empty : string.Join(" ", order
            .Split(" ")
            .Select(x => x.Trim())
            .Where(n => n.Length > 0)
            .ToDictionary(x => x, a => a.Sum(c => c - '0'))
            .OrderBy(x => x.Value)
            .ThenBy(x => x.Key)
            .Select(x => x.Key));
    }


}