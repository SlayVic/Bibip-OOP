namespace lab16
{
  class Program
  {
    static void Main(string[] args)
    {
      Integral integral1 = new Integral(5, 10, 10000, x => 1 / (Math.Pow(x, 1.0 / 3.0)));
      Console.WriteLine("integral1 = " + integral1);

      Integral integral2 = new Integral(5, 10, 10000, x => 1 / (Math.Sqrt(x * x)));
      Console.WriteLine("integral2 = " + integral2);

      Integral integral3 = new Integral(5, 10, 10000, x => Math.Cos(x));
      Console.WriteLine("integral3 = " + integral3);

      var eve = new MyEventClass();
      bool stop = false;
      eve.SEvent += () => Console.WriteLine("\bShashkov Yaroslav");
      eve.EscEvent += () => stop = true;
      while (!stop)
      {
      }
    }
  }
}