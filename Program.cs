using System.ComponentModel;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Pr05_Lommeregner
{
    internal class Program
    {

        static void Main(string[] args)
        {
         Calculator calc = new Calculator();
            Console.WriteLine("Skriv første tal");
            int x = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Indtast Operatør");
            string inputoperator = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Indtast anden tal");
            int y = int.Parse(Console.ReadLine());
            Console.Clear();


            while (inputoperator != "" || x != 0 || y != 0)
            {
                switch (inputoperator)
                {
                    case "+":
                        Console.WriteLine("Resultatet er ");
                        Console.WriteLine(calc.Add(x, y));
                        int a = x;
                        break;

                    case "-":
                        Console.WriteLine("Resultatet er ");
                        Console.WriteLine(calc.Minus(x, y));

                        break;

                    case "*":
                        Console.WriteLine("Resultatet er ");
                        Console.WriteLine(calc.Multiply(x, y));
                        break;

                    case "/":
                        Console.WriteLine("Resultatet er ");
                        Console.WriteLine(calc.Divide(x, y));
                        break;

                    default:
                        Console.WriteLine("Forkert input");
                        break;
                }
            }
        }
    }
}
