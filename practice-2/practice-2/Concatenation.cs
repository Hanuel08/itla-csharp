namespace practice_2;

public class Concatenation
{
    public static void ShowUserInfo1()
    {
        try
        {
            Console.Write("Ingrese su nombre: ");
            string name = Console.ReadLine();
            
            if (name.Length <= 2 || name.Any(char.IsDigit)) 
                throw new FormatException("Por favor ingrese un nombre valido");
            
            Console.Write("Ingrese su edad: ");
            string edad = Console.ReadLine();
            
            if (!int.TryParse(edad, out int edadInt)) 
                throw new FormatException("Por favor ingrese una edad valida");

            Console.WriteLine("Su nombre es " + name.Trim() + " y su edad es " + edadInt);
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
    
    public static void ShowUserInfo2()
    {
        try
        {
            Console.Write("Ingrese su nombre: ");
            string name = Console.ReadLine();
            
            if (name.Length <= 2 || name.Any(char.IsDigit)) 
                throw new FormatException("Por favor ingrese un nombre valido");
            
            Console.Write("Ingrese su edad: ");
            string edad = Console.ReadLine();
            
            if (!int.TryParse(edad, out int edadInt)) 
                throw new FormatException("Por favor ingrese una edad valida");

            Console.WriteLine($"Su nombre es {name.Trim()} y su edad es {edadInt}");
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

    public static void SetProduct()
    {
        try
        {
            Console.Write("Ingrese el nombre del producto: ");
            string product = Console.ReadLine();
            
            if (product.Length <= 2 || product.Any(char.IsDigit)) 
                throw new FormatException("Por favor ingrese un nombre de producto valido");
            
            Console.Write("Ingrese el precio del producto: ");
            string price = Console.ReadLine();
            
            if (!double.TryParse(price, out double priceInt)) 
                throw new FormatException("Por favor ingrese un precio valida");

            Console.WriteLine($"\nEl producto {product.Trim()} con el precio {priceInt} fue agregado correctamente");
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

    public static void SetStudent()
    {
        try
        {
            Console.Write("Ingrese su nombre: ");
            string name = Console.ReadLine();
            
            if (name.Length <= 2 || name.Any(char.IsDigit)) 
                throw new FormatException("Por favor ingrese un nombre valido");
            
            Console.Write("Ingrese su carrera de interés: ");
            string career = Console.ReadLine();
            
            if (career.Length <= 2 || career.Any(char.IsDigit)) 
                throw new FormatException("Por favor ingrese un nombre de carrera valido");
            
            Console.Write("Ingrese su universidad interés: ");
            string university = Console.ReadLine();
            
            if (university.Length <= 2 || university.Any(char.IsDigit)) 
                throw new FormatException("Por favor ingrese una universidad valida");
            
            Console.WriteLine($"\n{name} se ha inscrito correctamente en la carrera de {career} en la universidad {university}");
            Console.WriteLine($"\nFelicidades Sr. {name.Split(" ")[0]}");
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

    public static void nameAndLastName()
    {
        try
        {
            Console.Write("Ingrese su nombre: ");
            string name = Console.ReadLine();
            
            if (name.Length <= 2 || name.Any(char.IsDigit)) 
                throw new FormatException("Por favor ingrese un nombre valido");
            
            Console.Write("Ingrese su apellido: ");
            string lastName = Console.ReadLine();
            
            if (lastName.Length <= 2 || lastName.Any(char.IsDigit)) 
                throw new FormatException("Por favor ingrese un apellido valido");

            Console.WriteLine("\nResultado: " + name.Trim() + " " + lastName.Trim());
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