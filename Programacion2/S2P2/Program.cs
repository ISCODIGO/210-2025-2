/*var accuracy = 0.000001;
Console.Write("Num 1: ");
double.TryParse(Console.ReadLine(), out double n1);
Console.Write("Num 2: ");
double.TryParse(Console.ReadLine(), out double n2);
bool comprobar = Math.Abs(n1 - n2) < accuracy;
Console.WriteLine($"Son similares? {comprobar}");
*/
var denominador = 0;
bool b = (1 > 0) || (0 / denominador > 0);
Console.WriteLine(b);

var num = 10;
string evaluar = (num % 2 == 0) ? "Par" : "Impar";

string eval;
if (num % 2 == 0)
{
    eval = "Par";
} else
{
    eval = "Impar";
}

string s1 = null;
string s2 = "hola";


Console.WriteLine(s1 ?? s2);

// ejercicio 3.2
var numero = 70;

var div5 = (numero % 5 == 0);
var div7 = (numero % 7 == 0);

Console.WriteLine($"Para el numero {numero} es divisible por 5 y 7? {div5 && div7}");
Console.WriteLine("Para el numero " + numero + " es divisible por 5 y 7? " + (div5 && div7));