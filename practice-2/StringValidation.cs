namespace practice_2;
using System.Text.RegularExpressions;

public class StringValidation
{
    public static void CleanName()
    {
        try
        {
            Console.Write("Ingrese el nombre: ");
            string name = Console.ReadLine();
            
            if (name.Length <= 2 || name.Any(char.IsDigit)) 
                throw new FormatException("Por favor ingrese un nombre valido");
            
            Console.WriteLine($"\nEste es su nombre sin espacios: {name.Trim()}");
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

    public static void StringIsEmpty()
    {
        Console.Write("Ingrese un texto: ");
        string text = Console.ReadLine();
        
        if (string.IsNullOrEmpty(text)) Console.WriteLine("\nEl string esta vacio");
        else Console.WriteLine("\nEl string no esta vacio");
    }
    
    public static void StringHasWhiteSpace()
    {
        Console.Write("Ingrese un texto: ");
        string text = Console.ReadLine();
        
        if (string.IsNullOrEmpty(text)) Console.WriteLine("\nEl string esta vacio");
        else if (string.IsNullOrWhiteSpace(text)) Console.WriteLine("\nEl string tiene un espacio en blanco");
        else Console.WriteLine("\nEl string no esta vacio");
    }

    public static void PhoneNumber()
    {
        try
        {
            Console.Write("Ingrese un número de teléfono con guiones ej: (809-327-8749): ");
            string phone = Console.ReadLine().Trim();
            
            string phonePattern = @"^(\d{3})-(\d{3})-(\d{4})$";
            if (!Regex.IsMatch(phone, phonePattern)) throw new FormatException("Por favor ingrese un numero de teléfono valido");
            
            Console.WriteLine($"Número sin guiones: {phone.Replace("-", "")}");
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

    public static void RemoveSpaces()
    {
        try
        {
            Console.Write("Ingrese un texto con espacios: ");
            string text = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(text)) throw new FormatException("Por favor ingrese un texto");
            
            Console.WriteLine($"\nEste es su texto sin espacios: {text.Replace(" ", "")}");
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