namespace lab16
{
  internal class Integral
  {
    private readonly double _a;
    private readonly double _b;
    private readonly int _n;
    private readonly Func<double, double> _f;

    private double? _result = null;
    public double Result
    {
      get
      {
        _result ??= Calculate();
        return _result.Value;
      }
    }

    public Integral(double a, double b, int n, Func<double, double> f)
    {
      _a = a;
      _b = b;
      _n = n;
      _f = f;
    }

    public double Calculate()
    {
      var h = (_b - _a) / _n;
      var sum = 0.0;
      for (var i = 0; i < _n; i++)
      {
        var x = _a + i * h;
        sum += _f(x);
      }

      return h * sum;
    }

    public override string ToString()
    {
      return $"{Result}";
    }
  }
}
