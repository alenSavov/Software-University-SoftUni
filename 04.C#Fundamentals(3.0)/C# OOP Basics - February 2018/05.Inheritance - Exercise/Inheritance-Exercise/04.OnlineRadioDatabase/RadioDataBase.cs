using System;
using System.Collections.Generic;
using System.Text;


public class RadioDataBase
{    
    private string artisName;
    private string songName;
    private int minutesLength;
    private int secondsLength;

    public RadioDataBase(string artisName, string songName, int minutesLength, int secondsLength)
    {
        this.ArtistName = artisName;
        this.SongName = songName;
        this.MinutesLength = minutesLength;
        this.SecondsLength = secondsLength;
    }

    private string ArtistName
    {
        get { return artisName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            artisName = value;
        }
    }

    private string SongName
    {
        get { return songName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException("Invalid song."); 
            }
            songName = value;
        }
    }

    private int MinutesLength
    {
        get { return minutesLength; }
        set
        {
            if (value < 0 || value > 14)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }
            minutesLength = value;
        }
    }

    private int SecondsLength
    {
        get { return secondsLength; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");               
            }
            secondsLength = value;
        }
    }
        

}


