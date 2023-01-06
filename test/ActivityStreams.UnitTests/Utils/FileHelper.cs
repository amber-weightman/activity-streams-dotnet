using System.Reflection;

namespace ActivityStreams.UnitTests.Utils;

public static class FileHelper
{
    public static string GetFileLocation(string fileName, string filePath)
    {
        var assembly = Assembly.GetExecutingAssembly();

        return assembly.Location.Replace(assembly.ManifestModule.Name, 
            $"{filePath}\\{fileName}");
    }
}