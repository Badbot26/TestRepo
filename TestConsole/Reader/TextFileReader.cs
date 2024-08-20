namespace TestConsole.Reader;

public class TextFileReader : IReader
{
    private readonly string _path;
    private readonly string _filename;
    private string _exceptionMessage;

    public string ExceptionMessage { get { return _exceptionMessage; } }
    
    public TextFileReader(string path, string filename)
    {
        _path = path;
        _filename = filename;
        _exceptionMessage = string.Empty;
    }

    public void Read()
    {
        int sum = 0;
        try
        {
            using (StreamReader reader = new StreamReader(_path + _filename))
            {
                int character;
                while ((character = reader.Read()) != -1)
                {
                    char charRead = (char)character;
                    
                    if (char.IsDigit(charRead))
                    {
                        sum += (int)charRead;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            this._exceptionMessage = ex.Message;
        }
    }
}