// get user name from the command prompt and print customised 
Console.Write("Please enter your name: ");
string name = Console.ReadLine() ?? string.Empty;
Console.WriteLine($"Hello {name}, welcome!");