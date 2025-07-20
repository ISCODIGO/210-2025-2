public class Test
{
    static void Main()
    {
        Console.WriteLine("probando codigo...");
        try
        {
            Random d= new Random();
            d.n

            string fileName = "WrongFileName.txt";
            ReadFile(fileName);
        }

        catch (Exception e)
        {
            throw new ApplicationException("Smth. bad happened", e);
        }
    }

    static void ReadFile(string fileName)
    {
        TextReader reader = new StreamReader(fileName);
        string line = reader.ReadLine();
        Console.WriteLine(line);
        reader.Close();
    }
}