using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCalc
{
    internal class Program
    {
        static void getInput(out long input, out double othIn)
        {
        startInput:
            try
            {
                Console.Write("\n  Enter a number: ");
                input = Convert.ToInt64(Console.ReadLine());
                othIn = Math.Abs(Math.Sqrt(Math.Abs(input))) + 1;
            }
            catch (FormatException)
            {
                Console.WriteLine("  --- Invalid ---");
                goto startInput;
            }
            catch (OverflowException)
            {
                Console.WriteLine("  -- Too Large --");
                goto startInput;
            }
        }
        static void checkPrime(long testInt, double sqrtInt)
        {
            int count = 2;
            for (; count <= sqrtInt; count++)
            {
                if ((testInt % count) == 0)
                {
                    break;
                }
            }
            if (testInt == 2)
                Console.WriteLine("  ---- Prime ----");
            else if (count > sqrtInt)
                Console.WriteLine("  ---- Prime ----");
            else
                Console.WriteLine("  -- Not Prime --");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("     ||\\\\ ||\\\\ || |\\  /| ||||   ////   //|| ||    ////");
            Console.WriteLine("     ||// ||// || ||\\/|| |||   ||     //_|| ||   ||");
            Console.WriteLine("     ||   ||\\\\ || |||||| ||||   \\\\\\\\ //  || ||||  \\\\\\\\  V.1");
            Console.WriteLine("------------------< WORKS WITH INTEGERS >------------------");
            bool cont = true;
            while (cont)
            {
                getInput(out long numOne, out double numTwo);
                checkPrime(numOne, numTwo);
                Console.WriteLine();
            askAgain:
                Console.Write("  // Continue? \n     (y/n): ");
                string contcont = Console.ReadLine();
                switch (contcont)
                {
                    case "y":
                        cont = true;
                        break;
                    case "n":
                        cont = false;
                        break;
                    default:
                        goto askAgain;
                }
            }
        }
    }
}

