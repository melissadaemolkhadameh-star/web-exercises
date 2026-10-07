namespace ShapeRectangle
{
    public class Rectangle
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double Area
        {
            get
            {
                return X * Y;
            }
        }

        public double Perimeter
        {
            get
            {
                return 2 * (X + Y);
            }
        }

        public double CalculateArea()
        {
            return X * Y;
        }

        public double CalculatePerimeter()
        {
            return 2 * (X + Y);
        }
    }
}
