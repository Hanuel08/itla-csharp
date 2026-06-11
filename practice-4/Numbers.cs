namespace practice_4;

public class Numbers
{
    public static void Show()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        int count = 0;

        Console.WriteLine("Los números son: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
            count += numbers[i];
        }
        Console.WriteLine($"\nTotal: {count}\nPromedio: {count / numbers.Length }");
    }
}