namespace practice_3;

public class Numbers
{
    public static void Verify()
    {
        try
        {
            Console.Write("Ingrese un número: ");
            string number = Console.ReadLine();
            
            if (!double.TryParse(number, out double numberDouble)) 
                throw new FormatException("Por favor ingrese un número valido");

            if (numberDouble == 0) Console.WriteLine($"El número es igual a 0");
            else if (numberDouble > 0) Console.WriteLine($"El número {numberDouble} es positivo");
            else Console.WriteLine($"El número {numberDouble} es negativo");
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

    public static void EvenOrOdd()
    {
        try
        {
            Console.Write("Ingrese un número: ");
            string number = Console.ReadLine();
            
            if (!int.TryParse(number, out int numberInt)) 
                throw new FormatException("Por favor ingrese un número valido");
            
            if (numberInt % 2 == 0) Console.WriteLine($"El número {numberInt} es par");
            else Console.WriteLine($"El número {numberInt} es impar");
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