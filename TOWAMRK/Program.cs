using System;

namespace TOWAMRK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Równania kwadratowe");

            double a, b, c;

            Console.WriteLine("podaj współczynniki ax^2+bx+c=0");

            Console.WriteLine("podaj a");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("podaj b");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("podaj c");
            c = Double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {

                double x1 = (-b - Math.Sqrt(delta)) / 2 / a;
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            } else if (delta == 0)
            {
                double x = (-b ) / (2 * a);

                Console.WriteLine("podwojny pierwiastek x={0}", x);

            }
            else
            {
                Console.WriteLine("brak rozwiazan");
            }
        }
    }
}
