using System;

namespace Task_1
{
    internal class Oval : GeometricFigure, IContainsPoint
    {
        public double r, R, cX, cY;
        public Oval(string colour, double semiMajorAxis, double semiMinorAxis, double centerX, double centerY) : base(colour)
        {
            R = semiMajorAxis;
            r = semiMinorAxis;
            cX = centerX;
            cY = centerY;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(R, 2) + Math.Pow(r, 2) / 2));
        }

        public override void Angle()
        {
            Console.WriteLine("Кути вiдсутнi");
        }

        public bool ContainsPoint(double x, double y)
        {
            // Формула для еліпса: ((x - centerX) / radiusX) ^ 2 + ((y - centerY) / radiusY) ^ 2 <= 1
            return Math.Pow((x - cX) / (double)R, 2) + Math.Pow((y - cY) / (double)r, 2) <= 1;
        }

        public override void Print()
        {
            Console.WriteLine($"Колiр: {Colour}");
            Console.WriteLine($"Напiввелика вiсь: {R}см \nНапiвмала вiсь: {r}см");
            Console.WriteLine($"Периметр: {Perimeter():F2}см");
        }
    }
}
