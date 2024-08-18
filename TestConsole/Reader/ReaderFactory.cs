namespace TestConsole.Reader;

public static class ReaderFactory
{
    public static IReader GetReader(ReaderType readerType,
        string path = "", string filename = "")
    {
        switch (readerType)
        {
            case ReaderType.TextReader:
                return new TextFileReader(path, filename);
        }
        return null;
    }
}