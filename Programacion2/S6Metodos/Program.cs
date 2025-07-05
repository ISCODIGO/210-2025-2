/*

a.	Si la hora es entre 0 y 5, indicar “Deberías estar durmiendo”
b.	Si la hora es entre 6 y 11, indicar “Buenos días”
c.	Si la hora es entre12 y 18, indicar “Buenas tardes”
d.	Si la hora es entre 19 y 23, indicar “Buenas noches”.
e.	Si la hora es un número negativo o mayor que 23, indicar “Invalido”.

python
def sumar(a, b):
    return a + b

js
function sumar(a, b) {
   return a + b
}

c#
int sumar(int a, int b) {
    return a + b;
}

go
func sumar(a int, b int) int {
   return a + b
}

a y b son argumentos
*/

public class Prueba
{
    static void Saludar(int hora)
    {
        if (hora < 0 || hora > 23)
        {
            Console.WriteLine("Invalido");
        }
        //---------- 0 - 23
        else if (hora <= 5)
        {
            Console.WriteLine("Deberias estar dormido");
        }
        //---------- 6 - 23
        else if (hora <= 11)
        {
            Console.WriteLine("Buenos dias");
        }
        //---------- 12 - 23
        else if (hora <= 18)
        {
            Console.WriteLine("Buenas tardes");
        }
        //---------- 19 - 23
        else
        {
            Console.WriteLine("Buenas noches");
        }
    }

    static string Saludar(short hora)
    {
        if (hora < 0 || hora > 23)
        {
            return "Invalido";
        }
        else if (hora <= 5)
        {
            return "Deberias estar dormido";
        }
        else if (hora <= 11)
        {
            return "Buenos dias";
        }
        else if (hora <= 18)
        {
            return "Buenas tardes";
        }
        else
        {
            return "Buenas noches";
        }
    }

    static double Dividir(double dividendo, double divisor, ref double residuo)
    {
        residuo = dividendo % divisor; 
        return dividendo / divisor;
    }

    static int sumar(int a, int b = 0)
    {
        return a + b;
    }

    static int sumar2(params int[] numeros)
    {
        return numeros.Sum();
    }

    static string LastDigitName(int numero)
    {
        // 512 -> [5, 1, 2]
        string[] digitos =
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
        };

        string cadena = numero.ToString();
        char ultimoCaracter = cadena[cadena.Length - 1];
        int ultimoDigito = (int)Char.GetNumericValue(ultimoCaracter);
        //int.TryParse(ultimoCaracter.ToString(), out int ultimoDigito);
        //int ultimoDigito = (int)ultimoCaracter - 48;  // valor ASCII donde 0: 48 

        return digitos[ultimoDigito];
    }

    static int Max(int[] numeros)
    {
        // [5, 2, 3, 4, 9]
        // [9, 5, 4, 3, 2]
        // posicion 0

        Array.Sort(numeros);
        Array.Reverse(numeros);
        return numeros[0];
    }

    public static void Main(string[] args)
    {
        Saludar(23);
        Saludar(10);
        Saludar(20);
        Saludar(30);
        Saludar(-1);

        Console.WriteLine(Saludar((short)23));

        double x = 32453453;
        Console.WriteLine(Dividir(2, 4, ref x));
        Console.WriteLine(x);

        Console.WriteLine(sumar(3, 4));
        Console.WriteLine(sumar(10));

        // 1 + 2 + 3
        Console.WriteLine(sumar(1, sumar(2, 3)));


        Console.WriteLine(sumar2(1));
        Console.WriteLine(sumar2(1, 2));
        Console.WriteLine(sumar2(1, 2, 3));
        Console.WriteLine(sumar2(1, 2, 3, 4, 5, 6, 7, 8, 9));

        Console.WriteLine(LastDigitName(435439));

        Console.WriteLine("Reciente...");
        int resultado = Max(new int[] { 5, 2, 10, 3, 4, 9 });
        Console.WriteLine(resultado);
    }


}

// Crear una funcion que RETORNE la suma de dos numeros 
// int sumar(int a, int b)

// Crear una funcion que IMPRIMA la suma de dos numeros
// void sumar(int a, int b) { Console.WriteLine(a + b); }


