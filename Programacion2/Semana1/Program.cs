using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Frontend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("hola mundo");
            //int x = Console.Read();
            Console.WriteLine(x);

            // enteros
            Int64 y = 0;
            Byte b = 0;
            SByte s = 0;
            int x2 = 0;  // Un alias de Int32
            long y2 = 0; // Un alias de Int64
            

            Console.WriteLine("Rango de unsigned int...");
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);*/

            /*Console.WriteLine("Rango de int...");
            Console.WriteLine("Minimo: " + int.MinValue);
            Console.WriteLine("Maximo: " + int.MaxValue);
            int entero = int.MaxValue;
            
            entero += 2524;  // entero = entero + 2524;
            Console.WriteLine("Max + 1: " + entero);

            long entero2 = 5_000_000_000;

            
            Console.WriteLine(0.0 / 0.0);

            float floatPI   = 3.141592653589793238f;
            double doublePI = 3.141592653589793238;
            decimal decimalPI = 3.141592653589793238m;

            // Print the results on the console
            Console.WriteLine("Float PI is: " + floatPI);
            Console.WriteLine("Double PI is: " + doublePI);
            Console.WriteLine("Decimal PI is: " + decimalPI);

            char c = (char)97;
            Console.WriteLine(c);

            int e1 = '@';
            Console.WriteLine(e1);*/

            // double -> sbyte
            double a1 = 32.9999;
            sbyte b1 = (sbyte)a1;
            Console.WriteLine(b1);

            // sbyte -> double
            a1 = b1;
            Console.WriteLine(a1);

            uint c1 = 10;
            int d1 = (int)c1;
            Console.WriteLine(d1);

            c1 = (uint)d1;

            //int n1 = int.Parse("106jk");
            int.TryParse("106KJHKJG", out int n1);
            Console.WriteLine(n1);
        }
    }
}
