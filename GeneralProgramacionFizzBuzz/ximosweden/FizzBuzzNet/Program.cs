using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzNet
{
    class Program
    {
        /// <summary>
        /// Escribe, en el lenguaje de programación que desees, un programa que muestre en pantalla los números del 1 al 100, 
        /// sustituyendo los múltiplos de 3 por el palabro “Fizz” y, a su vez, los múltiplos de 5 por “Buzz”. 
        /// Para los números que, al tiempo, son múltiplos de 3 y 5, utiliza el combinado “FizzBuzz”.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                System.Console.Write(i + " - ");
                if (i % 5 == 0)
                {
                    if (i % 3 == 0) { System.Console.WriteLine("FizzBuzz"); }
                    else System.Console.WriteLine("Fizz");
                }
                else if (i % 3 == 0) { System.Console.WriteLine("Buzz"); }
                else
                {
                    System.Console.WriteLine("");
                }
            }

            System.Threading.Thread.Sleep(5000);
        }
    }
}
