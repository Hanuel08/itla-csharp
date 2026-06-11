namespace practice_4;

public class PrintNumbers
{
    public static void Print()
    {
        int whileCount = 1;
        Console.WriteLine("################ WHILE");
        while (whileCount <= 10)
        {
            Console.WriteLine($"WHILE {whileCount}");
            whileCount++;
        }


        int doWhileCount = 1;
        Console.WriteLine("################ DO WHILE");
        do
        {
            Console.WriteLine($"DO WHILE {doWhileCount}");
            doWhileCount++;
        } while (doWhileCount <= 10);
        
        
        Console.WriteLine("################ FOR");
        for(int i = 1; i <= 10; i++) Console.WriteLine($"FOR {i}");
    }
}