namespace practice_4;

public class Names
{
    public static void Print()
    {
        string[] names = { "Pedro", "Maria", "Juan", "Jose", "Luisa", "Leonardo" };
        foreach (string name in names) Console.WriteLine(name);
        Console.WriteLine($"\nHay {names.Length} nombres");
    }
}