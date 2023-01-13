using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        string myName = args[0];
        Console.WriteLine("Hello, MARS! from " + myName);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}