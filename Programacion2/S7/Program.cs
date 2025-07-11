using System.ComponentModel.Design;

namespace S7;

public class Program
{

    public static void Main(string[] args)
    {
        Cuenta c1 = new Cuenta(12345);

        //c1.Saldo = 10_000_000;
        c1.Cliente = "Francisco Morazan";

        Console.Write("Cuenta desea retirar: ");
        decimal.TryParse(Console.ReadLine(), out decimal montoRetiro);

        try
        {
            c1.Retirar(montoRetiro);
        } catch(ArgumentException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ForegroundColor = ConsoleColor.White;
            // logger
        }

        //Console.WriteLine(c1.Saldo);
        Console.WriteLine(c1);



    }
}