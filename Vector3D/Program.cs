public struct Vector3D
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Vector3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public Vector3D Multiply(double scalar)
    {
        return new Vector3D(X * scalar, Y * scalar, Z * scalar);
    }

    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector3D operator -(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}

public class Program
{
    public static void Main()
    {
        Vector3D v1 = new Vector3D(1.0, 2.0, 3.0);
        Vector3D v2 = new Vector3D(4.0, 5.0, 6.0);

        Vector3D v1Multiplied = v1.Multiply(2.0);
        Console.WriteLine($"v1 multiplied by 2: {v1Multiplied}");

        Vector3D vAdd = v1 + v2;
        Console.WriteLine($"v1 + v2: {vAdd}");

        Vector3D vSubtract = v1 - v2;
        Console.WriteLine($"v1 - v2: {vSubtract}");
    }
}
