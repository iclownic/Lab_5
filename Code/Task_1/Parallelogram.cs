using System;

namespace Task_1
{
    internal class Parallelogram : Quadrilateral
    {
        public Parallelogram(string colour, double A, double B, double C, double D) : base(colour, A, B, C, D) { }

        public override void Angle()
        {
            double d = 6;
            double alpha = Math.Acos((Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(d, 2)) / (2 * A * B));
            double deegreesAlpha = alpha * 180 / Math.PI;

            Console.WriteLine($"Розмiр кожного кута:\nКут alpha: {deegreesAlpha:F2}°" +
                    $"\nКут beta: {180 - deegreesAlpha:F2}°\nКут gamma: {deegreesAlpha:F2}°\nКут delta: {180 - deegreesAlpha:F2}°");
        }
        public override void Print()
        {
            base.Print();
        }
    }
}
