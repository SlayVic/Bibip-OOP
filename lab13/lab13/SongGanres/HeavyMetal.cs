using lab13.Abstract;

namespace lab13.SongGenres
{
  internal class HeavyMetal : Song
  {
    public HeavyMetal(string name, string author, string album, int year, TimeSpan duration) : base(name, author, album, year, duration, "HeavyMetal") => _ = 0;
  }
}
