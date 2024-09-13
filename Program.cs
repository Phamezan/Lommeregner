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

            double x = 0;
            string inputoperator = "";
            bool førstetal = true;

            while (true)
            { 
                if (førstetal)
                {
                    Console.Write("Indtast tal ");
                    x = double.Parse(Console.ReadLine());
                    førstetal = false;
                    Console.Clear();
                }        
                    Console.Write("Indtast operatør (+ * - /) ");
                    inputoperator = Console.ReadLine();
                    Console.Clear();

                    Console.Write("Indtast tal ");
                    double y = double.Parse(Console.ReadLine());
                    Console.Clear();
                {
                    switch (inputoperator)
                    {
                        case "+":
                            x = (calc.Add(x,y));
                            break;

                        case "-":
                            x = (calc.Minus(x,y));
                            break;

                        case "*":              
                            x = (calc.Multiply(x, y));
                            break;

                        case "/":

                            if (y == 0)
                            {
                                Console.WriteLine("Fejl! Du kan ikke dividere med 0!");
                            } 
                            else
                            {
                                x = (calc.Divide(x, y));
                            }
                            break;

                        default:
                            Console.WriteLine("Forkert input");
                            continue;
                    }
                    Console.WriteLine("= " + x + " ");
                }
            }
        }
   }
}