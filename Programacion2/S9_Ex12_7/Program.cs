Console.Write("Escriba un numero positivo: ");

try
{
    if (!int.TryParse(Console.ReadLine(), out int numero))
    {
        throw new ArgumentException("Invalid number");
    }

    if (numero < 0)
    {
        throw new ArgumentException("Invalid number");
    }

    Console.WriteLine(Math.Sqrt(numero));

} catch(Exception objetoException)
{
    Console.WriteLine(objetoException.Message);
}
    
Console.WriteLine("Good bye");