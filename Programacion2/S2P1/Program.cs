Console.WriteLine("Calculadora v0.0.1");
Console.Write("Escriba un numero: ");
string? v1 = Console.ReadLine();

Console.Write("Escriba un segundo numero: ");
string? v2 = Console.ReadLine();

double.TryParse(v1, out double num1);
double.TryParse(v2, out double num2);

Console.WriteLine("La suma es: " + (num1 + num2));

// Object
object o1 = "Hola";
object o2 = 10;
object o3 = false;
object o4 = 'c';

string s = (string)o1;  // unboxing
int i1 = (int)o2;