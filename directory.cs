using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4_oop
{
   public class directory : Disk
    {
         protected List<Disk> dir = new List<Disk>();
        public directory(int size, string name) : base(size) 
        {
            this.size = size;
            this.name = name;
        }

        public void add(Disk a)
        {
            dir.Add(a);
        }

        public int getLength() => dir.Count;

        public void GetAllTypes()
        {
            foreach (var i in dir)
            {
                Console.WriteLine($"{i.name} - {i.type()}");
            }
        }
        public int countmp3()
        {
            int count = 0;
            foreach (var i in dir)
            {
                if (i.type() == "mp3")
                { count++; }

            }
            return count;
        }

        public void LaunchFile(string name)
        {
            foreach(var i in dir)
            {
                if(i.name.Contains(name)==true)
                {
                    i.Launch();
                }
            }
        }
        
    }
}
