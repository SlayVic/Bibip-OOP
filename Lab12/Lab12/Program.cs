namespace Lab12
{
  internal class Vector3D
  {
    public double X { get => _x; set => _x = value; }
    private double _x;
    public double Y { get => _y; set => _y = value; }
    private double _y;
    public double Z { get => _z; set => _z = value; }
    private double _z;
    public Vector3D(double x, double y, double z)
    {
      _x = x;
      _y = y;
      _z = z;
    }
    public Vector3D()
    {
      _x = 0;
      _y = 0;
      _z = 0;
    }

    public double Length()
    {
      return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
      return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector3D operator -(Vector3D v1, Vector3D v2)
    {
      return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }

    public static Vector3D operator *(Vector3D v1, double k)
    {
      return new Vector3D(v1.X * k, v1.Y * k, v1.Z * k);
    }

    public static Vector3D operator /(Vector3D v1, double k)
    {
      return new Vector3D(v1.X / k, v1.Y / k, v1.Z / k);
    }

    public static double operator *(Vector3D v1, Vector3D v2)
    {
      return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
    }

    public override string ToString()
    {
      return $"(x:{X}, y:{Y}, z:{Z})";
    }

    public override bool Equals(Object obj)
    {
      var vec = obj as Vector3D;
      return X == vec.X && Y == vec.Y && Z == vec.Z;
    }

    public static bool operator ==(Vector3D v1, Vector3D v2)
    {
      return v1.Equals(v2);
    }

    public static bool operator !=(Vector3D v1, Vector3D v2)
    {
      return !v1.Equals(v2);
    }

    public static bool operator <(Vector3D v1, Vector3D v2)
    {
      return v1.Length() < v2.Length();
    }

    public static bool operator >(Vector3D v1, Vector3D v2)
    {
      return v1.Length() > v2.Length();
    }

    public static bool operator <=(Vector3D v1, Vector3D v2)
    {
      return v1.Length() <= v2.Length();
    }

    public static bool operator >=(Vector3D v1, Vector3D v2)
    {
      return v1.Length() >= v2.Length();
    }

    public static Vector3D operator ++(Vector3D v1)
    {
      return new Vector3D(v1.X + 1, v1.Y + 1, v1.Z + 1);
    }

    public static Vector3D operator --(Vector3D v1)
    {
      return new Vector3D(v1.X - 1, v1.Y - 1, v1.Z - 1);
    }

    public static Vector3D operator +(Vector3D v1, double k)
    {
      return new Vector3D(v1.X + k, v1.Y + k, v1.Z + k);
    }

    public static Vector3D operator -(Vector3D v1, double k)
    {
      return new Vector3D(v1.X - k, v1.Y - k, v1.Z - k);
    }

  }
  internal class Program
  {
    static void Main(string[] args)
    {

      Vector3D v1 = new Vector3D(1, 2, 3);
      Vector3D v2 = new Vector3D(4, 5, 6);
      Console.WriteLine($"v1: {v1}");
      Console.WriteLine($"v2: {v2}");
      Console.WriteLine($"v1 + v2: {v1 + v2}");
      Console.WriteLine($"v1 - v2: {v1 - v2}");
      Console.WriteLine($"v1 * 2: {v1 * 2}");
      Console.WriteLine($"v1 / 2: {v1 / 2}");
      Console.WriteLine($"v1 * v2: {v1 * v2}");
      Console.WriteLine($"v1.Length(): {v1.Length()}");
      Console.WriteLine($"v2.Length(): {v2.Length()}");
      Console.WriteLine($"v1.Equals(v2): {v1.Equals(v2)}");
      Console.WriteLine($"v1 == v2: {v1 == v2}");
      Console.WriteLine($"v1 != v2: {v1 != v2}");
      Console.WriteLine($"v1 < v2: {v1 < v2}");
      Console.WriteLine($"v1 > v2: {v1 > v2}");
      Console.WriteLine($"v1 <= v2: {v1 <= v2}");
      Console.WriteLine($"v1 >= v2: {v1 >= v2}");
    }
  }
}