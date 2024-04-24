using System;

namespace Task_1
{
    public class Quadrilateral : GeometricFigure
    {        
        public double A, B, C, D;
        public Quadrilateral(string colour, double sideA, double sideB, double sideC, double sideD) : base(colour)
        {
            A = sideA;
            B = sideB;
            C = sideC;
            D = sideD;
        }

        public override double Perimeter()
        {
            return A + B + C + D;
        }

        public override void Angle()
        {
            if (A + B <= C || A + C <= D || B + C <= D || A + D <= B)
            {
                Console.WriteLine("З заданих сторін неможливо утворити чотирикутник.");
                return;
            }
            else
            {
                double alpha = Math.Acos((Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2)) / (2 * B * C));
                double beta = Math.Acos((Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) / (2 * A * C));
                double gamma = Math.Acos((Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) / (2 * A * B));
                double delta = 180 - (alpha + beta + gamma);

                Console.WriteLine($"Розмiр кожного кута:\nКут alpha: {(alpha * 180 / Math.PI):F2}°" +
                    $"\nКут beta: {(beta * 180 / Math.PI):F2}°\nКут gamma: {(gamma * 180 / Math.PI):F2}°\nКут delta: {delta:F2}°");
            }
        }

        public override void Print()
        {
            Console.WriteLine($"Колiр: {Colour}");
            Console.WriteLine($"Сторони: {A}см, {B}см, {C}см, {D}см");
            Console.WriteLine($"Периметр: {Perimeter()}см");
        }
    }
}
