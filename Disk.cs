using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4_oop
{
    public interface IDisk
    {
        string type();
        int getsize();
        void Launch();
        
    }
    public abstract class Disk : IDisk
    {
        protected int size { get; set; }
        public string name { get; set; }
        public Disk (int size)
        {
            this.size = size;
        }

        public string type() => GetType().Name;
        public int getsize() => size;
       
        public virtual void Launch()
        {
            Console.WriteLine($"{name} successfully launched");
        }

    }
}
