using lab13.Abstract;

namespace lab13.SongGenres
{
  internal class Rock : Song
  {
    public Rock(string name, string author, string album, int year, TimeSpan duration) : base(name, author, album, year, duration, "Rock") => _ = 0;

  }
}
