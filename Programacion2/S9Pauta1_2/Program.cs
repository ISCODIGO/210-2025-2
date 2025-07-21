int numeroValidos = 0;

Console.Write("Establecer cantidad de numeros validos: ");
int.TryParse(Console.ReadLine(), out int cantidadNumerosValidos);

Console.WriteLine($"Escriba {cantidadNumerosValidos} numeros validos...");
int suma = 0;
while(numeroValidos < cantidadNumerosValidos)
{
    bool prueba = int.TryParse(Console.ReadLine(), out int valor);
    if (prueba)
    {
        suma += valor;
        numeroValidos++;
    }

}
Console.WriteLine("Respuesta: " + suma);


Console.Write("Que hora es: ");
int.TryParse(Console.ReadLine(), out int hora);

if (hora >= 0 && hora <= 23)
{
    if (hora <= 5)
    {
        Console.WriteLine("Deberias estar durmiendo");
    }
    else if (hora <= 11)
    {
        Console.WriteLine("Buenos dias");
    }
    else if (hora <= 18)
    {
        Console.WriteLine("Buenas tardes");
    } else
    {
        Console.WriteLine("Buenas noches");
    }

} else
{
    Console.WriteLine("Hora invalido");
}