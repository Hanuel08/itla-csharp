namespace practice_3;

public class Calculator
{
    public static void Calculate1()
    {
        try
        {
            Console.Write("Primer número: ");
            string num1 = Console.ReadLine();

            if (!double.TryParse(num1, out double num1Double))
                throw new FormatException("Por favor ingrese un número valido");
            
            Console.Write("Segundo número: ");
            string num2 = Console.ReadLine();

            if (!double.TryParse(num2, out double num2Double))
                throw new FormatException("Por favor ingrese un número valido");
            
            Console.Write("Operación que quieres realizar (+, -, *, /, %): ");
            string operation = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(operation) || (operation != "+" && operation != "-" &&  operation != "*" && operation != "/" && operation != "%"))
                throw new FormatException("Por favor ingrese una operación valida");
            
            double result = operation switch
            {
                "+" => num1Double + num2Double,
                "-" => num1Double - num2Double,
                "/" => num1Double / num2Double,
                "*" => num1Double * num2Double,
                "%" => num1Double % num2Double
            };
            
            Console.WriteLine($"\nResultado: {result}");
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
    
    public static void Calculate2()
    {
        try
        {
            Console.Write("Primer número: ");
            string num1 = Console.ReadLine();

            if (!double.TryParse(num1, out double num1Double))
                throw new FormatException("Por favor ingrese un número valido");
            
            Console.Write("Segundo número: ");
            string num2 = Console.ReadLine();

            if (!double.TryParse(num2, out double num2Double))
                throw new FormatException("Por favor ingrese un número valido");
            
            Console.Write("Operación que quieres realizar (+, -, *, /, %): ");
            string operation = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(operation))
                throw new FormatException("Por favor ingrese una operación valida");

            double result;
            
            if (operation == "+") result  = num1Double + num2Double;
            else if (operation == "-") result  = num1Double - num2Double;
            else if (operation == "*") result  = num1Double * num2Double;
            else if (operation == "/") result  = num1Double / num2Double;
            else if (operation == "%") result  = num1Double % num2Double;
            else throw new FormatException("Por favor ingrese una operación valida");
            
            Console.WriteLine($"\nResultado: {result}");
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