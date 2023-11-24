using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class CsvData : DataPrototype
    {
        public string CsvContent { get; set; }

        public override DataPrototype Clone()
        {
            return new CsvData { CsvContent = this.CsvContent };
        }

        public override void Display()
        {
            Console.WriteLine("CSV Data: " + CsvContent);
        }
    }
}
