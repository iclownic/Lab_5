using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrilateral quadrilateral = new Quadrilateral("Червоний", 5, 6, 3, 7);
            Console.WriteLine("*ЧОТИРИКУТНИК*");
            quadrilateral.Print();
            quadrilateral.Angle();
            Console.WriteLine();

            Triangle triangle = new Triangle("Жовтий", 12, 15, 13);
            Console.WriteLine("*ТРИКУТНИК*");
            triangle.Print();
            triangle.Angle();
            Console.WriteLine();

            Parallelogram parallelogram = new Parallelogram("Зелений", 4, 8, 4, 8);
            Console.WriteLine("*ПАРАЛЕЛОГРАМ*");
            parallelogram.Print();
            parallelogram.Angle();
            Console.WriteLine();

            Square square = new Square("Блакитний", 24, 24, 24, 24, -2, -2, 4);
            Console.WriteLine("*КВАДРАТ*");
            square.Print();
            square.Angle();
            Console.WriteLine();

            Rhombus rhombus = new Rhombus("Рожевий", 2, 2, 2, 2, 0, 0, 3, 2);
            Console.WriteLine("*РОМБ*");
            rhombus.Print();
            rhombus.Angle();
            Console.WriteLine();

            Oval oval = new Oval("Фiолетовий", 7, 5, 0, 0);
            Console.WriteLine("*ОВАЛ*");
            oval.Print();
            oval.Angle();
            Console.WriteLine();

            Console.WriteLine($"Чи належить точка на координатнiй осi вказанiй фiгурi? \nТочка (1, 1)");
            PrintContainsPointResult(rhombus, square, oval, 1, 1);

            Console.WriteLine($"\nЧи належить точка на координатнiй осi вказанiй фiгурi? \nТочка (3, 3)");
            PrintContainsPointResult(rhombus, square, oval, 3, 3);

            static void PrintContainsPointResult(Rhombus rhombus, Square square, Oval oval, double x, double y)
            {
                Console.WriteLine($"Ромб: {rhombus.ContainsPoint(x, y)}");
                Console.WriteLine($"Квадрат: {square.ContainsPoint(x, y)}");
                Console.WriteLine($"Овал: {oval.ContainsPoint(x, y)}");
            }
        }
    }
}
