namespace Task_1
{
    public abstract class GeometricFigure
    {
        public string Colour { get; set; }
        public GeometricFigure(string colour)
        {
            Colour = colour;
        }
        public abstract double Perimeter();
        public abstract void Angle();
        public abstract void Print();
    }
}
