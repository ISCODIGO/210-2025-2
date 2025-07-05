// Calculadora basica
// + suma
// - resta
// Q | q salir

bool bandera = true;

while (bandera)
{
    //Console.Clear();
    Console.WriteLine("""

Calculadora Basica
-------------------
[+] Suma 
[-] Resta
[q] Salir
""");

    string opcion = Console.ReadLine();
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
        case "Q":            
            bandera = false;
            break;
        default:
            Console.WriteLine("Opcion invalida");
            break;
    }
}

Console.WriteLine("Fin de programa");