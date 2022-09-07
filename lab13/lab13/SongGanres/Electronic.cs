using lab13.Abstract;

namespace lab13.SongGenres
{
  internal class Electronic : Song
  {
    public Electronic(string name, string author, string album, int year, TimeSpan duration) : base(name, author, album, year, duration, "Electronic") => _ = 0;
  }
}
