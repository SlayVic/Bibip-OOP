using lab13.Abstract;
using lab13.SongGenres;

namespace lab13
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create array of random songs and random genres
      List<Song> playlist = new List<Song>();
      // add country
      playlist.Add(new Country("Country song", "Country author", "Country album", 2020, new TimeSpan(0, 3, 30)));
      // add Electric
      playlist.Add(new Electronic("Electronic song", "Electronic author", "Electronic album", 2020, new TimeSpan(0, 2, 30)));
      //add rock
      playlist.Add(new Rock("Rock song", "Rock author", "Rock album", 2020, new TimeSpan(0, 4, 30)));
      //add pop
      playlist.Add(new Pop("Pop song", "Pop author", "Pop album", 2020, new TimeSpan(0, 2, 43)));
      // add Canon in D
      playlist.Add(new Classical("Canon in D", "Johann Pachelbel", "Canon in D", 2020, new TimeSpan(0, 5, 03))); // https://www.youtube.com/watch?v=Ptk_1Dc2iPY
      // add jazz
      playlist.Add(new Jazz("Jazz song", "Jazz author", "Jazz album", 2020, new TimeSpan(0, 3, 30)));
      // add heavy metal
      playlist.Add(new HeavyMetal("Heavy Metal song", "Heavy Metal author", "Heavy Metal album", 2020, new TimeSpan(0, 3, 30)));

      // print playlist
      Console.WriteLine($"Playlist (songs: {playlist.Count}):");
      foreach (var song in playlist)
      {
        Console.WriteLine(song);
      }
      // calculate playlist duration
      TimeSpan playlistDuration = new TimeSpan();
      foreach (var song in playlist)
      {
        playlistDuration += song.Duration;
      }
      Console.WriteLine($"Playlist duration: {playlistDuration}\n\n");


      List<dynamic> latePlaylist = new List<dynamic>();
      // add country
      latePlaylist.Add(new Country("Country song", "Country author", "Country album", 2020, new TimeSpan(0, 3, 30)));
      // add Electric
      latePlaylist.Add(new Electronic("Electronic song", "Electronic author", "Electronic album", 2020, new TimeSpan(0, 2, 30)));
      //add rock
      latePlaylist.Add(new Rock("Rock song", "Rock author", "Rock album", 2020, new TimeSpan(0, 4, 30)));
      //add pop
      latePlaylist.Add(new Pop("Pop song", "Pop author", "Pop album", 2020, new TimeSpan(0, 2, 43)));
      // add Canon in D
      latePlaylist.Add(new Classical("Canon in D", "Johann Pachelbel", "Canon in D", 2020, new TimeSpan(0, 5, 03))); // https://www.youtube.com/watch?v=Ptk_1Dc2iPY
      // add jazz
      latePlaylist.Add(new Jazz("Jazz song", "Jazz author", "Jazz album", 2020, new TimeSpan(0, 3, 30)));
      // add heavy metal
      latePlaylist.Add(new HeavyMetal("Heavy Metal song", "Heavy Metal author", "Heavy Metal album", 2020, new TimeSpan(0, 3, 30)));

      // print playlist
      Console.WriteLine($"Late bind Playlist (songs: {latePlaylist.Count}):");
      foreach (var song in latePlaylist)
      {
        Console.WriteLine(song);
      }
      // calculate playlist duration
      playlistDuration = new TimeSpan();
      foreach (var song in latePlaylist)
      {
        playlistDuration += song.Duration;
      }
      Console.WriteLine($"Playlist duration: {playlistDuration}\n\n");
    }
  }
}