using Newtonsoft.Json;

namespace ConsoleApp_Test;

public class WorkWithFiles : IWorker
{
    public override void Test()
    {
        ReadFileAsJson();
        // WriteDataToFiles();
        //AppendToFile();
    }

    public static void ReadFileAsJson()
    {
        var salesJson = File.ReadAllText($"stores{Path.DirectorySeparatorChar}a.json");
        var salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);
        Console.WriteLine(salesData?.Total);
    }

    public static void WriteDataToFiles()
    {
        var salesJson = File.ReadAllText($"stores{Path.DirectorySeparatorChar}a.json");
        var data = JsonConvert.DeserializeObject<SalesTotal>(salesJson);
        File.WriteAllText($"stores{Path.DirectorySeparatorChar}totals.txt", data?.Total.ToString());
    }

    public static void AppendToFile()
    {
        File.AppendAllText($"stores{Path.DirectorySeparatorChar}totals.txt", $"{Environment.NewLine}{DateTime.Now}{Environment.NewLine}");
    }
}

class SalesTotal
{
    public double Total { get; set; }
}
