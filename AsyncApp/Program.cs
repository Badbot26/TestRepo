static async Task SimulateLongRunningTaskAsync(int seconds)
{
    await Task.Delay(seconds * 1000);

    // log to text file and console to show when execution in this method resumes
    string logMessage = DateTime.Now.ToString() + ": logged" + Environment.NewLine;
    Console.Write(logMessage);
    await File.AppendAllTextAsync("c:/users/waynem/desktop/log.txt", logMessage);
}

static void SimulateLongRunningTask(int seconds)
{
    Thread.Sleep(seconds * 1000);
    
    // log to text file and console to show when execution in this method resumes
    string logMessage = DateTime.Now.ToString() + ": logged" + Environment.NewLine;
    Console.Write(logMessage);
    File.AppendAllText("c:/users/waynem/desktop/log.txt", logMessage);
}

static async Task<string> LogDataAsync()
{
    System.Console.WriteLine("entered LogDataAsync()");
    try
    {
        await SimulateLongRunningTaskAsync(seconds: 3);
    }
    catch
    {
        return "unsuccessful";
    }
    System.Console.WriteLine("leaving LogDataAsync()");
    return "success";
}

static string LogData()
{
    Console.WriteLine("entered LogData()");
    try
    {
        // simulate long running logging
        SimulateLongRunningTask(seconds: 3);
    }
    catch
    {
        return "unsuccessful";
    }
    Console.WriteLine("leaving LogData()");
        return "success";
}

static async Task<string> UseLogDataAsync()
{
    System.Console.WriteLine("entered UseLogDataAsync()");
    var logDataResponse = await LogDataAsync();
    System.Console.WriteLine("leaving UseLogDataAsync()");
    return logDataResponse;
}

static string UseLogData()
{
    Console.WriteLine("entered UseLogData()");
    var logDataResponse = LogData();
    Console.WriteLine("leaving UseLogData()");
    return logDataResponse;
}

Console.WriteLine("entered program");
var useLogDataResponse = await UseLogDataAsync();
Console.WriteLine("response: " + useLogDataResponse);
Console.WriteLine("leaving program");

Console.ReadLine();