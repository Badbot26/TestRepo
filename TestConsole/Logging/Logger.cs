namespace TestConsole.Logging;

public class Logger
{
    private readonly string _path;

    public Logger()
    {
        _path = Settings.Paths.LogPath;

        if (!Directory.Exists(_path))
            Directory.CreateDirectory(_path);
    }
    
    public void LogMessage(string message)
    {
        try
        {
            string fileName = _path + DateTime.Now.ToString("yyyyMMdd") + "_log.txt";
            File.AppendAllText(fileName, DateTime.Now.ToString() + ": " + message + Environment.NewLine);
        } catch
        {
            // todo: handle exception
        }
    }
}