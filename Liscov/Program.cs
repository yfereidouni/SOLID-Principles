using System;

namespace Liscov
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle("Triangle", 3, 3);

            Console.WriteLine(triangle.DisplayDetails());

            Console.WriteLine("------------------------------------------------------------");
            
            Squre squre = new Squre("Squre", 3, 3);

            Console.WriteLine(squre.DisplayDetails());

            Console.WriteLine("------------------------------------------------------------");

            Rectangle rectangle = new Rectangle("Rectangle", 3, 3);

            Console.WriteLine(rectangle.DisplayDetails());

        }
    }
}
