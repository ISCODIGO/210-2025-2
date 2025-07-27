using System.Text;

string Revertir(string cadena)
{
    StringBuilder sb = new StringBuilder();
    string reves = string.Empty;

    for (int i = cadena.Length - 1; i >= 0; i--)
    {
        char c = cadena[i];
        sb.Append(c);
        reves += c;
    }

    // return sb.ToString();
    return reves;
}

// Esta funcion muestra el mal rendimiento de concatenar strings en bucle
void MalaConcatenacion()
{
    int inicio = Environment.TickCount;
    string palabra = "2025";
    for (int i = 0; i < 10_000; i++)
    {
        palabra += "2025";
    }
    int final = Environment.TickCount;

    Console.WriteLine($"Se tardo {final - inicio} milisegundos");
}

// Esta funcion muestra el buen rendimiento de usar StringBuilder en bucle
void BuenaConcatenacion()
{
    int inicio = Environment.TickCount;
    StringBuilder palabra = new StringBuilder("2025");
    for (int i = 0; i < 1_000_000; i++)
    {
        palabra.Append("2025");
    }
    int final = Environment.TickCount;

    Console.WriteLine($"Se tardo {final - inicio} milisegundos");
}

bool ValidarParentesis(string cadena)
{
    int total = 0;
    foreach (char c in cadena)
    {
        if (c == '(')
        {
            total++;
        }
        else if (c == ')')
        {
            total--;
        }

        if (total < 0)
        {
            return false;
        }
    }

    return total == 0;
}

void BuscarSubcadenaIndexOf(string cadena, string subcadena)
{
    int posicion = 0;
    int apariciones = 0;

    while (posicion < cadena.Length)
    {
        posicion = cadena.IndexOf(subcadena, posicion, StringComparison.OrdinalIgnoreCase);
        if (posicion == -1)
        {
            break;
        }
        else
        {
            apariciones++;
        }

        posicion++;
    }

    Console.WriteLine($"En la cadena hay {apariciones} apariciones de {subcadena}");
}

void BuscarSubcadenaSplit(string cadena, string subcadena)
{
    string[] partes = cadena.ToLower().Split(subcadena.ToLower());
    int apariciones = partes.Length - 1;

    Console.WriteLine($"En la cadena hay {apariciones} apariciones de {subcadena}");
}

string c = "hola mundo";

Console.WriteLine(c[3]);
// c[1] = "x"; -> invalido modificar las partes de un string

Console.WriteLine(Revertir(c));
MalaConcatenacion();
BuenaConcatenacion();

Console.WriteLine(ValidarParentesis("(())"));
Console.WriteLine(ValidarParentesis("(()"));
Console.WriteLine(ValidarParentesis("())"));
Console.WriteLine(ValidarParentesis(")("));

// Como dividir un string que contiene barras invertidas
string test = @"one\two\three";
string[] strings = test.Split("\\");
Console.WriteLine(strings[1]);

Console.WriteLine("Ingrese una subcadena a buscar en la frase:");
string subcadena = Console.ReadLine() ?? string.Empty;
string frase = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
BuscarSubcadenaIndexOf(frase, subcadena);
BuscarSubcadenaSplit(frase, subcadena);