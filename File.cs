using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4_oop
{
    public class File : Disk
    {
        public File (int size, string name) : base(size) 
        { 
            this.size = size;
            this.name = name;
        }
        public override void Launch()
        {
            Console.WriteLine($"File {name} successfully launched");
        }
    }

}
