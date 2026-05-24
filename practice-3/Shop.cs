namespace practice_3;

public class Shop
{
    public static void Discount()
    {
        try
        {
            Console.Write("Total del compra ($RD): ");
            string purchase = Console.ReadLine();
            
            if (!double.TryParse(purchase, out double purchaseDouble)) 
                throw new FormatException("Por favor ingrese un número valido");
            
            Console.Write("Tiene usted membresía? (responda 'si' o 'no'): ");
            string membership = Console.ReadLine().ToLower().Trim();
            
            if (string.IsNullOrWhiteSpace(membership) || (membership != "si" && membership != "no")) 
                throw new FormatException("Por favor ingrese un 'si' o 'no'");
            
            bool membershipBool = membership == "si";
            
            if (purchaseDouble < 5000) Console.WriteLine("Necesita RD$5000 o más en compras para ser elegible para un descuento");
            else if (membershipBool)
            {
                Console.WriteLine("Cupón de 20% de descuento aplicado");
                Console.WriteLine($"Total a pagar: RD${purchaseDouble - ((purchaseDouble * 20) / 100)}");
            }
            else
            {
                Console.WriteLine("Cupón de 10% de descuento aplicado");
                Console.WriteLine($"Total a pagar: RD${purchaseDouble - ((purchaseDouble * 10) / 100)}");
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
}