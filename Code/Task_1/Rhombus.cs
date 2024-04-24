using System;

namespace Task_1
{
    internal class Rhombus : Parallelogram, IContainsPoint
    {
        public double cX, cY, d1, d2;
        public Rhombus(string colour, double A, double B, double C, double D, double centerX, double centerY, double MajorDiagonal, double MinorDiagonal) 
            : base(colour, A, B, C, D)
        {
            cX = centerX;
            cY = centerY;
            d1 = MajorDiagonal;
            d2 = MinorDiagonal;
        }
        public override void Angle()
        {
            double d1 = 2;
            double alpha = Math.Cos((Math.Pow(d1, 2) / 2 * Math.Pow(A, 2)) - 1);
            double deegreesAlpha = alpha * 180 / Math.PI;

            Console.WriteLine($"Розмiр кожного кута:\nКут alpha: {deegreesAlpha:F2}°" +
                    $"\nКут beta: {180 - deegreesAlpha:F2}°\nКут gamma: {deegreesAlpha:F2}°\nКут delta: {180 - deegreesAlpha:F2}°");
        }

        public bool ContainsPoint(double x, double y)
        {
            // Щоб перевірити, чи точка лежить всередині ромба, достатньо перевірити, чи вона лежить всередині прямокутника, описаного навколо ромба.
            return Math.Abs(x - cX) / d1 + Math.Abs(y - cY) / d2 <= 1;
        }

        public override void Print()
        {
            base.Print();
        }
    }
}