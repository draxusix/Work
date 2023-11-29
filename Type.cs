using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadani
{
    internal class Type
    {
        public string Name { get; set; }
        public string Equation { get; set; }

        public Type(string name, string equation)
        {
            Name = name;
            Equation = equation;
        }
    }
}
