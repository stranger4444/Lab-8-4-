using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace ConsoleApp19
{
    internal class XmlToJsonAdapter : IDataConverter
    {
        public DataPrototype Convert(DataPrototype source)
        {
            if (source is XmlData xmlData)
            {
                
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlData.XmlContent);

                Console.WriteLine("Converting XML to JSON");
                return new JsonData { JsonContent = JsonConvert.SerializeXmlNode(xmlDoc) };
            }

            return null;
        }
    }
}
