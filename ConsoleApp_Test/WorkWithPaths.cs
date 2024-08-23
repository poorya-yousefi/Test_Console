namespace ConsoleApp_Test;

public class WorkWithPaths : IWorker
{
    public override void Test()
    {
        MakeDir();
    }

    public static void MakeDir()
    {
        var mkdir = Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newDir"));
        bool doesDirectoryExist = Directory.Exists(mkdir.FullName);
        Console.WriteLine(doesDirectoryExist);
    }

    public static void CreateFile()
    {
        File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Hello World!");
    }

    public static void ReadAllFilesInStoreDir()
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        var storesDirectory = Path.Combine(currentDirectory, "stores");

        var salesFiles = FindFiles(storesDirectory);

        foreach (var file in salesFiles)
        {
            Console.WriteLine(file);
        }
    }
    private static IEnumerable<string> FindFiles(string folderName)
    {
        List<string> salesFiles = new List<string>();

        var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

        foreach (var file in foundFiles)
        {
            var extension = Path.GetExtension(file);
            if (extension == ".json")
            {
                salesFiles.Add(file);
            }
        }

        return salesFiles;
    }

}
