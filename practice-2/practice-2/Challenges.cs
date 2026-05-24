namespace practice_2;

public class Challenges
{
    public static void CreateUser()
    {
        try
        {
            Console.Write("Ingrese su nombre: ");
            string name = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(name) || name.Length <= 2 || name.Any(char.IsDigit)) 
                throw new FormatException("Por favor ingrese un nombre valido");
            
            Console.Write("Ingrese su apellido: ");
            string lastName = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(lastName) || lastName.Length <= 2 || lastName.Any(char.IsDigit)) 
                throw new FormatException("Por favor ingrese un apellido valido");
            
            string username = $"{name.Trim().Substring(0, 1)}{lastName.Trim()}{DateTime.Now.Year.ToString()}";

            Console.WriteLine($"Su nombre de usuario es:  {username}");
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

    public static void ValidateEmailCharacter(string character = "@")
    {
        try
        {
            Console.Write("Ingrese su email: ");
            string email = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(email) || email.Length <= 2) 
                throw new FormatException("Por favor ingrese un email valido");
            
            if (email.Contains(character)) Console.WriteLine($"Su email si contiene '{character}'");
            else Console.WriteLine($"Su email no contiene '{character}'");
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

    public static void CountVowels()
    {
        char[] vowels = ['a', 'e', 'i', 'o', 'u'];
        int[] vowelsCount = [0, 0, 0, 0, 0];
        
        try
        {
            Console.Write("Ingrese un texto: ");
            string text = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(text) || text.Length == 0) 
                throw new FormatException("Por favor ingrese un texto valido");

            char letter, vowel;
            int totalVowels = 0;
            for (int i = 0; i < text.Length; i++)
            {
                letter = text[i];
                for (int j = 0; j < vowels.Length; j++)
                {
                    vowel = vowels[j];
                    if (letter == vowel)
                    {
                        vowelsCount[j] += 1;
                        totalVowels += 1;
                        break;
                    }
                }
            }
            
            Console.WriteLine($"Tu texto tiene {totalVowels} vocales");
            Console.WriteLine($"\na: {vowelsCount[0]}\ne: {vowelsCount[1]}\ni: {vowelsCount[2]}\no: {vowelsCount[3]}\nu: {vowelsCount[4]}");
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

    public static void InvertString()
    {
        try
        {
            Console.Write("Ingrese un texto: ");
            string text = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(text) || text.Length == 0) 
                throw new FormatException("Por favor ingrese un texto valido");

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
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
    
    public static void IsPalindrome()
    {
        try
        {
            Console.Write("Ingrese un texto: ");
            string text = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(text) || text.Length == 0) 
                throw new FormatException("Por favor ingrese un texto valido");
            
            string originalText = text.ToLower().Replace(" ", "");
            string reversedText = new string(originalText.Reverse().ToArray());
            if (originalText == reversedText) Console.WriteLine("El texto es un palindromo");
            else Console.WriteLine("El texto no es un palindromo");
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