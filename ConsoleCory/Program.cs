using ClassLibraryCoryTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "Testing Code Library";
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" Testing a code library to see it's uses ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;

            SampleLibrary alg = new SampleLibrary();
            double number1 = 100;
            double number2 = 50;
            double result = alg.Addition(number1, number2);
            Console.Write(number1);
            Console.Write(" + ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(result);



        }
    }
}
