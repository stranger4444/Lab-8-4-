using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    abstract class DataPrototype
    {
        public abstract DataPrototype Clone();
        public abstract void Display();
    }
}
