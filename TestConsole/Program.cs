// get user name from the command prompt and print customised 
using System.Data;
using TestConsole.Reader;

Console.Write("Please enter your name: ");
string name = Console.ReadLine() ?? string.Empty;
Console.WriteLine($"Hello {name}, welcome!");

// load dummy data
if (TestConsole.Settings.Flags.LoadDummyData)
{
    if (TestConsole.Helpers.DataLoader.LoadDummyDataIntoTextFile())
        System.Console.WriteLine("Dummy data loaded successfully.");
    else
    {
        System.Console.WriteLine("There was an error loading dummy data.");
        System.Console.WriteLine($"Error: {TestConsole.Helpers.DataLoader.LastError}");
    }
}
else
    System.Console.WriteLine("Dummy data loading stage skipped.");

// read from text file, character by character
TestConsole.Reader.IReader reader = ReaderFactory.GetReader(ReaderType.TextReader,
    path: TestConsole.Settings.Paths.DummyDataPath, filename: TestConsole.Settings.Paths.DummyDataFile);
reader.Read();
System.Console.WriteLine("Read method complete on text reader.");