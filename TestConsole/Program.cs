// get user name from the command prompt and print customised greeting
using System.Data;
using TestConsole.Logging;
using TestConsole.Reader;

Logger logger = new Logger();
logger.LogMessage("entered program");

logger.LogMessage("begin user data collection");
Console.Write("Please enter your name: ");
string name = Console.ReadLine() ?? string.Empty;
Console.WriteLine($"Hello {name}, welcome!");
logger.LogMessage("completed user data collection");

logger.LogMessage("begin load dummy data flag check");
// load dummy data
if (TestConsole.Settings.Flags.LoadDummyData)
{
    logger.LogMessage("begin loading dummy data");
    if (TestConsole.Helpers.DataLoader.LoadDummyDataIntoTextFile())
    {
        System.Console.WriteLine("Dummy data loaded successfully.");
        logger.LogMessage("dummy data load successful");
    }
    else
    {
        System.Console.WriteLine("There was an error loading dummy data.");
        System.Console.WriteLine($"Error: {TestConsole.Helpers.DataLoader.LastError}");
        logger.LogMessage("dummy data load unsuccessful: " + TestConsole.Helpers.DataLoader.LastError);
    }
    logger.LogMessage("completed load dummy data section");
}
else
{
    System.Console.WriteLine("Dummy data loading stage skipped.");
    logger.LogMessage("dummy data load not required");
}

logger.LogMessage("begin text file reader section");
// read from text file, character by character
TestConsole.Reader.IReader reader = ReaderFactory.GetReader(ReaderType.TextReader,
    path: TestConsole.Settings.Paths.DummyDataPath, filename: TestConsole.Settings.Paths.DummyDataFile);
reader.Read();
System.Console.WriteLine("Read method complete on text reader.");
logger.LogMessage("completed text file reader section");

logger.LogMessage("program complete");