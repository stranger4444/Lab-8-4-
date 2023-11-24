using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class XmlData : DataPrototype
    {
        public string XmlContent { get; set; }

        public override DataPrototype Clone()
        {
            return new XmlData { XmlContent = this.XmlContent };
        }

        public override void Display()
        {
            Console.WriteLine("XML Data: " + XmlContent);
        }
    }
}
