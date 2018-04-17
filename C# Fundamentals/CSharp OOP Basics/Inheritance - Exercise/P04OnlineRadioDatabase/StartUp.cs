using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    static void Main(string[] args)
    {
        var songs = new List<Song>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split(';');

            try
            {
                var artistName = tokens[0];
                var songName = tokens[1];
                var length = tokens[2];

                var song = new Song(artistName, songName, length);

                var minutes = song.Minutes;
                var seconds = song.Seconds;

                songs.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine($"Songs added: {songs.Count}");

        var totalSeconds = songs.Sum(s => s.TotalSeconds());

        TimeSpan t = TimeSpan.FromSeconds(totalSeconds);

        Console.WriteLine($"Playlist length: {t.Hours}h {t.Minutes}m {t.Seconds}s");
    }

}


