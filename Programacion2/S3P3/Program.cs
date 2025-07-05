// Dado un numero entre 0 y 6, indicar que dia de la semana es
// 0 -> domingo, 1-> lunes, 6-> sabado

/*
int.TryParse(Console.ReadLine(), out int numeroDia);

// Version 1
string dia;

switch (numeroDia)
{
    case 1:
        dia = "lunes";
        break;
    case 2:
        dia = "martes";
        break;
    case 6:
        dia = "sabado";
        break;
    default:
        dia = "domingo";
        break;
}

// Version 2
string dia2 = (numeroDia) switch
{
    1 => "LUNES",
    2 => "MARTES",
    3 => "MIERCOLES",
    4 => "JUEVES",
    5 => "VIERNES",
    6 => "SABADO",
    _ => "DOMINGO",
};

Console.WriteLine(dia2);


Console.Write("Escribir un resultado de nota: ");
string? resultado = Console.ReadLine();
switch(resultado.ToUpper())
{
    case "NSP":
        Console.WriteLine("0");
        break;
    case "ABD":
        Console.WriteLine("1 - 20");
        break;
    case "RPB":
        Console.WriteLine("21 - 64");
        break;
    case "APR":
        Console.WriteLine("65 - 100");
        break;
    default:
        Console.WriteLine("Invalido");
        break;

}
*/

int n = 6;

int c = n / 100;
int restod = n % 100;
int d = restod / 10;
int u = restod % 10;

Console.WriteLine("{2} centenas, {1} decenas, {0} unidades", u, d, c);