using System;

namespace Task_1
{
    internal class Square : Quadrilateral, IContainsPoint
    {
        public double tX, tY, sL;
        public Square(string colour, double A, double B, double C, double D, double topLeftX, double topLeftY, double sideLength)
            : base(colour, A, B, C, D)
        {
            tX = topLeftX;
            tY = topLeftY;
            sL = sideLength;
        }

        public override void Angle()
        {
            Console.WriteLine("Розмiр кожного кута дорiвнює 90°");
        }

        public bool ContainsPoint(double x, double y)
        {
            return (x >= tX && x <= (tX + sL) && y >= tY && y <= (tY + sL));
            //return x >= topLeftX && x <= topLeftX + sideLength && y >= topLeftY && y <= topLeftY + sideLength;
        }

        public override void Print()
        {
            base.Print();
        }
    }
}
