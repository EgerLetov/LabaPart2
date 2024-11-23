public class Point
{
    private double x;
    private double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double Dist(Point P)
    {
        return Math.Sqrt(Math.Pow(this.x - P.x, 2) + Math.Pow(this.y - P.y, 2));
    }

    public override string ToString()
    {
        return $"({x}, {y})";
    }
    public static Point operator --(Point op)
    {
        return new Point(op.x - 1, op.y - 1);
    }
    public static Point operator -(Point op)
    {
        return new Point(op.y, op.x);
    }

    public static explicit operator double(Point c)
    {
        return c.y;
    }
    public static implicit operator int(Point c)
    {
        return Convert.ToInt32(Math.Floor(c.x));
    }

    public static Point operator -(Point p, long val)
    {
        //Console.WriteLine(p.x- value);
        return new Point(p.x - val, p.y);
    }

    public static Point operator -(long val, Point p)
    {
        return new Point(p.x, p.y - val);
    }
    public static double operator -(Point p1, Point p2)
    {
        double distance = Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        return distance;
    }
}
