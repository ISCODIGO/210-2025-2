Console.WriteLine("Escriba numeros enteros.\nTermina si se lee un valor que no se numero.");

bool bandera = true;
int smallest = int.MaxValue;
int largest = int.MinValue;
while (bandera)
{
    bandera = int.TryParse(Console.ReadLine(), out int valor);
    
    if (bandera)
    {
        smallest = Math.Min(smallest, valor);
        largest = Math.Max(largest, valor);
    }
}

Console.WriteLine($"El valor maximo es {largest} y el minimo es {smallest}");