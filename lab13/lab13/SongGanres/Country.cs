using lab13.Abstract;

namespace lab13
{
  internal class Country : Song
  {
    public Country(string name, string author, string album, int year, TimeSpan duration) : base(name, author, album, year, duration, "Country") => _ = 0;
  }
}
