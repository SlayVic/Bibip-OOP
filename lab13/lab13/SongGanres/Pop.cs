using lab13.Abstract;

namespace lab13
{
  internal class Pop : Song
  {
    public Pop(string name, string author, string album, int year, TimeSpan duration) : base(name, author, album, year, duration, "Pop") => _ = 0;
  }
}
