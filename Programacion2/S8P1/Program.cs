bool bisiesto(int año)
{
    if (año % 400 == 0) return true;
    if (año % 100 == 0) return false;
    if (año % 4 == 0) return true;
    return false;
}

void probarBisiesto()
{

    // Ejecutar programa
    Console.Write("Escriba un valor: ");
    int.TryParse(Console.ReadLine(), out int valor);

    var prueba = bisiesto(valor);

    if (prueba)
    {
        Console.WriteLine($"El año {valor} es bisiesto");
    }
    else
    {
        Console.WriteLine($"El año {valor} no es bisiesto");
    }
}

void diaSemana()
{
    DateTime dateTime = DateTime.Today;
    int dia = (int)dateTime.DayOfWeek;

    switch(dia)
    {
        case 0:
            Console.WriteLine("Domingo");
            break;
        case 1:
            Console.WriteLine("Lunes");
            break;
        case 6:
            Console.WriteLine("Sabado");
            break;

    }
}

double areaTrianguloV1(double lado1, double lado2, double lado3)
{
    double p = (lado1 + lado2 + lado3) / 2;
    double area = Math.Sqrt(p * (p - lado1) * (p - lado2) * (p - lado3));
    return area;
}

double areaTrianguloV2(double lado, double altura)
{
    return lado * altura / 2;
}

double areaTrianguloV3(double lado1, double lado2, double angulo)
{
    double anguloRadianes = angulo * Math.PI / 180 ;

    return lado1 * lado2 * Math.Sin(anguloRadianes) / 2;
}

int sumaSecuencia(string secuencia)
{
    var cadenas = secuencia.Split(' ');
    int suma = 0;
    foreach (string cadena in cadenas)
    {
        int.TryParse(cadena, out int numero);
        suma += numero;

    }
    return suma;
}

//diaSemana();
//probarBisiesto();

Console.WriteLine(areaTrianguloV1(5, 4, 3));
Console.WriteLine(areaTrianguloV2(6, 4));
Console.WriteLine(areaTrianguloV3(3, 4, 90));
Console.WriteLine(sumaSecuencia("43 68 9 jj 23 318"));