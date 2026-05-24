namespace practice_3;

public class Days
{
    public static void SelectDay()
    {
        try
        {
            Console.WriteLine("1 -> Lunes\n2 -> Martes\n3 -> Miércoles\n4 -> Jueves\n5 -> Viernes\n6 -> Sábado\n7 -> Domingo");
            
            Console.Write("\nSelecciona un día: ");
            string day = Console.ReadLine();
            
            if (!int.TryParse(day, out int dayInt)) 
                throw new FormatException("Por favor ingrese un día valida");
            
            string selectedDay = dayInt switch
            {
                1 => "Has seleccionado Lunes",
                2 => "Has seleccionado Martes",
                3 => "Has seleccionado Miércoles",
                4 => "Has seleccionado Jueves",
                5 => "Has seleccionado Viernes",
                6 => "Has seleccionado Sábado",
                7 => "Has seleccionado Domingo",
                _ => "Día inválido"
            };
            
            Console.WriteLine(selectedDay);
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