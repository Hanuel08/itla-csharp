namespace practice_3;

public class Access
{
    public static void Validate()
    {
        try
        {
            Console.Write("Ingresa tu edad: ");
            string age = Console.ReadLine();
            
            if (!double.TryParse(age, out double ageDouble)) 
                throw new FormatException("Por favor ingrese una edad valida");
            
            Console.Write("Tiene usted identificación? (responda 'si' o 'no'): ");
            string id = Console.ReadLine().ToLower().Trim();
            
            if (string.IsNullOrWhiteSpace(id) || (id != "si" && id != "no")) 
                throw new FormatException("Por favor ingrese un 'si' o 'no'");
            
            bool idBool = id == "si";
            
            if (ageDouble < 18) Console.WriteLine("Eres menor de edad, no puedes entrar");
            else if (idBool) Console.WriteLine("Puedes entrar");
            else Console.WriteLine("No puedes entrar");
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