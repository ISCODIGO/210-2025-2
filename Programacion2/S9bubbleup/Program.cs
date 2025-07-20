namespace S9;

public class Program
{
    static void Main()
    {
        try
        {
            Nivel1();
        } catch(DivideByZeroException dz)
        {
            Console.WriteLine("Main: " + dz.StackTrace);
        }
    }

    static void Nivel1()
    {
        Console.WriteLine("Nivel 1");
        Nivel2();
    }

    static void Nivel2()
    {
        Console.WriteLine("Nivel 2");
        Nivel3();
    }

    static void Nivel3()
    {
        Console.WriteLine("Nivel 3");
        int x = 0;
        Console.WriteLine( 5 / x);
    }
}