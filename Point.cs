using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day_6
{
    internal struct Point
    {
        public int x;
        public int y;
        public Point(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

         public override string ToString()
        {
            return  "x = " + this.x + " and " + " y = " + this.y; 
        }

        
    }
}
