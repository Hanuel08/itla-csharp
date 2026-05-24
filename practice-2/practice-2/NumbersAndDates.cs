namespace practice_2;

public class NumbersAndDates
{
    public static void Decimal()
    {
        Random randomDecimal =  new Random();
        double number = Math.Round(randomDecimal.NextDouble(), 2) * randomDecimal.Next(10, 1000000);
        Console.WriteLine(number.ToString("C2"));
    }
    
    public static void Salary()
    {
        try
        {
            Console.Write("Ingrese su salario: ");
            string salary = Console.ReadLine();
            
            if (!double.TryParse(salary, out double salaryDouble)) 
                throw new FormatException("Por favor ingrese un salario valida");

            Console.WriteLine($"Su salario es:  {salaryDouble.ToString("C2")} USD");
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

    public static void DateNow()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine(date.ToString("dd/MM/yyyy"));
    }

    public static void TimeNow()
    {
        DateTime time = DateTime.Now;
        Console.WriteLine(time.ToString("HH:mm:ss"));
    }
    public static void FormatNameAndNote()
    {
        try
        {
            Console.Write("Ingrese su nombre: ");
            string name = Console.ReadLine();
            
            Random randomDecimal =  new Random();
            double note = Math.Round(randomDecimal.NextDouble(), 2) * randomDecimal.Next(1, 99);
            //Console.WriteLine(note.ToString("C2"));
            
            if (name.Length <= 2 || name.Any(char.IsDigit)) 
                throw new FormatException("Por favor ingrese un nombre de producto valido");

            Console.WriteLine(string.Format("Sr. {0} su nota de la clase es {1} puntos", name, note.ToString("N1")));
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