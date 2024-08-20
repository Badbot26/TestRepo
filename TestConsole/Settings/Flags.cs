namespace TestConsole.Settings;

public static class Flags
{
    private static bool _loadDummyData = false;
    
    public static bool LoadDummyData { get { return _loadDummyData; } }
}