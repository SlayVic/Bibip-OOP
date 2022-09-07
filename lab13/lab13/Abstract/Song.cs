

namespace lab13.Abstract
{
  internal abstract class Song
  {
    public string Name { get; init; }
    public string Author { get; init; }
    public string Album { get; init; }
    public int Year { get; init; }
    public TimeSpan Duration { get; init; }
    public string Genre { get; init; }

    protected Song(string name, string author, string album, int year, TimeSpan duration, string genre)
    {
      Name = name;
      Author = author;
      Album = album;
      Year = year;
      Duration = duration;
      Genre = genre;
    }

    public override string ToString()
    {
      return $"Name: {Name}, Author: {Author}, Album: {Album}, Year: {Year}, Duration: {Duration}, Genre: {Genre}";
    }

    //equals overload
    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }

      Song song = (Song)obj;
      return Name == song.Name && Author == song.Author && Album == song.Album && Year == song.Year &&
             Duration == song.Duration && Genre == song.Genre;
    }

  }
}
