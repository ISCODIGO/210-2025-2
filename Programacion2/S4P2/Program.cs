// Calculadora basica
// + suma
// - resta
// Q | q salir

string opcion = string.Empty;

do
{
    //Console.Clear();
    Console.WriteLine("""

Calculadora Basica
-------------------
[+] Suma 
[-] Resta
[q] Salir
""");

    opcion = Console.ReadLine().ToLower();
    int num1, num2;

    switch (opcion)
    {
        case "+":
            Console.WriteLine("Comenzar la suma");
            Console.Write("Primer valor: ");
            int.TryParse(Console.ReadLine(), out num1);

            Console.Write("Segundo valor: ");
            int.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine(num2 + num1);
            break;
        case "-":
            Console.WriteLine("Comenzar la resta");
            Console.Write("Primer valor: ");
            int.TryParse(Console.ReadLine(), out num1);

            Console.Write("Segundo valor: ");
            int.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine(num1 - num2);
            break;
        case "q":
            break;
        default:
            Console.WriteLine("Opcion invalida");
            break;
    }
} while (opcion != "q");

Console.WriteLine("Fin de programa");