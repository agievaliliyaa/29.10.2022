using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Employee
    {
        internal string name;
        internal int ID;
        internal string property;

        internal Employee(string name)
        {
            this.name = name;
        }

        internal Employee(string name, int ID, string property)
        {
            this.name = name;
            this.ID = ID;
            this.property = property;
        }

    }
}
