using System;
using System.Collections.Generic;

class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

    public Song(string typeList, string name, string time)
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }
}

class Program
{
    static void Main()
    {
        // Input the number of songs
        int n = int.Parse(Console.ReadLine());

        // Input songs data and create Song objects
        List<Song> songs = new List<Song>();
        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split("_");
            string typeList = data[0];
            string name = data[1];
            string time = data[2];
            songs.Add(new Song(typeList, name, time));
        }

        // Input the command (Type List or "all")
        string command = Console.ReadLine();

        // Output based on the command
        if (command == "all")
        {
            PrintAllSongs(songs);
        }
        else
        {
            PrintSongsByType(songs, command);
        }
    }

    // Function to filter and print songs based on the given type list
    static void PrintSongsByType(List<Song> songs, string typeList)
    {
        foreach (Song song in songs)
        {
            if (song.TypeList == typeList)
            {
                Console.WriteLine(song.Name);
            }
        }
    }

    // Function to print all song names
    static void PrintAllSongs(List<Song> songs)
    {
        foreach (Song song in songs)
        {
            Console.WriteLine(song.Name);
        }
    }
}
