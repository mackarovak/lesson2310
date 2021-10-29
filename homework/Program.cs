using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homework
{
    class Program
    {
        public static void SearchMail(ref string result)
        {
            result = result.Split('#').Last();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Задание1");
            string PATH = "1.txt";
            if (File.Exists(PATH))
            {
                string[] test = File.ReadAllLines(PATH);
                for (int i = 0; i < test.Length; i++)
                {
                    SearchMail(ref test[i]);
                }
                File.WriteAllLines("output.txt", test);
            }
            else
            {
                Console.WriteLine("Mistakeee");
            }
            Console.WriteLine("Задание2");
            List<Song> songs = new List<Song>();
            for (int i=0; i<4; i++)
            {
                Console.WriteLine("Название песни");
                string name = Console.ReadLine();
                Console.WriteLine("Имя артиста");
                string author = Console.ReadLine();
                songs.Add(new Song(name, author));
            }
            Song.searchsongs(songs);
            Console.ReadKey();
        }
    }
}
