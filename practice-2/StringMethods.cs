namespace practice_2;
using System.Text.RegularExpressions;
public class StringMethods
{
    public static void FullName()
    {
        try
        {
            Console.Write("Ingrese su nombre: ");
            string fullName = Console.ReadLine();
            
            if (fullName.Length <= 2 || fullName.Any(char.IsDigit)) throw new FormatException();

            // contar caracteres del texto excluyendo los espacios vacios
            string[] splitName = fullName.Trim().Split(" ");
            int length = fullName.Length - (splitName.Length - 1);

            string capitalizedName = "";
            foreach (string name in splitName)
            {
                capitalizedName += char.ToUpper(name[0]) + name.Substring(1) + " ";
            }

            Console.WriteLine($"Su nombre es: {capitalizedName}");
            Console.WriteLine($"La cantidad de caracteres es: {length}");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Por favor, solo ingrese un nombre valido");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocurrió un error");
        }
    }

    public static void ToUpperAndLower()
    {
        try
        {
            Console.Write("Ingrese un texto: ");
            string text = Console.ReadLine();
            if (text.Length <= 2 || text.Any(char.IsDigit)) throw new FormatException();
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
        }
        catch (FormatException e)
        {
            Console.WriteLine("Por favor, solo ingrese un texto valido");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocurrió un error");
        }
    }

    public static void ExtractString()
    {
        try
        {
            Console.Write("Ingrese una frase con mas de 5 caracteres: ");
            string phrase = Console.ReadLine();
            if (phrase.Length <= 5 || phrase.Any(char.IsDigit)) throw new FormatException();
            Console.WriteLine($"Resultado: {phrase.Substring(5)}"); 
        }
        catch (FormatException e)
        {
            Console.WriteLine("Por favor, solo ingrese una frase valido");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocurrió un error");
        }
    }

    public static void ReplaceA()
    {
        try
        {
            Console.Write("Ingrese un texto: ");
            string text = Console.ReadLine();
            if (text.Length <= 5 || text.Any(char.IsDigit)) throw new FormatException();
            Console.WriteLine($"Texto remplazado: {text.ToLower().Replace("a", "@")}"); 
        }
        catch (FormatException e)
        {
            Console.WriteLine("Por favor, solo ingrese un texto valido");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocurrió un error");
        }
    }

    public static void EmailDomain()
    {
        try
        {
            Console.Write("Ingrese un texto: ");
            string email = Console.ReadLine();
            
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern)) throw new FormatException();
            
            int index =  email.IndexOf('@');
            Console.WriteLine($"El dominio del email es: {email.Substring(index)}"); 
        }
        catch (FormatException e)
        {
            Console.WriteLine("Por favor, solo ingrese un email valido");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocurrió un error");
        }
    }
}