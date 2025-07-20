namespace S9Obj;

public class Program
{
    static void Main()
    {
        #region Estatico
        int inicio = Environment.TickCount;
        Console.WriteLine(Secuencia.Siguiente());
        Console.WriteLine(Secuencia.Siguiente());
        Console.WriteLine(Secuencia.Siguiente());
        Console.WriteLine(Secuencia.Siguiente());
        Console.WriteLine(Secuencia.Siguiente());
        Console.WriteLine(Secuencia.Siguiente());
        Console.WriteLine(Secuencia.Siguiente());
        Console.WriteLine(Secuencia.Siguiente());

        Console.WriteLine(Math.Pow(2, 3));
        int final = Environment.TickCount;

        Console.WriteLine($"Se ha tardado: {final - inicio} milisegundos");
        #endregion

        #region No estatico
        Personaje mago = new Personaje(2000, 1500);
        Personaje arquero = new Personaje(1750, 1750);

        Console.WriteLine("Def arquero: " + arquero.Defensa);
        mago.Atacar(arquero);
        Console.WriteLine(mago);
        Console.WriteLine(arquero);
        #endregion
    }
}