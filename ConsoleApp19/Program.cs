using ConsoleApp19;

class DataConversionApp
{
    static void Main()
    {
        Console.WriteLine("Enter the source data format (CSV, XML, JSON):");
        string sourceFormat = Console.ReadLine();

        Console.WriteLine("Enter the target data format (CSV, XML, JSON):");
        string targetFormat = Console.ReadLine();

        
        DataPrototype sourceData = CreateDataPrototype(sourceFormat);

        
        IDataConverter dataConverter = CreateDataConverter(targetFormat);

        
        DataPrototype targetData = dataConverter.Convert(sourceData);

        
        targetData.Display();

        Console.ReadLine(); 
    }

    static DataPrototype CreateDataPrototype(string format)
    {
        switch (format.ToLower())
        {
            case "csv":
                return new CsvData { CsvContent = "CSV Data" };
            case "xml":
                return new XmlData { XmlContent = "<xml>XML Data</xml>" };
            case "json":
                return new JsonData { JsonContent = "{ \"json\": \"JSON Data\" }" };
            default:
                throw new ArgumentException("Invalid data format");
        }
    }

    static IDataConverter CreateDataConverter(string targetFormat)
    {
        switch (targetFormat.ToLower())
        {
            case "csv":
                return new CsvToXmlAdapter();
            case "xml":
                return new XmlToJsonAdapter();
            case "json":
                return null; // No conversion needed for JSON
            default:
                throw new ArgumentException("Invalid target data format");
        }
    }
}
