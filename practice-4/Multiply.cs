namespace practice_4;

public class Multiply
{
    public static void MultiplyNumbers()
    {
        try
        {
            Console.Write("Ingrese un número: ");
            
            string number = Console.ReadLine();
            
            if (!int.TryParse(number, out int numberInt)) 
                throw new FormatException("Por favor ingrese un número valida");
            
            for (int i = 1; i <= 12; i++) Console.WriteLine($"{i} x  {numberInt} =  {numberInt * i}");
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocurrió un error");
        }
    }
}