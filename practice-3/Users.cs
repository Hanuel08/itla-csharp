namespace practice_3;
using System.Collections.Generic;

public class Users
{
    private static Dictionary<string, string> users = new Dictionary<string, string>();

    private static string GetUsername(string message = "Ingrese un username: ")
    {
        try
        {
            Console.Write(message);
            string username = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(username) || username.Length <= 2) 
                throw new FormatException("Por favor ingrese un username valido");
        
            return username.ToLower().Trim();
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
            return string.Empty;
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocurrió un error");
            return string.Empty;
        }
    }
    
    private static string GetPassword(string message = "Ingrese una contraseña (minimo 6 digitos): ")
    {
        try
        {
            Console.Write(message);
            string password = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6) 
                throw new FormatException("Por favor ingrese una contraseña valida");
        
            return password.ToLower().Trim();
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
            return string.Empty;
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocurrió un error");
            return string.Empty;
        }
    }
    
    public static void SingIn()
    {
        try
        {
            Console.WriteLine("CREA UNA CUENTA:");
            
            string username = GetUsername();
            if (username.Length == 0) return;
            if (users.ContainsKey(username)) throw new Exception($"El usuario '{username}' ya existe");
            
            string password1 = GetPassword();
            if (password1.Length == 0) return;
            
            string password2 = GetPassword("Repita la contraseña: ");
            if (password2.Length == 0) return;
            
            if (password1 != password2) Console.WriteLine("\nLa contraseña es incorrecta");
            else
            {
                users.Add(username, password1);
                Console.WriteLine("\nUsuario creado correctamente\n");
                Login();
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    public static void Login()
    {
        try
        {
            Console.WriteLine("INICIA SESIÓN:");
            
            string username = GetUsername("Ingresa tu username: ");
            if (username.Length == 0) return;
            if (!users.ContainsKey(username)) throw new Exception($"El usuario '{username}' no existe");
            
            string password = GetPassword("Ingresa tu contraseña: ");
            if (password.Length == 0) return;
            if (users[username] != password) throw new Exception("\nLa contraseña es incorrecta");
            
            Console.WriteLine("\nACCESO PERMITIDO");
            Console.WriteLine($"Bienvenido {username}, has iniciado sesión correctamente");
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}