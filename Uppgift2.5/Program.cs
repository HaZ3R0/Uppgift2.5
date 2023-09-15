using System;
namespace Uppgift_2._5
{
    class Proram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en multiplication med två tal som båda har en decimal i sig.");
            string multiplication = Console.ReadLine();

            int gångerindex = multiplication.IndexOf("*");
            string tal1text = multiplication[..gångerindex];
            string tal2text = multiplication[(gångerindex + 1)..];
            double tal1 = double.Parse(tal1text);
            double tal2 = double.Parse(tal2text);
            double summa = tal1 * tal2;
            Console.WriteLine(multiplication + "=" + summa);
            Console.ReadKey();
        }
    }
}