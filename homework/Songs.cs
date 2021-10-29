using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Song
    {
        string name;
        string author;
        public string Name { get { return name; } set {; } }
        public string Author { get { return author; } set {; } }
        public Song(string name, string author)
        {
            this.author = author;
            this.name = name;
        }
        public string Title()
        {
            return name + " " + author;
        }
        public override bool Equals(object d)
        {
            if (d.GetType() != this.GetType())
            {
                return false;
            }
            Song song = d as Song;
            return (this.name == song.name) && (this.author == song.author);
        }

        public static void searchsongs(List<Song> songs)
        {
            bool isfounded = false;
            for (int i = 0; i < songs.Count; i++)
            {
                for (int j = i + 1; j < songs.Count; j++)
                {
                    if (songs[i].Equals(songs[j]))
                    {
                        isfounded = true;
                        Console.WriteLine($"песни под номерами совпали {i + 1} и {j + 1}");
                        Console.WriteLine($"песня {songs[i].name} , автор {songs[i].author}");
                    }
                }
            }
            if (!isfounded)
            {
                Console.WriteLine("одинаковых песен не найдено");
            }
        }
    }
}
