using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class Driver
    {
        private string name;

        public Driver(string name)
        {
            Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = string.IsNullOrWhiteSpace(value) ? "UnKnown" : value;
            }
        }

    }
}
