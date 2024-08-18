// get user name from the command prompt and print customised 
Console.Write("Please enter your name: ");
string name = Console.ReadLine() ?? string.Empty;
Console.WriteLine($"Hello {name}, welcome!");

if (TestConsole.Settings.Flags.LoadDummyData)
{
    // load dummy data
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