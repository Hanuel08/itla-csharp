namespace practice_3;

public class Grades
{
    public static void Grade()
    {
        try
        {
            Console.Write("Ingrese su calificación final (0-100): ");
            string grade = Console.ReadLine();
            
            if (!double.TryParse(grade, out double gradeDouble)) 
                throw new FormatException("Por favor ingrese un número valido");
            
            if (gradeDouble < 0 || gradeDouble > 100) throw new FormatException("Por favor ingrese un número positivo entre 0 y 100");

            if (gradeDouble >= 70) Console.WriteLine($"Usted ha aprobado el curso");
            else Console.WriteLine($"Usted ha reprobado el curso");
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