namespace practice_1;
public class DegreeConverter
{
    private static decimal ToCelsius(decimal degree)
    {
        return (degree - 32) * (5m / 9m);
    }
    
    private static decimal ToFahrenheit(decimal degree)
    {
        return (degree * (9m / 5m)) + 32m;
    }

    public static void ConvertTo()
    {
        Console.WriteLine("1. Fahrenheit > Celsius");
        Console.WriteLine("2. Celsius > Fahrenheit");
        Console.WriteLine();

        Console.Write("Qué quieres convertir?: ");
        string option = Console.ReadLine();

        if (option != "1" && option != "2")
        {
            Console.WriteLine("Opcion incorrecta");
            return;
        }
        
        Console.Write("Ingresa el valor que quieres convertir: ");
        string input = Console.ReadLine();
        
        decimal validationResult;
        if (!decimal.TryParse(input, out validationResult))
        {
            Console.WriteLine($"El valor ingresado es incorrecto");
            return;
        }
        
        decimal number = Convert.ToDecimal(input);
        
        if (option == "1") Console.WriteLine($"{number} °F => {DegreeConverter.ToCelsius(number)} °C");
        else Console.WriteLine($"{number} °C => {DegreeConverter.ToFahrenheit(number)} °F");
    }
}