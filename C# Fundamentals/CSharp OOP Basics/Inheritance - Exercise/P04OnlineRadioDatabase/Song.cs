using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


public class Song
{
    private string artistName;
    private string songName;
    private string length;

    public Song(string artistName, string songName, string length)
    {
        this.SongName = songName;
        this.ArtistName = artistName;
        this.Length = length;

    }

    public int Minutes
    {
        get
        {
            var minutes = int.Parse(this.Length.Split(':').First());

            if (minutes < 0 || minutes > 14)
            {
                throw new InvalidSongSecondsException("Song minutes should be between 0 and 14.");
            }

            return minutes;
        }
    }
    public int Seconds
    {
        get
        {
            var seconds = int.Parse(this.Length.Split(':').Last());

            if (seconds < 0 || seconds > 59)
            {
                throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
            }

            return seconds;
        }
    }

    public string Length
    {
        get { return length; }
        set
        {
            var pattern = "[0-9]+:[0-9]+";
            var match = Regex.Match(value, pattern);
            if (!match.Success)
            {
                throw new InvalidSongLengthException("Invalid song length.");
            }

            length = value;
        }
    }

    public string SongName
    {
        get { return songName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new InvalidSongException("Song name should be between 3 and 30 symbols.");
            }

            songName = value;
        }
    }

    public string ArtistName
    {
        get { return artistName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols.");
            }
            artistName = value;
        }
    }

    public int TotalSeconds()
    {
        return this.Minutes * 60 + this.Seconds;
    }
}


