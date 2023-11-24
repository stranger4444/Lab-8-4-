using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class JsonData : DataPrototype
    {
        public string JsonContent { get; set; }

        public override DataPrototype Clone()
        {
            return new JsonData { JsonContent = this.JsonContent };
        }

        public override void Display()
        {
            Console.WriteLine("JSON Data: " + JsonContent);
        }
    }
}
