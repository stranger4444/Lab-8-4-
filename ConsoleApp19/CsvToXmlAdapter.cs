using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class CsvToXmlAdapter : IDataConverter
    {
        public DataPrototype Convert(DataPrototype source)
        {
            if (source is CsvData csvData)
            {
                // Реалізація конвертації CSV в XML
                // У цьому прикладі просто виводимо повідомлення про конвертацію
                Console.WriteLine("Converting CSV to XML");
                return new XmlData { XmlContent = "<xml>" + csvData.CsvContent + "</xml>" };
            }

            return null;
        }
    }
}
