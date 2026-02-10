using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day_6
{
    internal struct Employee
    {
        string EMP_ID;
        string Name;
        double salary;

        public void Setname(string name)
        {
            Name = name ?? "no one ";
        }
        public string Getname()
        {
            return Name;
        }
    }
}
