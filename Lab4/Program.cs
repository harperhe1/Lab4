using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAgain;
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("Enter an integer:");

                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Number    " + "Squared   " + "Cubed");
                Console.WriteLine("======    " + "======    " + "======    ");

                for (int i = 1; i <= num; i++)
                {
                    int square = i * i;
                    int cube = i * i * i;
                    Console.WriteLine(i + ("        ") + square + ("       ") + cube);
                }

                bool cont2 = true;
                while (cont2)
                {
                    Console.WriteLine("Continue?(y/n)");
                    doAgain = Console.ReadLine().ToLower();
                    if (doAgain == "y")
                    {
                        cont2 = false;
                    }
                    else if (doAgain == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        cont2 = false;
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again!");
                    }



                }
            }
            Console.ReadLine();
        }
    }
}

