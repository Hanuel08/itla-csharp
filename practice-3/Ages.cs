namespace practice_3;

public class Ages
{
    public static void Classify()
    {
        try
        {
            Console.Write("Ingrese su edad (0-110): ");
            string age = Console.ReadLine();
            
            if (!int.TryParse(age, out int ageInt)) 
                throw new FormatException("Por favor ingrese un número valido");
            
            if (ageInt < 0 || ageInt > 110) throw new FormatException("Por favor ingrese un número positivo entre 0 y 110");

            if (ageInt <= 12) Console.WriteLine($"Usted es un niño");
            else if (ageInt <= 17) Console.WriteLine($"Usted es un adolecente");
            else if (ageInt <= 59) Console.WriteLine($"Usted es un adulto");
            else Console.WriteLine($"Usted es un adulto mayor");
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