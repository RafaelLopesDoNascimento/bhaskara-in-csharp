using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Baskara Form
            
            string[] values = Console.ReadLine().Split(' ');
            double a, b, c, delta,x1, x2;


            if (values.Length < 4 && values.Length > 2)
            {
                a = double.Parse(values[0]);
                b = double.Parse(values[1]);
                c = double.Parse(values[2]);

                delta = Math.Pow(b, 2) - 4 * a * c;

                delta = Math.Sqrt(delta);
                Console.WriteLine("Raiz do delta:");
                Console.WriteLine(delta);

                if (delta > 0)
                {
                    x1 = (-b + delta) / (2 * a);
                    x2 = (-b - delta) / (2 * a);

                    Console.WriteLine("Your X1: " + x1);
                    Console.WriteLine("Your X2: " + x2);
                } 
                else
                {
                    Console.WriteLine("Impossivel de calcular");
                }
            }
            else
            {
                Console.WriteLine("Values is too long or it's enought");
            }
        }
    }
}
