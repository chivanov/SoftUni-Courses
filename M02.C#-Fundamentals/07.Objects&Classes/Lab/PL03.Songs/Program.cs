using System;
using System.Collections.Generic;

namespace PL03.Songs
{
    class Song
    {
        public string Name { get; set; }
        public string Typelist { get; set; }
        public string  Time { get; set; }
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] currLine = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);

                string typeOfList = currLine[0];    
                string name = currLine[1];  
                string time = currLine[2];

                Song newSong = new Song()
                { 
                    Name = name,
                    Typelist = typeOfList,
                    Time = time,
                };

                songs.Add(newSong);
            }
            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songs.FindAll(song => song.Typelist == command);

                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }

        }
    }
}
