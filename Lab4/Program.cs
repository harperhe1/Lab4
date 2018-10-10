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
            do
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
                

                Console.WriteLine("Continue?(y/n)");
            } while (Console.ReadLine() == "y");
        }
    }
}
