using lab13.Abstract;

namespace lab13
{
  internal class Classical : Song
  {
    public Classical(string name, string author, string album, int year, TimeSpan duration) : base(name, author, album, year, duration, "Classical") => _ = 0;

  }
}
