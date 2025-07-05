/*

*******  7
******   6
*****   5
****   4
***    3
**    2
*     1

*/

for (int i = 7; i >= 1; i--)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

/*

* * * * * * *  7|0
 * * * * * *   6|1
  * * * * *    5|2
   * * * *     4|3
    * * *      3|4
     * *       2|5
      *        1|6

*/


for (int i = 7; i >= 1; i--)
{
    int espacios = 7 - i;

    for (int k = 0; k < espacios; k++) 
    { 
        Console.Write(" "); 
    }

    for (int j = 0; j < i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}


/*

*******  7|0
 *****   5|1
  ***    3|2
   *     1|3

*/

for (int i = 7, espacio = 0; i >= 1; i -= 2, espacio++)
{
    for (int k = 0; k < espacio; k++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

/*

* * * * * * *  7|0 i=0 
*           *  2|5 i=1
*           *  2|5 i=2
*           *  2|5 i=3
*           *  2|5 i=4
*           *  2|5 i=5
* * * * * * *  7|0 i=6

*/

int dimension = 20;
for (int i = 0; i < dimension; i++)
{
    // Las lineas completas
    if (i == 0 || i == dimension - 1)
    {
        for (int j = 0; j < dimension; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    } else
    {
        for (int j = 0; j < dimension; j++)
        {
            if (j == 0 || j == dimension - 1)
            {
                Console.Write("* ");
            } else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }
}