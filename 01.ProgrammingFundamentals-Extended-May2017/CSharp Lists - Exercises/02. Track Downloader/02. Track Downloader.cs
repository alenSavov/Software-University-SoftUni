using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blackList = Console.ReadLine().Split().ToList();
            List<string> finalTrackList = new List<string>();

            string trackSongs = Console.ReadLine();

            while (trackSongs != "end")
            {
                finalTrackList.Add(trackSongs);

                for (int i = 0; i < blackList.Count; i++)
                {
                    if (trackSongs.Contains(blackList[i]))
                    {
                        finalTrackList.RemoveAt(finalTrackList.Count - 1);
                        break;
                    }

                }
                trackSongs = Console.ReadLine();
            }
            finalTrackList.Sort();
            Console.WriteLine(string.Join(Environment.NewLine,finalTrackList));
        }

    }
}
