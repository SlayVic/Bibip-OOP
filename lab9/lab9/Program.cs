using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static double Func(double x, double y, double z)
    {
      return Math.Log10(Math.Sqrt(y * y * y)) * z + x;
    }

    static void PrintRangeStupidAF(double x)
    {
      Console.Write(x switch
      {
        < -10 => "x is less than -10",
        < -1 and > -10 => "x is between -10 and -1",
        < 0 and > -1 => "x is between -1 and 0",
        > 1 and < 10 => "x is between 1 and 10",
        > 10 => "x is greater than 10",
        _ => "x is not between -10 and 10"
      });

      Console.WriteLine("     " + (x switch
      {
        >= 0 => "positive",
        < 0 => "negative",
        _ => "WTF???"
      }));
    }
    static double AreaOfSquareTriangle(double a, double angle)
    {
      return a * a * Math.Tan(angle * Math.PI / 180) / 2;
    }

    static void Main(string[] args)
    {
      while (true)
      {
        double x, y, z;
        Console.Write("Enter x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        y = double.Parse(Console.ReadLine());
        Console.Write("Enter z: ");
        z = double.Parse(Console.ReadLine());
        Console.WriteLine("Result: {0}", Func(x, y, z));
        PrintRangeStupidAF(x);
        Console.Write("Continue? (y/n): ");
        if (Console.ReadLine() != "y")
          break;
      }

      Console.Write("Enter a: ");
      double a = double.Parse(Console.ReadLine());
      Console.Write("Enter angle: ");
      double angle = double.Parse(Console.ReadLine());
      Console.WriteLine("Area of a square triangle: {0}", AreaOfSquareTriangle(a, angle));
    }
  }
}