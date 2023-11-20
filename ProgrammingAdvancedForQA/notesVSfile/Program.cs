namespace notesVSfile
{
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
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_");
                string  typeList = input[0];
                string name = input[1];
                string time = input[2];
                songs.Add(new Song(typeList, name, time));
            }

            string command = Console.ReadLine();

            if(command == "all")
            {
                PrintAll(songs);
            }
            else
            {
                PrintFiltered(songs, command);
            }
        }

        private static void PrintFiltered(List<Song> songs, string typeList)
        {
            foreach (Song song in songs)
            {
                if(song.TypeList == typeList)
                {
                    Console.WriteLine(song.Name);
                }    
            }
        }

        private static void PrintAll(List<Song> songs)
        {
            
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}