int[] arr = { 5, 5, 5, 4};
int secuenciaMaxima = 0;
int posicionInicialMaxima = 0;
int posicionFinalMaxima = 0;

for (int i = 0; i < arr.Length - 1; i++)
{
    int posicionInicial = i;
    int posicionFinal = i;
    int diferencia = 1;
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j] - diferencia)
        {
            // secuencia funciona
            posicionFinal = j;
        }
        else
        {
            // secuencia se ha roto
            // optimizacion: i deberia tomar el valor de j
            if (posicionInicial == posicionFinal)
            {
                break;
            }
        }
        diferencia++;
    }

    int secuencia = posicionFinal - posicionInicial + 1;
    if (secuenciaMaxima < secuencia)
    {
        secuenciaMaxima = secuencia;
        posicionInicialMaxima = posicionInicial;
        posicionFinalMaxima = posicionFinal;
    }
}

// Encontrar el subarreglo
int tamaño = posicionFinalMaxima - posicionInicialMaxima + 1;
var solucion = new int[tamaño];
var indice = 0;
for (int i = posicionInicialMaxima; i <= posicionFinalMaxima; i++)
{
    solucion[indice++] = arr[i];
}

Console.WriteLine(string.Join(", ", solucion));
