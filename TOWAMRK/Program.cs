using System;

namespace TOWAMRK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Równania kwadratowe");

            double a = 1;
            double b = 0;
            double c = -9;


            double delta = b * b - 4 * a * c;

            if (delta >= 0)
            {

                double x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b + Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            } else
            {
                Console.WriteLine("brak rozwiazan");
            }
        }
    }
}
