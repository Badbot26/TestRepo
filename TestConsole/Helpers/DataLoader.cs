using System.Text;

namespace TestConsole.Helpers;

public static class DataLoader
{
    private static string _lastError = string.Empty;
    public static string LastError { get {return _lastError;}}
    public static bool LoadDummyDataIntoTextFile()
    {
        try
        {
            string path = @"c:\TestApps\TestRepo\TestConsole\Data\";
            string filename = "dummydata.txt";
            
            // create directory if does not exist
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 100000; i++)
                stringBuilder.Append(i + "somexyztexthere");
            File.WriteAllText(path + filename, stringBuilder.ToString());
            return true;
        }
        catch (Exception ex)
        {
            _lastError = ex.Message;
        }
        return false;
    }
}