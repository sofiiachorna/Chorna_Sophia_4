using System;

namespace Lab_4_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            directory dir = new directory(800, "files");
            dir.add(new File(101, "file1.txt"));
            dir.add(new archive(150, "Photos.rar"));
            dir.add(new File(5000, "FlappyBird.exe"));
            dir.add(new mp3(3000, "Music.mp3"));
            dir.add(new mp3(10000, "song.mp3"));


            Console.WriteLine(dir.countmp3());

            dir.GetAllTypes();
            Console.WriteLine("Input the name of file you want to launch:");
            string a = Console.ReadLine();
            dir.LaunchFile(a);

            Console.WriteLine($"Directoty {dir.name} has size {dir.getsize()} and length {dir.getLength()}");
        }
    }
}
