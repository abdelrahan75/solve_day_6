using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day_6
{
    internal class Point1
    {
        public int x;
        public int y;
        public Point1(int _x ) { 
        
            this.x = _x;
            this.y = 0;
        }
        public Point1 (int _x, int _y )
        {
            this.x = _x;
            this.y = _y;
        }

        public void Print()
        {
            Console.WriteLine(this.x + " " + this.y);
        }

        public override string ToString()
        {
            return $"Point[X={x}, Y={y}]";
        }
    }
}
