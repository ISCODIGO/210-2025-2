// Ejercicio 7.1

// Crear un array de 20 elementos
// [0, 5, 10, 15, 20, 25, 30, ..., 95]
//  0  1   2   3   4   5   6       19
int[] array1 = new int[20];
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = i * 5;
}

/*
foreach (int i in array1)
{
    Console.Write(i);
    Console.Write(", ");
}
*/

Console.WriteLine(string.Join(", ", array1));


// Ejercicio 7.4

int[] array2 = {1, 1, 2, 3, 2, 2, 2, 4, 5, 5, 6, 6, 6, 7};
int ganador = 0;
int secuenciaMax = 0;

// este bucle recorre cada candidato inicial
for (int i = 0; i < array2.Length - 1; i++)
{
    int candidato = array2[i];
    int repeticiones = 1;

    // este bucle recorre los elementos que estan delante del candidato
    for (int j = i + 1; j < array2.Length; j++)
    {
        int siguiente = array2[j];

        if (candidato == siguiente)
        {
            repeticiones++;
        } else
        {
            // comprobar que la secuencia rota puede ser la mayor
            if (repeticiones > secuenciaMax)
            {
                ganador = candidato;
                secuenciaMax = repeticiones;
            }

            break;
        }
    }
}

Console.WriteLine($"La secuencia de numero {ganador} se repite {secuenciaMax}");