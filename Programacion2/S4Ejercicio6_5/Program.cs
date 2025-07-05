// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55,
// 0, 1, 2, 3, 4, 5, 6, 7,  8,  9,  10


// n = 10 -> 55


int n = 10;
int ultimo = 1;
int penultimo = 0;

if (n == 0) ultimo = 0;

for (int i = 2; i <= n; i++)
{
    int nuevo = ultimo + penultimo;
    penultimo = ultimo;
    ultimo = nuevo;
}

Console.WriteLine($"El fibonacci #{n} es {ultimo}");