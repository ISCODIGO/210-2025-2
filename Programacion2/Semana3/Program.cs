using System.Text;

int a = 10;
int b = 20;
int c = 10;

// Operadores comparacion
Console.WriteLine(a == b);  // false
Console.WriteLine(a != b);  // true
Console.WriteLine(a > b);  // false
Console.WriteLine(a < b);  // true
Console.WriteLine(a >= c);  // true
Console.WriteLine(a <= b);  // true

bool x = false;
bool y = true;

Console.WriteLine(x && y);  // false
Console.WriteLine(x || y);  // true
Console.WriteLine(!x);      // true
Console.WriteLine(!!x);     // false
Console.WriteLine(!x || y); // true

Console.WriteLine((b > c) || a == b/0);

Console.WriteLine(5 | 6);
Console.WriteLine(5 & 6);

// Objects / string
string s1 = "beer";
string s2 = s1;

string s3 = "bee";
s3 = s3 + "r";


Console.WriteLine(s1 == s2);
Console.WriteLine(s2 == s3);  // C#: true Java: false

Console.WriteLine("Revisar...");
Console.WriteLine((object)s1 == s2 as object);  // true
Console.WriteLine((object)s2 == s3 as object);  // C#: true Java: false

string cadena = "";
StringBuilder sb = new StringBuilder();
for (int i = 0; i < 10_000_000; i++)
{
    //cadena += i.ToString();
    sb.Append(i);
}

Console.WriteLine(sb.ToString());