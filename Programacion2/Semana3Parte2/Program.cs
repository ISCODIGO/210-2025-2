Console.WriteLine("Comparador de numeros...");
Console.Write("Escriba primer numero: ");
int.TryParse(Console.ReadLine(), out int numero);

Console.Write("Escriba el segundo numero: ");
int.TryParse(Console.ReadLine(), out int numero2);
/*
if (numero % 2 == 0)
{
    Console.WriteLine("Es par");
} else
{
    Console.WriteLine("Es impar");
}*/

if (numero == numero2)
{
    Console.WriteLine("Son iguales");
}
else
{
    if (numero < numero2)
    {
        Console.WriteLine($"{numero} es menor que {numero2}");
    } else
    {
        Console.WriteLine($"{numero} es mayor que {numero2}");
    }
}

if (numero == numero2)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Son iguales");
} else if (numero < numero2)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"{numero} es menor que {numero2}");
} else
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{numero} es mayor que {numero2}");
}



Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Fin del programa");