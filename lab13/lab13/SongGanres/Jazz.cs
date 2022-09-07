using lab13.Abstract;

namespace lab13.SongGenres
{
  internal class Jazz : Song
  {
    public Jazz(string name, string author, string album, int year, TimeSpan duration) : base(name, author, album, year, duration, "Jazz") => _ = 0;
  }
}
