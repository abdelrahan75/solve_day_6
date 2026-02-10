using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day_6
{
    internal class TypeA
    {
        private int f;
        internal int g;
        public int h;

        public TypeA(int f)
        {
            this.f = f;
          
        }
        public void print()
        {
            Console.WriteLine(this.f + " " + this.g + " " + this.h);
        }
    }
}
