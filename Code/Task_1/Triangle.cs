using System;

namespace Task_1
{
    public class Triangle : GeometricFigure
    {
        public double A, B, C;

        public Triangle(string colour, double sideA, double sideB, double sideC) : base(colour)
        {
            A = sideA;
            B = sideB;
            C = sideC;
        }
        public override double Perimeter()
        {
            return A + B + C;
        }

        public override void Angle()
        {
            double alpha = Math.Acos((Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2)) / (2 * B * C));
            double beta = Math.Acos((Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) / (2 * A * C));

            Console.WriteLine($"Розмiр кожного кута:\nКут alpha: {(alpha * 180 / Math.PI):F2}°" +
                    $"\nКут beta: {(beta * 180 / Math.PI):F2}°\nКут gamma: {180 - ((alpha * 180 / Math.PI) + (beta * 180 / Math.PI)):F2}°");
        }

        public override void Print()
        {
            Console.WriteLine($"Колiр: {Colour}");
            Console.WriteLine($"Сторони: {A}см, {B}см, {C}см");
            Console.WriteLine($"Периметр: {Perimeter()}см");
        }
    }
}