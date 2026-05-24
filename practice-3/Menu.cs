namespace practice_3;

public class Menu
{
    public static void Options()
    {
        try
        {
            Console.WriteLine("1. Ver perfil\n2. Editar perfil\n3. Eliminar perfil\n4. Salir\n");
            Console.Write("Elige una opción: ");
            string option = Console.ReadLine();
            
            if (!int.TryParse(option, out int optionInt)) 
                throw new FormatException("Por favor ingrese una opción valida");
            
            string selectedOption = optionInt switch
            {
                1 => "Viendo tu perfil",
                2 => "Editando tu perfil...",
                3 => "Perfil eliminado",
                4 => "Has salido del menu",
                _ => "Opción invalida"
            };
            
            Console.WriteLine(selectedOption);
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