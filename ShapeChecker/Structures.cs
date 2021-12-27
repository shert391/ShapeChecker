namespace ShapeChecker
{
    public struct Vector
    {
        public double X { get; }
        public double Y { get; }
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    public struct Point
    {
        public double X { get; }
        public double Y { get; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    public struct Segment
    {
        public Point PointOne { get; }
        public Point PointTwo { get; }

        public Segment(Point pointone, Point pointtwo)
        {
            PointOne = pointone;
            PointTwo = pointtwo;
        }
    }
}
