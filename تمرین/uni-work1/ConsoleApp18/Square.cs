namespace ShapeSquare
{
    public class Square
    {
        public double Angle { get; set; }
        public int Sides { get; set; }
        public double X { get; set; }

        public double CalculateX()
        {
            return X;
        }

        public double CalculateAngle()
        {
            return Angle;
        }
    }
}
